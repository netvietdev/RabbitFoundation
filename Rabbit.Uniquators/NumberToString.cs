using System;
using System.Collections;

namespace Rabbit.Uniquators
{
    public static class NumberToString
    {
        public static string Convert(UInt64 number, IdBase radix)
        {
            switch (radix)
            {
                case IdBase.Hexadecimal:
                    return number.ToString("X");
                case IdBase.Hexatrigesimal:
                    return Convert(number, Characters.Hexatrigesimal);
                case IdBase.Sexagesimal:
                    return Convert(number, Characters.Sexagesimal);
                case IdBase.Duosexagesimal:
                    return Convert(number, Characters.Duosexagesimal);
            }

            throw new Exception("Not handle " + radix);
        }

        public static string Convert(UInt64 number, string charactersTable)
        {
            var result = new Stack();
            var radix = (UInt64)charactersTable.Length;

            do
            {
                var m = number % radix;
                result.Push(charactersTable[(int)m]);
                number /= radix;
            } while (number > 0);

            return string.Join(string.Empty, result.ToArray());
        }
    }
}