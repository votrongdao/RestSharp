namespace RestSharp.Helpers
{
    using System;
    using System.Globalization;

    public static class LongHelpers
    {
        public static bool TryParse(string input, NumberStyles style, IFormatProvider provider, out long result)
        {
            bool success = false;

            try
            {
                result = long.Parse(input, style, provider);
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