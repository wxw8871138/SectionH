using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionH
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //char[,] c1 = new char[3, 2]
            //{
            //    { 'a','a' }, { 'b','b' }, { 'c','c' }
            //};

            //Console.WriteLine( UseStatic.InString(s1, s2));
            //Console.WriteLine(UseStatic.FindWord(s1, s2));
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i + ": " + UseStatic.to16(i) + ": " + Convert.ToString(0xa,2) /*int.Parse(UseStatic.to16(i), System.Globalization.NumberStyles.AllowHexSpecifier)*/);
            //}

            //SectionG 1.
            //string s = Console.ReadLine();
            //s = s.ToUpper();
            //string ss;
            //int cA = 0, cE = 0, cI = 0, cO = 0, cU = 0;
            //for(int i = 0; i < s.Length; i++)
            //{
            //    ss = s.Substring(i, 1);
            //    if (ss == "A") { cA++; };
            //    if (ss == "E") { cE++; };
            //    if (ss == "I") { cI++; };
            //    if (ss == "O") { cO++; };
            //    if (ss == "U") { cU++; };

            //}
            //Console.WriteLine("a:{0},e:{1},i:{2},o:{3},u:{3}", cA, cE, cI, cO, cU);
             Console.WriteLine( UseStatic.Substitute("lksajfaskdgfsd", 'a', '!'));
        }
    }
    public class UseStatic
    {
        public static bool InString(string s1, string s2)
        {
            s1=s1.ToUpper();
            s2=s2.ToUpper();
            if (s1.Contains(s2))
            {
                return true;
            }
            return false;
        }
        public static int FindWord(string s1, string s2)
        {
            s1=s1.ToUpper();
            s2=s2.ToUpper();
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                if (s1.Substring(i, s2.Length).Contains(s2))
                {
                    return i+1;
                }
            }
            return -1;
        }
        public static string to16(int i)
        {
            string s = i.ToString("x");
            return s;
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string s1 = c1.ToString();
            string s2 = c2.ToString();
            string ss = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1).Equals(s1))
                {
                    ss = ss + s2;
                }else
                {
                    ss = ss + s[i];
                }
            }
            return ss;
        }
    }
}
