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

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int neg = 0;
        int pos = 0;
        int zero = 0;

        for(int i = 0;i<arr.Length;i++)
        {
            if(arr[i] > 0)
            {
                pos++;
            }
            else if(arr[i]<0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
        }
        float racPos = ((float)pos) / arr.Length;
        float racNeg = ((float)neg) / arr.Length;
        float racZero = ((float)zero) / arr.Length;

        Console.WriteLine(String.Format("{0:0.000000}", racPos));
        Console.WriteLine(String.Format("{0:0.000000}", racNeg));
        Console.WriteLine(String.Format("{0:0.000000}", racZero));

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
