/* Class: Despesas
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 20-12-2023
 * 
 * */
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestaoFicheiros
{
    using System.IO;
    using System.Text.Json;
    using System.Collections.Generic;

    public class GuardarFicheiro
    {
        public static bool GuardaDados(string f, List<object> dados)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(dados);
                File.WriteAllText(f, jsonData);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Impossível aceder ao ficheiro...");
            }
        }

        public static List<object> CarregaDados(string f)
        {
            try
            {
                string jsonData = File.ReadAllText(f);
                List<object> dados = JsonSerializer.Deserialize<List<object>>(jsonData);
                return dados ?? new List<object>();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }
    }





}

//public class GuardarFicheiro
//{
//    public static void SaveListToFile(ArrayList lista, string filePath)
//    {
//        try
//        {
//            // Escrever a lista no arquivo
//            using (StreamWriter writer = new StreamWriter(filePath))
//            {
//                foreach (Inquilino inquilino in lista)
//                {
//                    writer.WriteLine($"{inquilino.Nome},{inquilino.Endereco},{inquilino.NIF},{inquilino.Telefone},{inquilino.Email},{inquilino.NumeroMensalidades}");
//                }
//            }
//            Console.WriteLine("Lista de Inquilinos salva no arquivo com sucesso.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Erro ao salvar a lista de Inquilinos no arquivo: {ex.Message}");
//        }
//    }

//    public static ArrayList LoadListFromFile(string filePath)
//    {
//        ArrayList loadedList = new ArrayList();

//        try
//        {
//            // Ler linhas do arquivo para a lista
//            string[] lines = File.ReadAllLines(filePath);
//            foreach (string line in lines)
//            {
//                string[] parts = line.Split(',');
//                if (parts.Length == 6)
//                {
//                    string nome = parts[0];
//                    string endereco = parts[1];
//                    string nif = parts[2];
//                    string telefone = parts[3];
//                    string email = parts[4];
//                    int numeroMensalidades;
//                    if (int.TryParse(parts[5], out numeroMensalidades))
//                    {
//                        Inquilino inquilino = new Inquilino(nome, endereco, nif, telefone, email, numeroMensalidades)
//                        {
//                            Nome = nome,
//                            Endereco = endereco,
//                            NIF = nif,
//                            Telefone = telefone,
//                            Email = email,
//                            NumeroMensalidades = numeroMensalidades
//                        };
//                        loadedList.Add(inquilino);
//                    }
//                }
//            }
//            Console.WriteLine("Lista de Inquilinos carregada do arquivo com sucesso.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Erro ao carregar a lista de Inquilinos do arquivo: {ex.Message}");
//        }

//        return loadedList;
//    }
//}

