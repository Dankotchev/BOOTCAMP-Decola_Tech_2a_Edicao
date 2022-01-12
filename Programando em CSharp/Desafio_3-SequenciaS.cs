using System;
class Sequencia_S
{
    static void Main_(string[] args)
    {
        double a, c, S = 0;
        for (a = 1; a <= 100; a++)
        {
            c = 1 / a;
            S += c;
        }
        ///var x=Math.Round(S,2);
        Console.WriteLine(Math.Round(S, 2));
    }
}