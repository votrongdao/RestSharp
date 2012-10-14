using System;
using System.Globalization;

namespace RestSharp.Helpers
{
    public static class DoubleHelpers
    {
        public static bool TryParse(string input, NumberStyles style, IFormatProvider provider, out double result)
        {
            bool success = false;

            try
            {
                result = double.Parse(input, style, provider);
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