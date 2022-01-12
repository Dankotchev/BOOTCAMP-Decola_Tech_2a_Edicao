using System;
class Sequencia_IJ
{
    static void Main_(string[] args)
    {
        for (int i = 1; i <= 9; i = i +2)
        {
            for (int j = 7; j >= 5; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}