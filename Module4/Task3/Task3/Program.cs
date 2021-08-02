using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = default;
            int? i = null;
            Console.WriteLine(IsNull(i));
        }

        public static bool IsNull(object? obj)
        {
            return (obj == null) ? true : false;
        }
    }
}
