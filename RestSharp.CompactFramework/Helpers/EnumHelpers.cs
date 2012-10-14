using System;
using System.Linq;
using System.Reflection;

namespace RestSharp.Helpers
{
    public static class EnumHelpers
    {
        public static string[] GetNames(Type enumType)
        {
            FieldInfo[] fieldInfos = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            return fieldInfos.Select(f => f.Name).ToArray();
        }

        public static string GetName(Type enumType, object value)
        {
            FieldInfo[] fieldInfos = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach (var info in fieldInfos)
            {
                var v = (int)info.GetValue(null);
                if (v == (int)value)
                {
                    return info.Name;
                }
            }

            return string.Empty;
        }

        public static object[] GetValues(Type enumType)
        {
            FieldInfo[] fieldInfos = enumType.GetFields(BindingFlags.Static | BindingFlags.Public);
            return fieldInfos.Select(f => f.GetValue(null)).ToArray();
        }
    }
}