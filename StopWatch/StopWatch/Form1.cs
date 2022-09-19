using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace StopWatch
{
    
    public partial class Form1 : Form
    {
        int ms, s, m;
        bool isActive;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            ResetTime();
            isActive = false;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

           
            isActive = true;
            this.timer2.Start();
            
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("The StopWatch has Started");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
            this.timer2.Stop();
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("The StopWatch has Stopped");


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (isActive == true)
            {
              
                ms++;
                if (ms >= 100)
                {
                    s++;
                    ms = 0;
                    if (s >= 60)
                    {
                        m++;
                        s = 0;
                        progressBar1.Value = 0;

                    }
                }
 
            }
           
            Time();
        }

        private void Time()
        {
            txtResult.Text = string.Format("{0}:{1}:{2}",m.ToString().PadLeft(2,'0'),s.ToString().PadLeft(2,'0'),ms.ToString().PadLeft(2,'0'));

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                
                this.progressBar1.Increment(1);
                
                
            }
           


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
            this.progressBar1.Value = 0;
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("The StopWatch has Reseted ,         Click Start to start the Stopwatch Again");

        }

        public void Reset2()
        {
            progressBar1.Value = 0;
        }


        private void ResetTime()
        {
            ms = 0;
            s = 0;
            m = 0;

        }

       
    }
}
