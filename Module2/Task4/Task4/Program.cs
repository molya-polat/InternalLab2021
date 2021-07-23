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
            const string str1 = "fwwwhjkl1";
            const string str2 = "ttgghhjj";
            Console.WriteLine(Concat(str1, str2));
        }

        public static string Concat(string str1, string str2)
        {
            try
            {
                if (str1.Length <= 0 || str2.Length <= 0)
                {
                    throw new ArgumentException();
                }

                var sb = new StringBuilder();
                var ch1 = str1.ToCharArray();
                var ch2 = str2.ToCharArray();
                foreach (var c in ch1)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException();
                    }

                    sb.Append(c);
                }

                foreach (var c in ch2)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException();
                    }

                    sb.Append(c);
                }

                var set = new HashSet<char>(sb.ToString().ToCharArray());
                var arr = new char[set.Count];
                set.CopyTo(arr);
                var result = new string(arr);

                return result;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("One of the strings is empty or has symbol which is not letter");
            }

            return null;
        }
    }
}
