/* Main do projeto DomiGest
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
using Caracteristicas;
using Contratos;
using Imoveis;
using Locais;
using Pagamentos;
using Recibos;
using RecursosHumanos;
using Servicos;

namespace DomiGest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Local localDoPorto = new Local("Rua da Alegria", "Porto", "Portugal", "4000-000");
            Local localFamalicao = new Local("Av dos Correios", "Famalicao", "Portugal", "4760-000");

            Gestor maksym = new Gestor("maksym", "123456789", "maksym", "911333444", "maksym@hotmail.com");

            Imovel apartamentoCentro = new Imovel(TipoImovel.Apartamento, localDoPorto, TipoCondicao.Novo, maksym)
            {
                Caracteristica = new Caracteristica(2, 2, true, 84.4, false, true)
            };

            Imovel imovel2 = new Imovel(TipoImovel.Vivenda, localFamalicao, TipoCondicao.Novo, maksym);

            Cliente joaoPedro = new Cliente("João Pedro", "257989632", "912523236", "joaoP@hotmail.com");

            joaoPedro.AdcionarSaldo(10000);

            try
            {
                //Iniciar contracto com o João, no imovel 1 do porto durante 24 meses por 500€ mes e entrada de 200€
                Contrato contratoJoao = new Contrato(joaoPedro, maksym, apartamentoCentro, 200, 24, 500);

                //Criar um recibo online para o João do pagamento da entrada
                Recibo reciboJoaoEntrada = new ReciboOnline(joaoPedro.Nome, localDoPorto.Endereco, contratoJoao.Entrada, DateTime.Now);

                //Buscar o inquilino Joao
                Inquilino joaoPedroInquilino = apartamentoCentro.RetornaInquilino(joaoPedro.NIF);

                //Criar prestacao para o Joao
                Prestacao prestacaoJoaoPedro = new Prestacao(500, DateTime.Now, joaoPedroInquilino);

                //Pagar a prestacao do Joao
                prestacaoJoaoPedro.PagarPrestacao(joaoPedroInquilino, contratoJoao.ValorMensalidade);

                //Criar um recibo online para o João do pagamento da 1ª mensalidade
                Recibo reciboJoaoPrestacao = new ReciboOnline(joaoPedro.Nome, localDoPorto.Endereco, contratoJoao.ValorMensalidade, DateTime.Now);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Impossivel criar contracto porque: {e.Message}");
                throw;
            }

            // Verificar se o apartamentoCentro tem o Joao Pedro como inquilino
            apartamentoCentro.ExisteInquilino(joaoPedro.NIF);

            //Inquilino pede um servico
            Servico servico = new Servico(joaoPedro.Nome,localDoPorto.Endereco,TipoServico.Limpeza, DateTime.Now);

            //Retornar valor do servico
            double valorServico = servico.RetornaPrecoBasePorTipoServico(TipoServico.Limpeza);

            //Criar um recibo online para o João do pagamento do servico
            Recibo reciboJoaoServico = new ReciboOnline(joaoPedro.Nome, localDoPorto.Endereco, valorServico, DateTime.Now);

            //Remover o inquilino do imovel
            apartamentoCentro.RemoverInquilino(joaoPedro.NIF);

            //Verificar se o inquilino foi removido
            bool existeInqiulino =  apartamentoCentro.ExisteInquilino(joaoPedro.NIF);
        }
    }
}

