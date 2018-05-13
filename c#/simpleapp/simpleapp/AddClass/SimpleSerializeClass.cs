using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
namespace simpleapp.AddClass
{
    [Serializable]
    public class SimRadio
    {
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;
        [NonSerialized]
        public string radioID = "xf-552rr6";
    }

    [Serializable]
    public class SimCar
    {
        public SimRadio theRadio = new SimRadio();
        public bool isHatchBack;
    }

    [Serializable]
    public class JamesBondSimCar : SimCar
    {
        public bool canFly;
        public bool canSubmerge;
    }

    public class SimpleSerializeClass
    {
        public static void BinarySerializable()
        {
            JamesBondSimCar jbc = new JamesBondSimCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3,105.1,97.1};
            jbc.theRadio.hasTweeters = true;
            //SaveAsBinaryFormat(jbc,"carData.txt");
            //SaveAsSoapFormat(jbc,"soapData.txt");
            SaveAsXmlFormat(jbc, "xmlData.txt");
        }

        public static void SaveAsBinaryFormat(object objGraph,string filename)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using(Stream fStream = new FileStream(filename,FileMode.Create,FileAccess.Write,FileShare.None))
            {
                binFormat.Serialize(fStream,objGraph);
            }
            Console.WriteLine("=> saved car in binary format!");
        }

        public static void SaveAsSoapFormat(object objGraph, string filename)
        {
            SoapFormatter SoapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                SoapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> saved car in soap format!");
        }

        public static void SaveAsXmlFormat(object objGraph, string filename)
        {
            XmlSerializer XmlFormat = new XmlSerializer(typeof(JamesBondSimCar));
            using (Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> saved car in xml format!");
        }
    }
}
