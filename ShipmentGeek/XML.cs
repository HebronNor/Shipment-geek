using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ShipmentGeek
{
    class XML
    {
        public static void SerializeList<T>(string fileName, List<T> list)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(Var.AssemblyInfo.Name));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, list);
            sww.Flush();
            var xml = sww.ToString();

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            xdoc.Save(fileName);
        }

        public static void DeSerializeList<T>(string fileName, List<T> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(Var.AssemblyInfo.Name));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<T>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }
    }
}
