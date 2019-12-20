using System.IO;
using System;
using System.Linq;

class Solution
{

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        long result=0;

        long[] array = new long[n];
        int a = 0, b = 0, k = 0;
        for (int idx = 0; idx < queries.GetLength(0); idx++)
        {
            a = queries[idx][0]-1;
            b = queries[idx][1]-1;
            k = queries[idx][2];
            
            array[a] += k;
            if(b < array.Length - 1)
            { 
                array[b+1] -= k;
            }
        }
        long sum = 0;
        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
            if(sum> result)
            {
                result = sum;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
