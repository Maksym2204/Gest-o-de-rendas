namespace Imoveis
{
    /// <summary>
    /// Interface que define a estrutura básica para um objeto Imóvel.
    /// </summary>
    public interface IImovel
    {
        /// <summary>
        /// Retorna o preço base com base no tipo de imóvel.
        /// </summary>
        /// <param name="tipoImovel">O tipo do imóvel.</param>
        /// <returns>O preço base.</returns>
        double RetornaPrecoBasePorTipoImovel(TipoImovel tipoImovel);
    }
}