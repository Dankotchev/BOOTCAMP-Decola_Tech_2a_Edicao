namespace Fundamentos_de_Colecoes_e_LINQ.Models
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            Console.WriteLine($"Quantidade de Elementos na listas: {lista.Count}");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice na lista: {i} // Estado: {lista[i]}");
            }
            Console.WriteLine();
        }

        public void RemoverElemento(List<string> lista, string elemento)
        {
            Console.WriteLine($"Removendo um elemento da lista passando o elemento, neste caso {elemento}");
            lista.Remove(elemento);
        }

        public void RemoverElementoIndice(List<string> lista, int indice)
        {
            Console.WriteLine($"Removendo um elemento da lista passando um valor de posiçao, neste caso {indice}");
            lista.RemoveAt(indice);
        }

        public void AdicionarPartirString(List<string> lista, string[] array)
        {
            Console.WriteLine("Adicionando elementos do Array na lista.");
            lista.AddRange(array);
        }

        public void AdicionarPorIndice(List<string> lista, int indice, string elemento)
        {
            Console.WriteLine($"Adiciona um elemento ({elemento}) em uma determinada posição ({indice}) dentro da lista.");
            lista.Insert(indice, elemento);
        }
    }
}