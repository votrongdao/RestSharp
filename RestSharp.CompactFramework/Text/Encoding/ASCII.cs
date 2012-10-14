namespace RestSharp.Text.Encoding
{
    public static class ASCII
    {
        public static string GetString(byte[] bytes)
        {
            return System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length);
        }
    }
}