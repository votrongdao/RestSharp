using System;
using System.Globalization;

namespace RestSharp.Helpers
{
    public static class UInt32Helpers
    {
        [CLSCompliantAttribute(false)]
        public static bool TryParse(string input, NumberStyles style, IFormatProvider provider, out uint result)
        {
            bool success = false;

            try
            {
                result = uint.Parse(input, style, provider);
                success = true;
            }
            catch (FormatException)
            {
                result = 0;
            }
            catch (InvalidCastException)
            {
                result = 0;
            }

            return success;
        }
    }
}