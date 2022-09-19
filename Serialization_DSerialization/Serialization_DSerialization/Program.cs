using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_DSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.Id = 1;
            obj.Name = "ASP.Net MVC";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\Ridhi Rani\\source\\repos\\Serialization_DSerialization\\Serialization_DSerialization\\New2.txt", FileMode.Create, FileAccess.ReadWrite);
            formatter.Serialize(stream, obj);
            Console.WriteLine("objects has been serialized");
            stream.Close();
            Stream stream1 = new FileStream("C:\\Users\\Ridhi Rani\\source\\repos\\Serialization_DSerialization\\Serialization_DSerialization\\New2.txt", FileMode.Open, FileAccess.Read);
            Tutorial obj1 = new Tutorial();
            formatter.Deserialize(stream1);
            Console.WriteLine("Data after Desearialization");
            Console.WriteLine(obj1.Id);
            Console.WriteLine(obj1.Name);

        }
    }
}
//C:\Users\Ridhi Rani\source\repos\Serialization_DSerialization\Serialization_DSerialization\Serialization_DSerialization.csproj
