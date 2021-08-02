using System.Runtime.InteropServices;
using System.Text;

namespace Task1
{
    public static class Extension
    {

        public static string ConvertToIeee(this double number)
        {
            var bits = new DoubleLongNumber(number);
            var bitsInLong = bits.ToLong();
            var result = new StringBuilder();
            for (var i = 0; i < 64; i++)
            {
                result.Insert(0, (bitsInLong & 1) == 1 ? "1" : "0");

                bitsInLong >>= 1;
            }

            return result.ToString();
            
        }


        [StructLayout(LayoutKind.Explicit)]
        private struct DoubleLongNumber
        {
            [FieldOffset(0)]
            private readonly long _long64bits;

            [FieldOffset(0)]
            private readonly double _double64bits;

            public DoubleLongNumber(double value) : this()
            {
                _double64bits = value;
            }

            public long ToLong() => _long64bits;
        }
    }
}
