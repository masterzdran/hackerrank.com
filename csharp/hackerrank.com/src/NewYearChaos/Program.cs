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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int maxBribes = 0;
        int bribesLimit = 2;
        bool chaotic = false;
        int initialPosition = 0;
        int currentPositionValue = 0;
        int diff = 0;
        for (int idx = 0;idx<q.Length;idx++)
        {

            initialPosition = idx + 1;
            currentPositionValue = q[idx];

            // Verify if it is possible 
             diff = initialPosition - currentPositionValue;
            if (diff + bribesLimit < 0)
            {
                chaotic = true;
                break;
            }

            // Add bribes for bigger unsequencial numbers.
            for(int jdx = Math.Max(0, currentPositionValue - bribesLimit); jdx <  idx;jdx++)
            {
                if( q[jdx] > currentPositionValue)
                {
                    maxBribes++;
                }
            }
        }

        Console.WriteLine(chaotic ? "Too chaotic" : $"{ maxBribes}");
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
