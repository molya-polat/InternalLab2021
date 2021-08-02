using System;

namespace ExtensionTask1
{
    public static class Program
    {
        public static string ConvertToIeee(this double d)
        {
            return d.ToString();
        }
    }
}
