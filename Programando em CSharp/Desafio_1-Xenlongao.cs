using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main_(string[] args)
        {
            int nCasos = Convert.ToInt32(Console.ReadLine());
            while (nCasos-- > 0)
            {
                int quantidadeEsferas = Convert.ToInt32(Console.ReadLine());
                int quantidadeEsferasDivisoresPares = 0;
                for (int j = 2; j <= quantidadeEsferas; j++)
                {
                    int contagemDivisores = 2;
                    for (int i = 2; i < Convert.ToInt32(Math.Sqrt(j))+1; i++)
                    {
                        if (j % i == 0) // i é divisor de j estrelas
                        {
                            contagemDivisores +=  (j / i == i) ? 1 : 2;
                        }
                    }
                    if (contagemDivisores % 2 == 0)
                    {
                        quantidadeEsferasDivisoresPares++;
                    }
                }
                Console.WriteLine(quantidadeEsferasDivisoresPares);
            }
        }
    }
}