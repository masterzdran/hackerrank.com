using System.IO;
using System;
using System.Diagnostics;

class Solution
{

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        int nbrSwaps = 0;
        for (int idx = 0;idx<arr.Length-1;idx++)
        {
            int value = arr[idx];
            while (value != idx + 1)
            {
                int aux = arr[value - 1];
                arr[value - 1] = value;
                value = aux;
                nbrSwaps++;
            }
        }
        return nbrSwaps;
    }
    private static int swap(int[] arr, int idx, int jdx)
    {

        return 1;
    }
    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
       
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        var watch = Stopwatch.StartNew();
        int res = minimumSwaps(arr);

        watch.Stop();

        Console.WriteLine(res);

        Console.WriteLine(string.Format("Elapsed time: {0} seconds", watch.Elapsed.TotalSeconds));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
