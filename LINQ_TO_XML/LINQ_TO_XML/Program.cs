using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_TO_XML
{
    class Program
    {
        string path = @"C:\\Users\\Ridhi Rani\\source\repos\\LINQ_TO_XML\\LINQ_TO_XML\\ParticipantDetails.xml";

        private void GetXMLData()
        {
            try
            {
                //step 1 : Connection string
                XDocument xdoc = XDocument.Load(path);
                var students = from participant in xdoc.Descendants("Participant")
                               select new
                               {
                                   ID = Convert.ToInt32(participant.Attribute("ID").Value),
                                   Name = participant.Element("Name").Value

                               };
                foreach (var student in students)
                {
                    Console.WriteLine(student.ID+"-"+student.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // throw;
            }
        }
        private void InsertXMLData(string name)
        {
            try
            {
                XDocument myXML = XDocument.Load(path);
                XElement newParticipant = new XElement("Participant", new XElement("Name", name));
                var lastStudent = myXML.Descendants("Participant").Last();
                int newID = Convert.ToInt32(lastStudent.Attribute("ID").Value);
                newParticipant.SetAttributeValue("ID", newID + 1); //setting Attribute
                myXML.Element("Participants").Add(newParticipant); //adding new element
                myXML.Save(path); // saving changes 
            }
            catch (Exception)
            {

                //throw;
            }
        }
        private void ModifyXMLData(string name,int id)
        {
            try
            {
                XDocument xdoc = XDocument.Load(path);

                XElement participant = xdoc.Descendants("Participant").Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();
                participant.Element("Name").Value = name;
                xdoc.Save(path);

            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void DeleteData(int id)
        {
            try
            {
                XDocument xdoc = XDocument.Load(path);

                XElement participant = xdoc.Descendants("Participant").Where(c => c.Attribute("ID").Value.Equals(id.ToString())).FirstOrDefault();
                participant.Remove();
                xdoc.Save(path);
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Implemeting LINQ to SQL");
            Program o1 = new Program();
            o1.GetXMLData();
            o1.InsertXMLData("Sneh");
            //o1.GetXMLData();
            o1.InsertXMLData("Sikh");
            o1.GetXMLData();
            o1.ModifyXMLData("Sia", 4);
            o1.GetXMLData();
            o1.DeleteData(4);
            o1.GetXMLData();




        }
    }

}
