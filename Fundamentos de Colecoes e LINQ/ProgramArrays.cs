using Fundamentos_de_Colecoes_e_LINQ.Models;
namespace Fundamentos_de_Colecoes_e_LINQ
{
    class Program_Arrays
    {
        static void Main_(string[] args)
        {
            // Aula de Arrays
            OperacoesArray op = new OperacoesArray();
            int[] vetor = new int[25];// { 15, 3, 7, 36, 11, 9, 25, 14, 10, 17 };
            int[] copiaVetor = new int [50];
            Random randomico = new Random();
            int procurado = randomico.Next(100); // Gerar un numero aleatório para buscar dentro do vetor
            
            op.PreencherVetor(ref vetor);
            Console.WriteLine("Vetor Original:");
            op.ImprimirArray(vetor);

            Console.WriteLine("Vetor Cópia:");
            op.ImprimirArray(copiaVetor);

            Console.WriteLine("Copiando para um novo Vetor...");
            op.Copiar(ref vetor, ref copiaVetor);

            //op.OrdenarBubbleShort(ref vetor);
            Console.WriteLine("Ordenando o vetor original...");
            op.Ordenar(ref vetor);
            Console.WriteLine("Vetor Ordenado:");
            op.ImprimirArray(vetor);

            Console.WriteLine("Vetor Copiado:");
            op.ImprimirArray(copiaVetor);

            // Verificar se EXISTE um valor dentro do vetor
            Console.WriteLine($"Buscando o numero {procurado} dentro do vetor ordenado...");
            if (op.Existencia(vetor, procurado))
            {
                Console.WriteLine("Existe sim o Valor dentro do vetor.");
            }
            else
            {
                Console.WriteLine("Não existe o valor dentro do Vetor.");
            }

            // Verificar se todos os elementos satisfazem uma condição
            if (op.TodosMaiorQue(vetor, procurado))
            {
                Console.WriteLine($"Todos os elementos do vetor são maiores que {procurado}.");
            }
            else
            {
                Console.WriteLine($"Existe ao menos um elemento do vetor que é menor do que {procurado}.");
            }

            // Verificar e retornar se existe um valor dentro do vetor
            if (op.ObterValor(vetor, procurado) > 0)
            {
                Console.WriteLine($"Valor {procurado} foi encontrado dentro do vetor!");
            }
            else
            {
                Console.WriteLine($"Não foi encontrado o valor {procurado} dentro do vetor.");
            }

            // Obter a posição dentro do vetor de um derteminado valor
            int posicao = op.ObterPosicao(vetor, procurado);
            if (posicao > -1)
            {
                Console.WriteLine($"O valor {procurado} está presente na posicao {posicao} do vetor.");
            }
            else
            {
                Console.WriteLine($"O valor {procurado} não está presente em nenhuma posição no vetor");
            }

            // Redimendionar um Array
            Console.WriteLine();
            Console.WriteLine($"Capacidade atual do vetor: {vetor.Length}");
            op.Redimensionar(ref vetor, 2 * vetor.Length);
            Console.WriteLine($"Capacidade do vetor após redimensionamento: {vetor.Length}");
            op.ImprimirArray(vetor);
            Console.WriteLine();

            // Convertendo para String
            string[] vetorString = op.ConveterToSring(vetor);

            // Array Unidimencional
            int[] vetorInteiros = new int[4];
            vetorInteiros[0] = 10;
            vetorInteiros[1] = 15;
            vetorInteiros[2] = 20;
            vetorInteiros[3] = int.Parse("25");

            Console.WriteLine("Percorrento o vetor usando FOR:");
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.WriteLine($"Na posição {i} temos p seguinte valor inteiro: {vetorInteiros[i]}");
            }

            Console.WriteLine("Percorrendo o vetor usando FOREACH:");
            foreach (int item in vetorInteiros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Array Multidimensional
            int[,] matriz = new int[3, 3]
            {
                {1,2,3}, // Inicialização passando cada linha :: 1ª Linha e suas 3 colunas
                {4,5,6}, // 2ª Linha
                {7,8,9}  // 3ª Linha
            };
            Console.WriteLine("Percorrendo a matriz usando dois FOR:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}