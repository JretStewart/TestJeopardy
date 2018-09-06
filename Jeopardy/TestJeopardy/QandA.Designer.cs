namespace TestJeopardy
{
    partial class QandA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAnsTag = new System.Windows.Forms.Label();
            this.lblQValue = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.bttnAnswer = new System.Windows.Forms.Button();
            this.lblQuest = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnsTag
            // 
            this.lblAnsTag.AutoSize = true;
            this.lblAnsTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsTag.ForeColor = System.Drawing.Color.Gold;
            this.lblAnsTag.Location = new System.Drawing.Point(206, 34);
            this.lblAnsTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnsTag.Name = "lblAnsTag";
            this.lblAnsTag.Size = new System.Drawing.Size(292, 29);
            this.lblAnsTag.TabIndex = 0;
            this.lblAnsTag.Text = "This Question is Worth: ";
            // 
            // lblQValue
            // 
            this.lblQValue.AutoSize = true;
            this.lblQValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQValue.ForeColor = System.Drawing.Color.Gold;
            this.lblQValue.Location = new System.Drawing.Point(297, 95);
            this.lblQValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQValue.Name = "lblQValue";
            this.lblQValue.Size = new System.Drawing.Size(76, 29);
            this.lblQValue.TabIndex = 1;
            this.lblQValue.Text = " $100";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.ForeColor = System.Drawing.Color.Gold;
            this.lbCorrect.Location = new System.Drawing.Point(18, 373);
            this.lbCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(41, 20);
            this.lbCorrect.TabIndex = 4;
            this.lbCorrect.Text = "True";
            this.lbCorrect.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Gold;
            this.lblAnswer.Location = new System.Drawing.Point(207, 174);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(21, 22);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "?";
            // 
            // txtQuest
            // 
            this.txtQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuest.ForeColor = System.Drawing.Color.Black;
            this.txtQuest.Location = new System.Drawing.Point(211, 291);
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.Size = new System.Drawing.Size(287, 32);
            this.txtQuest.TabIndex = 6;
            // 
            // bttnAnswer
            // 
            this.bttnAnswer.ForeColor = System.Drawing.Color.Black;
            this.bttnAnswer.Location = new System.Drawing.Point(284, 331);
            this.bttnAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnAnswer.Name = "bttnAnswer";
            this.bttnAnswer.Size = new System.Drawing.Size(147, 46);
            this.bttnAnswer.TabIndex = 7;
            this.bttnAnswer.Text = "Answer";
            this.bttnAnswer.UseVisualStyleBackColor = true;
            this.bttnAnswer.Click += new System.EventHandler(this.bttnAnswer_Click);
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.ForeColor = System.Drawing.Color.Gold;
            this.lblQuest.Location = new System.Drawing.Point(620, 373);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(13, 20);
            this.lblQuest.TabIndex = 8;
            this.lblQuest.Text = "!";
            this.lblQuest.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gold;
            this.lblTimer.Location = new System.Drawing.Point(59, 161);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(36, 37);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "0";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer.Location = new System.Drawing.Point(18, 344);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.Text = "#";
            this.lblPlayer.Visible = false;
            // 
            // cbPlayer
            // 
            this.cbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(418, 398);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(52, 30);
            this.cbPlayer.TabIndex = 37;
            this.cbPlayer.Visible = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(146, 398);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(256, 26);
            this.lblChoose.TabIndex = 36;
            this.lblChoose.Text = "Which Player Answered?";
            this.lblChoose.Visible = false;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.Location = new System.Drawing.Point(498, 394);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Size = new System.Drawing.Size(103, 39);
            this.bttnSubmit.TabIndex = 38;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = true;
            this.bttnSubmit.Visible = false;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click);
            // 
            // QandA
            // 
            this.AcceptButton = this.bttnAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(708, 451);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.bttnAnswer);
            this.Controls.Add(this.txtQuest);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lbCorrect);
            this.Controls.Add(this.lblQValue);
            this.Controls.Add(this.lblAnsTag);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QandA";
            this.Text = "QandA";
            this.Load += new System.EventHandler(this.QandA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnsTag;
        public System.Windows.Forms.Label lblQValue;
        public System.Windows.Forms.Label lbCorrect;
        public System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.Button bttnAnswer;
        public System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTimer;
        public System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblChoose;
        public System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Button bttnSubmit;
    }
}