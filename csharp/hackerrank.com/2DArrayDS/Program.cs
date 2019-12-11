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
    const int maxShift = 4;
    const int rowLength = 3;
    const int columnLength = 3;
    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int hourglassHighestSum =Int32.MinValue;

        //6 x 6 Matrix
        // Hour Glass 
        // a b c
        //   d
        // e f g
        int[,] hourglass = new int[rowLength, columnLength] { { 1, 1, 1 }, { 0, 1, 0 }, { 1, 1, 1 }};
        int hourglassSum = 0;

        for (int row = 0; row < maxShift; row++)
        {
            for (int column = 0;column<maxShift;column++)
            {
                hourglassSum = 0;
                for (int i = 0; i < rowLength;i++)
                {
                    for(int j = 0; j < columnLength;j++)
                    {
                        hourglassSum += (hourglass[i,j]) *( arr[row + i][column + j]);
                    }
                }
                if(hourglassSum > hourglassHighestSum)
                {
                    hourglassHighestSum = hourglassSum;
                }
            }
        }


        return hourglassHighestSum;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
