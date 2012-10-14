using System;

namespace RestSharp.Helpers
{
    public static class Int64Helpers
    {
        public static bool TryParse(string input, out Int64 result)
        {
            bool success = false;

            try
            {
                result = Convert.ToInt64(input);
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