namespace Fundamentos_de_Colecoes_e_LINQ.Models
{
    public class OperacoesArray
    {
        public void PreencherVetor(ref int[] vetor)
        {
            Random randomico = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = randomico.Next(0, 100);
            }
        }

        public void ImprimirArray(int[] vetor)
        {
            var linha = string.Join(", ", vetor);
            Console.WriteLine(linha);
            Console.WriteLine();
        }

        public void OrdenarBubbleShort(ref int[] vetor)
        {
            int temp = 0;
            int limite = 1;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - limite; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
                limite++;
            }
        }

        public void Ordenar(ref int[] vetor)
        {
            Array.Sort(vetor);
        }

        public void Copiar(ref int[] original, ref int[] destino)
        {
            Array.Copy(original, destino, original.Length);
        }

        public bool Existencia(int[] vetor, int valor)
        {
            return Array.Exists(vetor, ente => ente == valor);
        }

        public bool TodosMaiorQue(int[] vetor, int valor)
        {
            return Array.TrueForAll(vetor, ente => ente > valor);
        }

        public int ObterValor(int[] vetor, int valor)
        {
            return Array.Find(vetor, ente => ente == valor);
        }

        public int ObterPosicao(int[] vetor, int valor)
        {
            return Array.FindIndex(vetor, ente => ente == valor);
        }

        public void Redimensionar(ref int[] vetor, int novoTamanho)
        {
            Array.Resize(ref vetor, novoTamanho);
        }

        public string[] ConveterToSring(int[] vetor)
        {
            return Array.ConvertAll(vetor, ente => ente.ToString());
        }
    }
}