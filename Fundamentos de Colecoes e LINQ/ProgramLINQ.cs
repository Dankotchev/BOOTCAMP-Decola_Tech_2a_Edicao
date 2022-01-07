using System.Collections.Generic;
using Fundamentos_de_Colecoes_e_LINQ.Models;
namespace Fundamentos_de_Colecoes_e_LINQ
{
    class Program_LINQ
    {
        static void Main(string[] args)
        {
            /// Aula Coleções Especificas
            // LINQ
            OperacoesArray op = new OperacoesArray();
            int[] vetorInteiros = new int[25];
            op.PreencherVetor(ref vetorInteiros);
            op.ImprimirArray(vetorInteiros);
            /*
            var numerosParesQuery =
                from num in vetorInteiros
                where num % 2 == 0
                orderby num
                select num; */
            var numerosParesMetodo = vetorInteiros.Where(x => x%2 ==0).OrderBy(x => -x).ToList();

            //Console.WriteLine("Numeros Pares (por Query): " + string.Join(", ", numerosParesQuery));
            //Console.WriteLine();
            Console.WriteLine("Numeros Pares (por Método): " + string.Join(", ", numerosParesMetodo));
            Console.WriteLine();
            Console.WriteLine($"Valor Máximo do Vetor: {vetorInteiros.Max()}");
            Console.WriteLine($"Valor Mínimo do Vetor: {vetorInteiros.Min()}");
            Console.WriteLine($"Valor Médio do Vetor : {vetorInteiros.Average()}");
            Console.WriteLine($"soma de todos os valores do vetor: {vetorInteiros.Sum()}");
            var valoresUnicos = vetorInteiros.Distinct().ToArray().OrderBy(x => -x);
            Console.WriteLine("Numeros distintos: " + string.Join(", ", valoresUnicos));
        }
    }
}