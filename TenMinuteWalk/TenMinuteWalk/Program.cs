using System;

namespace TenMinuteWalk
{
    public class Kata
    {
        
        public static bool IsValidWalk(string[] walk)
        {
            int minutes = walk.Length;
            int n = 0;
            int s = 0;
            int e = 0;
            int w = 0;
            
            for (int i = 0; i < walk.Length; i++)
            {                        
                if (walk[i] == "n")
                {
                    n += 1;
                }
                else if(walk[i] == "s")
                {
                    s += 1;
                }
                else if (walk[i] == "e")
                {
                    e += 1;
                }
                else if (walk[i] == "w")
                {
                    w += 1;
                }
                else
                {
                    return false;
                }

            }
            if(minutes == 10 && n == s && e == w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}