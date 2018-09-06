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
    public partial class QandA : Form
    {
        public QandA()
        {
            InitializeComponent();
        }
        static int ms = 0;
        static int sec = 20;
        
        
        /// <summary>
        /// In this subform, we have a hidden field (lbCorrect)
        /// used to communicate with the calling form.
        /// This label is set to public in the form attributes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void QandA_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bttnAnswer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblChoose.Visible = true;
            cbPlayer.Visible = true;
            bttnSubmit.Visible = true;
        }
        /// <summary>
        /// create timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = sec.ToString();
            ms++;
            if(ms > 15)
            {
                sec--;
                ms = 0;
            }
            else { ms++; }
            if(sec < 6 && sec % 2 != 0)
            {
                lblTimer.BackColor = Color.Red;
            }
            else { lblTimer.BackColor = Color.Transparent; }
            if(sec < 0)
            {
                timer1.Stop();
                MessageBox.Show("TIMES UP!", "Jeopardy", MessageBoxButtons.OK);
                Close();
            }
        }
        /// <summary>
        /// show message box with answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            if (txtQuest.Text.ToUpper() == lblQuest.Text)
            {
                lbCorrect.Text = "True";
                MessageBox.Show("CORRECT!");
                ms = 0;
                sec = 15;
                Close();
            }
            else
            {
                lbCorrect.Text = "False";
                MessageBox.Show("INCORRECT! The correct answer is: \r" + lblQuest.Text);
                ms = 0;
                sec = 15;
                Close();
            }
        }
    }
}
