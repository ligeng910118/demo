using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
namespace simpleapp.AddClass
{
    public class CustomStreamClass
    {
        public static void CustomStreamMain(){
            StringData myData = new StringData();
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream("MyData.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, myData);
            }
        } 
    }

    public class StringData : ISerializable
    {
        private string dataItemOne = "first data block";
        private string dataItemTwo = "more data";

        public StringData(){}

        protected StringData(SerializationInfo si,StreamingContext ctx)
        {
            dataItemOne = si.GetString("first_item").ToLower();
            dataItemTwo = si.GetString("data_item_two").ToLower();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("first_item",dataItemOne.ToUpper());
            info.AddValue("data_item_two",dataItemTwo.ToUpper());
        }
    }
}
