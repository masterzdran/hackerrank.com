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

    // Complete the marsExploration function below.
    static int marsExploration(string s)
    {
        int nbrOfChanges = 0;
        int nbrOfRepeats = ((s.Length) / 3);
        int idx = 0;
        for(int itr = 0;itr<nbrOfRepeats;itr++)
        {
            idx = itr * 3;
            if (!s.ElementAt(idx).Equals('S'))
            {
                nbrOfChanges++;
            }
            if (!s.ElementAt(idx+1).Equals('O'))
            {
                nbrOfChanges++;
            }
            if (!s.ElementAt(idx+2).Equals('S'))
            {
                nbrOfChanges++;
            }
            
        }

        return nbrOfChanges;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
