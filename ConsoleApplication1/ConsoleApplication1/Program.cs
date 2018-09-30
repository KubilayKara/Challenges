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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        string Result = "Yes";
        var foos = new List<string>(magazine.Length);
        foos = magazine.ToList();

        var notes = new List<string>(note.Length);
        notes = note.ToList();

        var howmanynote = new List<string>(note.Length) ;
        var howmanymag = new List<string>(magazine.Length);




        for (int i = 0; i < note.Length; i++)
        {

   
            int indexx = foos.IndexOf(note[i]);

            howmanynote = notes.FindAll(delegate (string s) { return s == note[i]; });
            howmanymag = foos.FindAll(delegate (string t) { return t == note[i]; });

            if(howmanymag.Count< howmanynote.Count)
            {

                Result = "No";
                break;
            }
              

            //int indexx = Array.IndexOf(magazine, note[i]);
            if (indexx>=0)
            {

                //Array.Clear(magazine, indexx, 1);
                
                    
                    foos.RemoveAt(indexx);
                
            }
            else
            {
                Result = "No";
                break;
            }

      
        }

        Console.WriteLine(Result);
     

    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
