using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Task5
{
     public  class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine(MyFunc(1234321));
        }

        public static int MyFunc(int number)
        {
            var str = number.ToString();

            var ch = str.ToCharArray();
            
            StringBuilder sb = new StringBuilder();
          
            var min = int.MaxValue;
            
            for (var i = 0; i < ch.Length - 1; i++)
            {
                for (var j = i + 1; j < ch.Length; j++)
                {
                    Swap(ref ch[i], ref ch[j]);
                    foreach (var c in ch)
                    {
                        sb.Append(c);
                    }
                    var result = int.Parse(sb.ToString());
                    if (result != number && result > number && min > result)
                    {
                        min = result;
                    }

                    sb.Clear();
                    Swap(ref ch[i], ref ch[j]);
                }
            }

            if (min == int.MaxValue) return -1;
            {
                var chNew = min.ToString().ToCharArray();
                var index = 0;
                while (ch[index] == chNew[index])//search index where the different digits start
                {
                    index++;
                }

                ch = chNew[(index+1)..chNew.Length];
                Array.Sort(ch);
                var m = 0;
                for (var k = index + 1; k < chNew.Length; k++)
                {
                    chNew[k] = ch[m++];
                }

                var sbNew = new StringBuilder();
                foreach (var c in chNew)
                {
                    sbNew.Append(c);
                }
                var finalResult = int.Parse(sbNew.ToString());
                if (number == finalResult)
                {
                    return -1;
                }

                return finalResult;
            }

        }

        static void Swap(ref char a, ref char b)
        { 
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
