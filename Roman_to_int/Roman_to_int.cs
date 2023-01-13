using System;
using System.Collections.Generic;
namespace Roman_to_int
{
    class Program
    {
        static public int RomanToInt(string s)
        {
            Dictionary<char, int> RomToInt = new Dictionary<char, int>()
        {
            {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
        };
            var answer = new int();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (RomToInt.ContainsKey(s[i]))
                {
                    answer += RomToInt[s[i]];
                    if (i != 0)
                    {
                        if (RomToInt[s[i]] > RomToInt[s[i - 1]])
                        {
                            answer -= RomToInt[s[i - 1]];
                            i--;
                        }
                    }
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入羅馬字母:");
            string input = Console.ReadLine();
            Console.WriteLine(RomanToInt(input).ToString());
            //finsh
        }
    }
}
