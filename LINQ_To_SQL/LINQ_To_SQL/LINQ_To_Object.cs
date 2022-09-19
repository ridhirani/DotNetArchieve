using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_SQL
{
    [Table(Name = "Sales.SalesTerritory")]

    public class Country

    {

        [Column]

        public string Group;

        [Column]

        public string Name;

        
    }

        public partial class LINQ_To_Object : Form
        {
            public LINQ_To_Object()
            {
                InitializeComponent();
            }

            private void LINQ_To_Object_Load(object sender, EventArgs e)
            {
            string conn = "Data Source = 192.168.1.230; Initial Catalog = AdventureWorks2017; Persist Security Info = True; User ID = trainee2022; Password = trainee@2022";

                try
                {

                    //Creating Data Context 

                    DataContext db = new DataContext(conn);

                    Table<Country> Countries = db.GetTable<Country>();//Retunrs the table of similar type 



                //Query DB 

                var countryDetails =

                                       from c in Countries

                                       where c.Group == "North America"

                                           orderby c.Name

                                           select c;



                    //DISPLAY Contact details 

                    foreach (var c in countryDetails)

                    {

                        //textBox1.AppendText(c.Title); 

                        //textBox1.AppendText("\t"); 

                        textBox1.AppendText(c.Group);
                        textBox1.AppendText("\n");


                    //textBox1.AppendText("\t \t");

                    textBox1.AppendText(c.Name);

                        //textBox1.AppendText("\n");

                        textBox1.AppendText("\n");

                    }

                }

                catch (Exception ex)

                {



                    MessageBox.Show(ex.Message);

                }

            }

        }
    }
      
