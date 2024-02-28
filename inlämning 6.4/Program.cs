using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 upphöjt till 2 är: " + Potens(3, 2));
        Console.WriteLine("6,2 upphöjt till 4 är: " + Potens(6.2, 4));
    }

    static double Potens(double bas, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent == 1)
        {
            return bas;
        }
        else
        {
            double resultat = 1;
            for (int i = 0; i < exponent; i++)
            {
                resultat *= bas;
            }
            return resultat;
        }
    }
}
