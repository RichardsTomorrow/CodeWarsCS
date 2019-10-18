using System;
using System.Collections.Generic;
using System.Linq;

public class TwoToOne
{

    public static string Longest(string s1, string s2)
    {
        string s3 = String.Concat(s1, s2);
        char[] temp = s3.ToCharArray();
        Array.Sort(temp);
        List<char> resultL = new List<char>();
        
        for(int i = 0; i < temp.Length; i++)
        {
            if (temp[i] != temp[i + 1])
            {
                resultL.Add(temp[i]);
            } 
            else
            {
                break;
            }
        }
        char[] result = resultL.ToArray();


        return new string(result);

        
    }
}