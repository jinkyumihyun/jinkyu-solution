using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clone.Classes
{
    public static class CloneHelper<T>

    {
        public static T? CreateDeepCopyBinary(T? obj)
        {
            using (var ms = new MemoryStream())
            {
                if (obj == null)
                {
                    return default(T);
                }
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T?)formatter.Deserialize(ms);
            }
        }

        public static T? CreateDeepCopyXML(T? obj)
        {
            if (obj == null)
            {
                return default(T);
            }
            using (var ms = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T?)serializer.Deserialize(ms);
            }
        }
    
    }
}
