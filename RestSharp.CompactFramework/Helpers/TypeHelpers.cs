namespace RestSharp.Helpers
{
    public class TypeHelpers
    {
        static System.Type[] _emptyTypes = new System.Type[0];

        public static System.Type[] EmptyTypes
        {
            get { return _emptyTypes; }
        }
    }
}