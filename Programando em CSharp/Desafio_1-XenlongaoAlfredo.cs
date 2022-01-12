using System;
namespace ConsoleApp1
{
    class Xenlongao_AlfredoNeto // Solução dada po Alfredo Neto no forum da DIO
    {
        static void Main(string[] args)
        {
            var testes = int.Parse(Console.ReadLine());
            for (int i = 0; i < testes; i++)
            {
                var esferas = int.Parse(Console.ReadLine());
                Console.WriteLine(esferas - Math.Floor(Math.Sqrt(esferas)));
            }
        }
    }
}