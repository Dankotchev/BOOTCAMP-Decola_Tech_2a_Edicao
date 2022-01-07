using System.Collections.Generic;
using Fundamentos_de_Colecoes_e_LINQ.Models;
namespace Fundamentos_de_Colecoes_e_LINQ
{
    class Program_Fila_Pilha
    {
        static void Main_(string[] args)
        {
            /// Aula Coleções Especificas
            // Fila
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Danilo");
            fila.Enqueue("Daniele");
            fila.Enqueue("Tereza");
            fila.Enqueue("Lucas");

            Console.WriteLine($"Pessoas na Fila: {fila.Count}.");
            while (fila.Count > 0)
            {
                Console.WriteLine($"Vez de: {fila.Peek()}.");
                Console.WriteLine($"{fila.Dequeue()} atendido.");
            }
            Console.WriteLine($"Pessoas na Fila: {fila.Count}.");

            Console.WriteLine();

            // Pilha
            Stack<string> pilha = new Stack<string>();
            pilha.Push("It - A Coisa");
            pilha.Push("Clube da Luta");
            pilha.Push("Prince of Thornes");

            Console.WriteLine($"Quantidade de livros a ler: {pilha.Count}");
            while (pilha.Count > 0)
            {
                Console.WriteLine($"Próximo livro a ser lido: {pilha.Peek()}");
                Console.WriteLine($"Livro \"{pilha.Pop()}\" Lido.");
            }
            Console.WriteLine($"Quantidade de livros a ler: {pilha.Count}");

        }
    }
}