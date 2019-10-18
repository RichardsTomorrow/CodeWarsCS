using System;
public class Kata
{
    public static int FindShort(string s)
    {
        string[] str = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string shortestWord = str[0];

        for(int i = 0; i < str.Length; i++)
        {
            if(shortestWord.Length > str[i].Length)
            {
                shortestWord = str[i];
            }
        }

        return shortestWord.Length;
    }
}
