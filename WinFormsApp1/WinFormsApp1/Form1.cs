using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //WebBrowser webBrowser = new WebBrowser();
            //webBrowser.Navigate("http://www.goggle.com/ridhi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate("http://www.goggle.com/ridhi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
