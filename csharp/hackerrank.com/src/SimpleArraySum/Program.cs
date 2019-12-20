namespace SimpleArraySum
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Solution
    {

        /*
         * Complete the simpleArraySum function below.
         */
        static int simpleArraySum(int[] ar)
        {
            int result = 0;
            int idx = 0;
            int nbr = ar.Length;
            if (nbr % 2 == 1)
            {
                result = ar[nbr - 1];
                nbr--;
            }

            while (idx < nbr/2)
            {
                result += ar[idx] + ar[nbr - idx - 1];
                idx++;
            }


            return result;
        }

        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            System.Console.WriteLine(result);

        }
    }
}
