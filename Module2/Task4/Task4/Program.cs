using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var str1 = "fwwwhj78kl";
            var str2 = "ttggh22hjj";
            Console.WriteLine(Concat(str1, str2));
        }

        public static string Concat(string str1, string str2)
        {

            if (str1.Length <= 0 || str2.Length <= 0)
            {
                throw new ArgumentException();
            }

            StringBuilder sb = new StringBuilder();
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            foreach (var c in ch1)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            foreach (var c in ch2)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            HashSet<char> set = new HashSet<char>(sb.ToString().ToCharArray());
            char[] arr = new char[set.Count];
            set.CopyTo(arr);
            string result = new string(arr);

            return result;

        }
    }
}
