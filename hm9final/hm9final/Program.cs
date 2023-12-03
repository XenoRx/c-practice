using System.Text.Json;
using System.Xml;

namespace JsonToXmlConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string json = @"
            {
                ""Book"": [
                    {
                    ""Title"": ""Book 1"",
                    ""Author"": ""Author 1""
                    },
                    {
                    ""Title"": ""Book 2"",
                    ""Author"": ""Author 2""
                    }
                ]
            }";

            JsonDocument doc = JsonDocument.Parse(json);

            using XmlWriter writer = XmlWriter.Create("books.xml");
            writer.WriteStartDocument();

            ConvertToXml(doc.RootElement, writer);

            writer.WriteEndDocument();
            writer.Flush();

            Console.WriteLine("Conversion complete!");
        }

        private static void ConvertToXml(JsonElement element, XmlWriter writer)
        {
            string tagName = XmlConvert.VerifyName(
                element.ValueKind == JsonValueKind.Array ? "BookList" : "Title");

            writer.WriteStartElement(tagName);

            if (element.ValueKind == JsonValueKind.Object)
            {
                foreach (var prop in element.EnumerateObject())
                    ConvertToXml(prop.Value, writer);
            }

            if (element.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in element.EnumerateArray())
                    ConvertToXml(item, writer);
            }

            if (element.ValueKind == JsonValueKind.String)
            {
                writer.WriteString(element.GetString());
            }

            writer.WriteEndElement();
        }
    }
}