using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm7
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CustomNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CustomNameAttribute(string name)
        {
            Name = name;
        }
    }

    internal class TestClass
    {
        [CustomName("CustomFieldName")]
        public int I = 10;

        public string StringProperty = "Some string";
    }
}
