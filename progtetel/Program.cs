using System;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { -99, 12, 21, 666, -4, 69, 45, 82};

            //Maximum kiválasztás - Person number two rawrrrr
            int i = 0;
            int n = x.Length;
            int maxi = x[0];
            int k = 0;
            for (i = 0; i < n; i++)
            {
                if (maxi < x[i])
                {
                    maxi = x[i];
                    k = i;
                }
            }
            Console.WriteLine($"{maxi} {k}");

            //Párosak kiválogatása - Ewwww romaniannn 
            int[] parosak = new int[100];
            int db = 0;
            for (i = 0; i < x.Length; i++)
            {
                parosak[db] = x[i];
                db++;
            }
        }
    }
}
