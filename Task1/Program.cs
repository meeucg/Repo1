using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] a = {0,1,2,0,3,4,5,0,0,1};
            ShiftZeros(a);
            foreach(int i in a){Console.Write("{0} ", i);}*/
            /*Console.WriteLine(CanConstructByMagazine("abab", "bab"));*/
            Console.WriteLine(IsRotatedString("abcde", "kcdea"));
        }

        static void ShiftZeros(int[] array)
        {
            int zeroesCount = 0;
            for (int i = 0; i + zeroesCount < array.Length - 1; i++)
            {
                for(int j = i + zeroesCount; j < array.Length && array[j] == 0; j++)
                {zeroesCount++;}
                array[i] = array[i + zeroesCount];
                array[i + zeroesCount] = 0;
            }
        }
        static bool CanConstructByMagazine(string ransomNote, string magazine) 
        {
            int[] digitCount = new int[magazine.Length];

            foreach(char i in magazine)
            {
                digitCount[magazine.IndexOf(i)]++;
            }
            foreach(char i in ransomNote)
            {
                digitCount[magazine.IndexOf(i)] -= 1;
            }
            foreach(int i in digitCount)
            {
                if(i<0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsRotatedString(string s, string goal) 
        {
            char end = s[s.Length-1];
            char start = s[0];
            bool res = false;
            for(int i = 0; i < s.Length - 1; i++)
            {
                if(goal[i] == end && goal[i+1] == start)
                {
                    res = true;
                    for(int j = 0; j < s.Length - 2; j++)
                    {
                        if(goal[(i+2+j) % s.Length] != s[1+j])
                        {
                            res = false;
                            break;
                        }
                    }
                }
                else
                {
                    continue;
                }
                if(res){return res;}
            }
            return res; 
        }
    }
}