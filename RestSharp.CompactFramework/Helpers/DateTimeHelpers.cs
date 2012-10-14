using System;

namespace RestSharp.Helpers
{
    using System.Globalization;

    public static class DateTimeHelpers
    {
        public static bool TryParse(string input, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            bool success = false;

            try
            {
                result = DateTime.Parse(input, provider, styles);
                success = true;
            }
            catch (FormatException)
            {
                result = new DateTime();
            }
            catch (InvalidCastException)
            {
                result = new DateTime();
            }

            return success;
        }

        public static bool TryParseExact(string input, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            bool success = false;

            try
            {
                result = DateTime.ParseExact(input, formats, provider, styles);
                success = true;
            }
            catch (FormatException)
            {
                result = new DateTime();
            }
            catch (InvalidCastException)
            {
                result = new DateTime();
            }

            return success;
        }
    }
}