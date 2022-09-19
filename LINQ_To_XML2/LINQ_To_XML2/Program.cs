using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_To_XML2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Implemeting LINQ to SQL");
                //step 1 : Connection string
                string path = @"C:\\Users\\Ridhi Rani\\source\repos\\LINQ_To_XML2\\LINQ_To_XML2\\PersonalDetails.xml";
                XDocument xdoc = XDocument.Load(path);
                var students = from participant in xdoc.Descendants("Participant")
                               select new
                               {
                                   ID = Convert.ToInt32(participant.Attribute("ID").Value),
                                   Name = participant.Element("Name").Value

                               };
                foreach (var student in students)
                {
                    Console.WriteLine(student.ID+","+student.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }
    }
}
