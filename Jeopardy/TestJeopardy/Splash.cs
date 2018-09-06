using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestJeopardy
{
    public partial class Splash : Form
    {
        int hour, min, sec, ms = 0;
        int loc2 = 0;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        Random rand = new Random(20);
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
            txtHelp.Text = "Rules:\r\n-Choose a Category and Question Value\r\n-Answer in the form of a Question\r\n-Once All Questions are Answered, Game is Over\r\n-If the Timer Runs Out, Game is Over";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int loc = rand.Next(-10, 100);
            //set timer
            //lblTimer.Text = hour + "h:" + min + "m:" + sec.ToString() + "s";
            ms++;
            loc2++;
            pictureBox1.Location = new Point(loc2*3, 50);
            if (ms > 15)
            {
                sec++;
                //pictureBox1.Location = new Point(loc2++, 50);
                ms = 0;
                if (sec == 8)
                {
                    this.Close();
                }
            }
            else
            {
                ms++;
            }
            if (sec > 59)
            {
                min++;
                sec = 0;
            }
            if (min > 59)
            {
                hour++;
                min = 0;
            }
            
        }
    }
}
