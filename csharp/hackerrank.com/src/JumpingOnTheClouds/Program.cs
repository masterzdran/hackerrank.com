namespace JumpingOnTheClouds
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    public class Solution
    {

        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int result = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if (i + 1 < c.Length)
                {
                    if (i + 2 < c.Length && c[i + 1] == 0 && c[i + 2] == 0)
                    {
                        result += 1; i += 1;
                    }
                    else if (c[i + 1] == 0) 
                    { 
                        result += 1; 
                    }
                    else if (c[i + 1] == 1) 
                    { 
                        result += 1; i += 1; 
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
