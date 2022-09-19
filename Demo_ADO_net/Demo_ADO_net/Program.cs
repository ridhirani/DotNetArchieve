using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ADO_net
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Creating a Connection 

            //Step 2: Creating Querystring 

            //Step 3: Opening Connection 

            //Step 4: Creating SQL Command 

            //Step 5: Reading Data using SQLDATAREADER class 

            string ConnString = "Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";

            SqlConnection conn = new SqlConnection(ConnString);



            string querystring = " Select * from Ridhi_Persons";

            conn.Open();

            SqlCommand cmd = new SqlCommand(querystring, conn);//Running Querystring on the specified connection string 

            SqlDataReader reader = cmd.ExecuteReader();

            //Console.WriteLine(reader); 



            Console.WriteLine(reader.FieldCount);

            while (reader.Read())

            {

                for (int i = 0; i < reader.FieldCount; i++)

                {

                    Console.Write(reader[i].ToString() + " ");

                }

                Console.WriteLine("--");

                //Console.WriteLine(reader[0].ToString() + " Name is :" + reader[1].ToString() + 

                //    " And Subject is :" + reader[2].ToString() /*+ " " + reader[3].ToString()*/); 

            }


        }
    }
}
