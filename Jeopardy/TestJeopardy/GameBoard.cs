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
    public partial class GameBoard : Form
    {
        
       //create object arrays 
        QandA[] newQA = new QandA[25];
        Player[] player = new Player[3];
        Splash loadSplash = new Splash();
        string strName { get; set; }
        int choice;

        public GameBoard()
        {
            loadSplash.ShowDialog();
            InitializeComponent();
            HideButtons();
            //fill arrays
            for(int i = 0; i < 25; i++)
            {
                newQA[i] = new QandA();
            }
            for(int j = 0; j < player.Length; j++)
            {
                player[j] = new Player("Player");
            }
        }
        //set timer variables
        int ms = 0;
        int min = 20;
        int sec = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int q1 = 0;
            NewQuestion(q1);
        }

        private void GaneBoard_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// set number of players in the game
        /// </summary>
        public void GetPlayers()
        {
            
            if (cbPlayers.Text == "1")
            {
                HideCB();
                bttnPlay.Visible = false;
                lblPlayer1.Visible = true;
                txtScore1.Visible = true;
                groupBox1.Text = "";
                ShowButtons();
            }
            else if (cbPlayers.Text == "2")
            {
                HideCB();
                bttnPlay.Visible = false;
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                txtScore1.Visible = true;
                txtScore2.Visible = true;
                groupBox1.Text = "";
                ShowButtons();
            }
            else if (cbPlayers.Text == "3")
            {
                HideCB();
                bttnPlay.Visible = false;
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblPlayer3.Visible = true;
                txtScore1.Visible = true;
                txtScore2.Visible = true;
                txtScore3.Visible = true;
                groupBox1.Text = "";
                ShowButtons();
            }
        }
        /// <summary>
        /// hide combobox portion of menu
        /// </summary>
        public void HideCB()
        {
            cbPlayers.Visible = false;
            lblChoose.Visible = false;
        }
        /// <summary>
        /// show combobox menu options
        /// </summary>
        public void ShowCb()
        {
            cbPlayers.Visible = true;
            lblChoose.Visible = true;
            bttnPlay.Visible = true;
        }
        /// <summary>
        /// hide players section
        /// </summary>
        public void HidePlayers()
        {
            lblPlayer1.Visible = false;
            lblPlayer2.Visible = false;
            lblPlayer3.Visible = false;
            txtScore1.Visible = false;
            txtScore2.Visible = false;
            txtScore3.Visible = false;
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
        }
        /// <summary>
        /// set game and explain how to enter name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnPlay_Click(object sender, EventArgs e)
        {
            GetPlayers();
            timer1.Start();
            choice = Convert.ToInt16(cbPlayers.Text);
            MessageBox.Show("Click Your Player To Enter Name", "Message", MessageBoxButtons.OK);
        }
        /// <summary>
        /// hide all question buttons
        /// </summary>
        public void HideButtons()
        {
            Label[] allCat = { lblCat1, lblCat2, lblCat3, lblCat4, lblCat5 };
            Button[] cat1 = { bttnCat1100, bttnCat1200, bttnCat1300, bttnCat1400, bttnCat1500 };
            Button[] cat2 = { bttnCat2100, bttnCat2200, bttnCat2300, bttnCat2400, bttnCat2500 };
            Button[] cat3 = { bttnCat3100, bttnCat3200, bttnCat3300, bttnCat3400, bttnCat3500 };
            Button[] cat4 = { bttnCat4100, bttnCat4200, bttnCat4300, bttnCat4400, bttnCat4500 };
            Button[] cat5 = { bttnCat5100, bttnCat5200, bttnCat5300, bttnCat5400, bttnCat5500 };
            for (int i = 0; i < cat1.Length; i++)
            {
                allCat[i].Visible = false;
                cat1[i].Visible = false;
                cat2[i].Visible = false;
                cat3[i].Visible = false;
                cat4[i].Visible = false;
                cat5[i].Visible = false;
            }
        }
        /// <summary>
        /// show all question buttons
        /// </summary>
        public void ShowButtons()
        {
            Label[] allCat = { lblCat1, lblCat2, lblCat3, lblCat4, lblCat5 };
            Button[] cat1 = { bttnCat1100, bttnCat1200, bttnCat1300, bttnCat1400, bttnCat1500 };
            Button[] cat2 = { bttnCat2100, bttnCat2200, bttnCat2300, bttnCat2400, bttnCat2500 };
            Button[] cat3 = { bttnCat3100, bttnCat3200, bttnCat3300, bttnCat3400, bttnCat3500 };
            Button[] cat4 = { bttnCat4100, bttnCat4200, bttnCat4300, bttnCat4400, bttnCat4500 };
            Button[] cat5 = { bttnCat5100, bttnCat5200, bttnCat5300, bttnCat5400, bttnCat5500 };
            for(int i = 0; i < cat1.Length; i++)
            {
                allCat[i].Visible = true;
                cat1[i].Visible = true;
                cat2[i].Visible = true;
                cat3[i].Visible = true;
                cat4[i].Visible = true;
                cat5[i].Visible = true;
            }
        }
        /// <summary>
        /// set object arrays to access all questions from one method
        /// </summary>
        /// <param name="bttnIndex"></param>
        public void NewQuestion(int bttnIndex)
        {
            //make each button have a value and pass value to method
            //then use form array and button array with string array to form 
            //new question forms 
            
            this.Hide();
            Button[] bttnArray = { bttnCat1100, bttnCat1200, bttnCat1300, bttnCat1400, bttnCat1500 ,bttnCat2100, bttnCat2200, bttnCat2300, bttnCat2400, bttnCat2500, 
              bttnCat3100, bttnCat3200, bttnCat3300,bttnCat3400,bttnCat3500 ,bttnCat4100, bttnCat4200, bttnCat4300, bttnCat4400, bttnCat4500 ,bttnCat5100, bttnCat5200, bttnCat5300, bttnCat5400, bttnCat5500 };
            TextBox[] texts = { txtScore1, txtScore2, txtScore3 };
            int[] value = { 100, 200, 300, 400, 500, 100, 200, 300, 400, 500, 100, 200, 300, 400, 500, 100, 200, 300, 400, 500, 100, 200, 300, 400, 500 };
            string[] question = { "who is Alan Turing", "who is Grace Hopper", "who is Tim Berners Lee", "who is Lawrence Lessig", "who is Ada Lovelace", "what is Concrete", "what is Base", "what is a Derived class", "what is Garbage collector", "What is has a", "what is var", "what is a List", "what is SQL", "what is Count", "what is Capacity", "what is a Metacharacter", "what is a Question mark", "what is a Pipe", "what is \\w", "what is System.Text.RegularExpressions", "what is Big O Notation", "what is Leaf", "what is list", "What is node", "what is Self referential" };
            string[] answer = { "Known as the questioner of the human\r mind, this man is known for helping tell\r humans and computers apart.", "This female pioneer of the COBOL computer programming\r language was an Admiral in the US Navy.", "Called the father of the world wide web,\r this man is the director of the W3C.", "An American academic and political activist who\r founded the Creative Commons, this man lobbies for reduced legal\r restrictions on copyrights and trademarks in the technology sector.", "This woman, known as the world's first computer programmer\r was also a Countess.", "A class from which objects can\r be instatitated", "Derived class constructors can call base\r class constructors with a call to the same name.", "This class type can effect state changes in\r base class private members only through public,\r protected or internal methods.", "An invisible process that reclaims an\r object's memory.", "A relationship between two objects in which one\r object is a part of another.", "The keyword for a generic data return type\r or object.", "This data type is better and more efficient\r than an array and often used in LINQ.", "This is the international standard for\r querying relational databases.", "This property will return the number of items\r in a LINQ query result.", "This property will return the number of elements\r available in a List.", "These characters have special meaning in a regular\r expression and often represent concepts\r for matching.", "This metacharacter can describe how many times a part\r of the pattern may occur in a match.", "This metacharacter is known as the alternation\r and can match expressions on the left\r or the right.", "This character class can represent any\r alphanumeric character or underscore.", "This namespace must be imported in an application\r before regular expression classes can be used.", "his concept of data structures measures the efficiency of an algorithm.", "In a Tree, this is a node with\r no children.", "Stacks must inherit from this class.", "This element of a Linked List can contain properties\r of any type.", "This technique is used when a class calls\r it's own constructor." };
            
            newQA[bttnIndex].lblQValue.Text = value[bttnIndex].ToString();
            newQA[bttnIndex].lblAnswer.Text = answer[bttnIndex];
            newQA[bttnIndex].lblQuest.Text = question[bttnIndex].ToUpper();

            for (int i = 1, j = 0; i <= choice; i++, j++)
            {
                newQA[bttnIndex].cbPlayer.Items.Insert(j, i);
            }
            newQA[bttnIndex].ShowDialog();
            try
            {
                int newQAChoice = Convert.ToInt16(newQA[bttnIndex].cbPlayer.Text);
                if (newQA[bttnIndex].lbCorrect.Text == "True")
                    player[newQAChoice - 1].updateScore(value[bttnIndex]);
                else
                    player[newQAChoice - 1].updateScore(-value[bttnIndex]);

                texts[newQAChoice - 1].Text = player[newQAChoice - 1].Score.ToString();
            }
            catch (Exception)
            { 
                
            }

            this.Show();

            bttnArray[bttnIndex].Visible = false;

        }
        /// <summary>
        /// reset game back to beginning settings
        /// </summary>
        public void ResetGame()
        {
            HideButtons();
            HidePlayers();
            ShowCb();
            min = 20;
            sec = 0;
        }

        /// <summary>
        /// button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 
        private void bttnCat1200_Click(object sender, EventArgs e)
        {
            int q2 = 1;
            NewQuestion(q2);
        }

        private void bttnCat1300_Click(object sender, EventArgs e)
        {
            int q3 = 2;
            NewQuestion(q3);
        }

        private void bttnCat1400_Click(object sender, EventArgs e)
        {
            int q4 = 3;
            NewQuestion(q4);
        }

        private void bttnCat1500_Click(object sender, EventArgs e)
        {
            int q5 = 4;
            NewQuestion(q5);
        }

        private void bttnCat2100_Click(object sender, EventArgs e)
        {
            int q6 = 5;
            NewQuestion(q6);
        }

        private void bttnCat2200_Click(object sender, EventArgs e)
        {
            int q7 = 6;
            NewQuestion(q7);
        }

        private void bttnCat2300_Click(object sender, EventArgs e)
        {
            int q8 = 7;
            NewQuestion(q8);
        }

        private void bttnCat2400_Click(object sender, EventArgs e)
        {
            int q9 = 8;
            NewQuestion(q9);
        }

        private void bttnCat2500_Click(object sender, EventArgs e)
        {
            int q10 = 9;
            NewQuestion(q10);
        }

        private void bttnCat3100_Click(object sender, EventArgs e)
        {
            int q11 = 10;
            NewQuestion(q11);
        }

        private void bttnCat3200_Click(object sender, EventArgs e)
        {
            int q12 = 11;
            NewQuestion(q12);
        }

        private void bttnCat3300_Click(object sender, EventArgs e)
        {
            int q13 = 12;
            NewQuestion(q13);
        }

        private void bttnCat3400_Click(object sender, EventArgs e)
        {
            int q14 = 13;
            NewQuestion(q14);
        }

        private void bttnCat3500_Click(object sender, EventArgs e)
        {
            int q15 = 14;
            NewQuestion(q15);
        }

        private void bttnCat4100_Click(object sender, EventArgs e)
        {
            int q16 = 15;
            NewQuestion(q16);
        }

        private void bttnCat4200_Click(object sender, EventArgs e)
        {
            int q17 = 16;
            NewQuestion(q17);
        }

        private void bttnCat4300_Click(object sender, EventArgs e)
        {
            int q18 = 17;
            NewQuestion(q18);
        }

        private void bttnCat4400_Click(object sender, EventArgs e)
        {
            int q19 = 18;
            NewQuestion(q19);
        }

        private void bttnCat4500_Click(object sender, EventArgs e)
        {
            int q20 = 19;
            NewQuestion(q20);
        }

        private void bttnCat5100_Click(object sender, EventArgs e)
        {
            int q21 = 20;
            NewQuestion(q21);
        }

        private void bttnCat5200_Click(object sender, EventArgs e)
        {
            int q22 = 21;
            NewQuestion(q22);
        }

        private void bttnCat5300_Click(object sender, EventArgs e)
        {
            int q23 = 22;
            NewQuestion(q23);
        }

        private void bttnCat5400_Click(object sender, EventArgs e)
        {
            int q24 = 23;
            NewQuestion(q24);
        }

        private void bttnCat5500_Click(object sender, EventArgs e)
        {
            int q25 = 24;
            NewQuestion(q25);

        }
        #endregion
        /// <summary>
        /// set name for player 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayer1_Click(object sender, EventArgs e)
        {
            string strNewName = ShowDialog("Enter Name: ", "Name Change");
            if (strNewName != strName && strNewName != "")
            {
                strName = strNewName;
                lblPlayer1.Text = strName;
            }
            else if (strNewName == "" && strName != null)
            {
                lblPlayer1.Text = strName;
            }
            else
            {
                lblPlayer1.Text = "Player";
            }
        }
        /// <summary>
        /// create message box for name enter
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        /// <summary>
        /// set name for player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayer2_Click(object sender, EventArgs e)
        {
            string strNewName = ShowDialog("Enter Name: ", "Name Change");
            if (strNewName != strName && strNewName != "")
            {
                strName = strNewName;
                lblPlayer2.Text = strName;
            }
            else if (strNewName == "" && strName != null)
            {
                lblPlayer2.Text = strName;
            }
            else
            {
                lblPlayer2.Text = "Player";
            }
        }
        /// <summary>
        /// set name for player 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlayer3_Click(object sender, EventArgs e)
        {
            string strNewName = ShowDialog("Enter Name: ", "Name Change");
            if (strNewName != strName && strNewName != "")
            {
                strName = strNewName;
                lblPlayer3.Text = strName;
            }
            else if (strNewName == "" && strName != null)
            {
                lblPlayer3.Text = strName;
            }
            else
            {
                lblPlayer3.Text = "Player";
            }
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        /// <summary>
        /// create timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text =  min + "m:" + sec.ToString() + "s";
            ms++;

            if (ms > 15)
            {
                sec--;
                ms = 0;
            }
            else
            {
                ms++;
            }
            if (sec < 0)
            {
                min--;
                sec = 59;
            }

            if (min == 0 && sec == 0 && ms == 0)
            {
                timer1.Stop();
                MessageBox.Show("TIMES UP! Click OK to Start a New Game", "Game Over", MessageBoxButtons.OK);
                ResetGame();
            }

        }
    }
}
