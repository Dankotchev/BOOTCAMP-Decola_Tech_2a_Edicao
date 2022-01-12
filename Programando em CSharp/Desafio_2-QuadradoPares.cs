using System;

class QuadradoPares
{
    static void Main_(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int potencia;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                potencia = Convert.ToInt32(Math.Pow(i, 2));
                Console.WriteLine($"{i}^2 = {potencia}");
            }
        }
    }
}