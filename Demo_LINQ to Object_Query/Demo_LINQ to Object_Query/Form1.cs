using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_LINQ_to_Object_Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Defining string array 
            string[] names = { "Subtle Art of Not Giving a Fuck", "Do Epic Shit", "Rich Dad Poor Dad","Atomic Habits","Every One You Hate is going to Die" };
            //LINQ QUERY
            IEnumerable<string> AllTimeBooks = from name in names
                                               where name.Length > 5
                                               select name;
            foreach (var name in AllTimeBooks)
            {
                richTextBox1.AppendText(name + "\n");
            }
        }
    }
}
