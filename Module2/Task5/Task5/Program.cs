using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Task5
{
     public  class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine(MyFunc(8945612));
            //8337242
        }

        public static int MyFunc(int number)
        {
            string str = number.ToString();

            char[] ch = str.ToCharArray();
            
            StringBuilder sb = new StringBuilder();
            bool flag = false;
            int index = 0;
            for (var i = 0; i < ch.Length - 1; i++)
            {
                if (flag)
                {
                    break;
                }

                for (var j = i + 1; j < ch.Length; j++)
                {
                  if (ch[i] < ch[j])
                  {
                        Swap(ref ch[i], ref ch[j]);
                        flag = true;
                        Console.WriteLine(i);
                        index = i;
                        break;
                  }
                }
            }
            for (var i = index + 2; i < ch.Length; i++)
            {
                var key = ch[i];
                var j = i;
                while ((j > 1) && (ch[j - 1] > key))
                {
                    Swap(ref ch[j - 1], ref ch[j]);
                    j--;
                }

                ch[j] = key;
            }
            foreach (var c in ch)
            {
                sb.Append(c);
            } 

            var result = int.Parse(sb.ToString());
            if (number == result)
            {
                return -1;
            }

            return result;

        }

        static void Swap(ref char a, ref char b)
        { 
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
