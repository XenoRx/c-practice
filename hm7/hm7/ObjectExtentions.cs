using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hm7
{
    internal static class ObjectExtentions
    {
        public static string ObjectToString(this object obj)
        {
            var sb = new StringBuilder();

            var type = obj.GetType();
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (var field in fields)
            {
                var name = field.Name;
                var customName = field.GetCustomAttribute<CustomNameAttribute>();
                if (customName != null)
                {
                    name = customName.Name;
                }

                object value = field.GetValue(obj);
                sb.AppendLine($"{name}: {value}");
            }

            return sb.ToString();
        }

        public static void StringToObject(this object obj, string data)
        {
            var type = obj.GetType();
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (var field in fields)
            {
                var name = field.Name;
                var customName = field.GetCustomAttribute<CustomNameAttribute>();
                if (customName != null)
                {
                    name = customName.Name;
                }

                var valueString = data.Split("\n")
                    .FirstOrDefault(x => x.StartsWith($"{name}:"));
                if (!string.IsNullOrEmpty(valueString))
                {
                    var value = valueString.Split(':')[1].Trim();
                    if (field.FieldType == typeof(int))
                        field.SetValue(obj, int.Parse(value));
                    // ...
                }
            }
        }
    }
}
