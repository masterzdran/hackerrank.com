namespace SimpleArraySum
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Solution
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            int[] result =  { 0, 0 };

            for (int idx = 0; idx < a.Count;idx++)
            {
                if(a[idx] > b[idx])
                {
                    alice++;
                }
                else if (b[idx] > a[idx])
                {
                    bob++;
                }
            }
            result[0] = alice;
            result[1] = bob;
            return result.ToList();
            
        }

        static void Main(string[] args)
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
