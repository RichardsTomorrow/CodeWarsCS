using System;
using System.Globalization;
using System.Text;

public class Accumul
{
    public static String Accum(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            for ( int j = 0; j <i; j++)
            {
                if (j == 0)
                {
                   
                    char temp = Char.ToUpper(s[i]);

                }
                
            }
        }
    }
}