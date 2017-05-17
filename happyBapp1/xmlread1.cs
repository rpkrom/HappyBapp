using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace happyBapp1
{
    class xmlread1
    {
        public sealed class GenericSerializer<T>
        {
            public static string Serialize(T instance)
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                using (StringWriter sw = new StringWriter())
                {
                    xs.Serialize(sw, instance);

                    return sw.ToString();
                }
            }

            public static T Deserialize(string xmlData)
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                using (StringReader sr = new StringReader(xmlData))
                {
                    return (T)xs.Deserialize(sr);
                }
            }
        }
    }
}
