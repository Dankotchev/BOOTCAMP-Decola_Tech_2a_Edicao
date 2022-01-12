using System;
class VaiTerCopa
{
    static void Main_(string[] args)
    {
        string entrada;
        while ((entrada = Console.ReadLine()) != null)
        {
            if (entrada == null)
            {
                return;
            }
            else
            {
                int x = int.Parse(entrada);
                if (x == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}