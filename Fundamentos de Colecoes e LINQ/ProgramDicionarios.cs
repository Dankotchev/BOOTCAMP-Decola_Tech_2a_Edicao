using System.Collections.Generic;
using Fundamentos_de_Colecoes_e_LINQ.Models;
namespace Fundamentos_de_Colecoes_e_LINQ
{
    class Program_Dicionarios
    {
        static void Main_(string[] args)
        {
            /// Aula Coleções Especificas
            // Dicionários
            Dictionary<string, string> estados = new Dictionary<string, string>();
            string valorProcurado = "MG";
            estados.Add("SP", "São Paulo");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("MG", "Minas Gerais");

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} // Estado : {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Procurando pelo valor associado a chave {valorProcurado} dentro do dicionário. E seu valor é {estados[valorProcurado]}.");
            Console.WriteLine();
            estados[valorProcurado] = "Teste de Atualização de Valor. Favor retonar ao normal após o teste";
            Console.WriteLine($"Procurando pelo valor associado a chave {valorProcurado} dentro do dicionário. E seu valor é {estados[valorProcurado]}.");

            Console.WriteLine();
            Console.WriteLine($"Removendo o valor da chave {valorProcurado}");
            estados.Remove(valorProcurado);

            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} // Estado : {item.Value}");
            }

            Console.WriteLine();
            //valorProcurado = "SP";
            if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                Console.WriteLine($"Estado com a chave {valorProcurado} é o {estadoEncontrado}");
            }
            else
            {
                Console.WriteLine($"A chave {valorProcurado} não existe no Dicionário");
            }

        }
    }
}