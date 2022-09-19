using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ADO_Net_Data_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet4.Ridhi_Persons' table. You can move, or remove it, as needed.
            this.ridhi_PersonsTableAdapter1.Fill(this.freshers_Training2022DataSet4.Ridhi_Persons);
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet3.RIDHI_ORDER5' table. You can move, or remove it, as needed.
            this.rIDHI_ORDER5TableAdapter.Fill(this.freshers_Training2022DataSet3.RIDHI_ORDER5);
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet2.Ridhi_Order' table. You can move, or remove it, as needed.
            //this.ridhi_OrderTableAdapter1.Fill(this.freshers_Training2022DataSet2.Ridhi_Order);
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet1.Ridhi_Persons' table. You can move, or remove it, as needed.
            this.ridhi_PersonsTableAdapter.Fill(this.freshers_Training2022DataSet1.Ridhi_Persons);
            // TODO: This line of code loads data into the 'freshers_Training2022DataSet.Ridhi_Order' table. You can move, or remove it, as needed.
            //this.ridhi_OrderTableAdapter.Fill(this.freshers_Training2022DataSet.Ridhi_Order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022";
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlConnection myConnection1 = new SqlConnection(connectionString);


            //myConnection.ConnectionString = connectionString;

            myConnection.Open();
            myConnection1.Open();

            string queryString = "Select * from Ridhi_Persons";
            string queryString1 = "Select * from RIDHI_ORDER5";
            //SqlDataAdapter myDataAdapter1 = new SqlDataAdapter(queryString1, myConnection);

            SqlDataAdapter myDataAdapter = new SqlDataAdapter(queryString, myConnection);
            SqlDataAdapter myDataAdapter1 = new SqlDataAdapter(queryString1, myConnection1);

            //myConnection.Close();

            DataTable dataTable = new DataTable("Table1");
            DataTable dataTable1 = new DataTable("Table2");

            myDataAdapter.Fill(dataTable);
            myDataAdapter1.Fill(dataTable1);

            dataGridView2.DataSource = dataTable1;
            dataGridView1.DataSource = dataTable;

            myConnection.Dispose();
            myConnection1.Dispose();
            myConnection.Close();
            myConnection1.Close();


        }
    }
}
