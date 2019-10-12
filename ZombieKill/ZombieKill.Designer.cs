namespace ZombieKill
{
    partial class ZombieKillForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                soundPlayer.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZombieKillForm));
            this.throwKnife = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lose = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalScore = new System.Windows.Forms.Label();
            this.winLose = new System.Windows.Forms.Label();
            this.tryLuck = new System.Windows.Forms.Button();
            this.setknife = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // throwKnife
            // 
            this.throwKnife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.throwKnife.FlatAppearance.BorderSize = 3;
            this.throwKnife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwKnife.Location = new System.Drawing.Point(221, 570);
            this.throwKnife.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.throwKnife.Name = "throwKnife";
            this.throwKnife.Size = new System.Drawing.Size(260, 46);
            this.throwKnife.TabIndex = 3;
            this.throwKnife.Text = "Throw Knife";
            this.throwKnife.UseVisualStyleBackColor = false;
            this.throwKnife.Click += new System.EventHandler(this.ThrowKnife_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message.Location = new System.Drawing.Point(22, 508);
            this.message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(649, 42);
            this.message.TabIndex = 1;
            this.message.Text = "Welcome to Kill Zombie Game!!";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lose);
            this.panel3.Controls.Add(this.win);
            this.panel3.Controls.Add(this.score);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.totalScore);
            this.panel3.Controls.Add(this.winLose);
            this.panel3.Location = new System.Drawing.Point(468, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 192);
            this.panel3.TabIndex = 8;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lose.Location = new System.Drawing.Point(166, 35);
            this.lose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(16, 18);
            this.lose.TabIndex = 6;
            this.lose.Text = "0";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.win.Location = new System.Drawing.Point(132, 35);
            this.win.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(16, 18);
            this.win.TabIndex = 5;
            this.win.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(144, 115);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(16, 18);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalScore.Location = new System.Drawing.Point(16, 115);
            this.totalScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(93, 18);
            this.totalScore.TabIndex = 1;
            this.totalScore.Text = "Total Score :";
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winLose.Location = new System.Drawing.Point(16, 35);
            this.winLose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(107, 18);
            this.winLose.TabIndex = 0;
            this.winLose.Text = "Wins / Loses : ";
            // 
            // tryLuck
            // 
            this.tryLuck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tryLuck.FlatAppearance.BorderSize = 3;
            this.tryLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLuck.Location = new System.Drawing.Point(35, 108);
            this.tryLuck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tryLuck.Name = "tryLuck";
            this.tryLuck.Size = new System.Drawing.Size(135, 41);
            this.tryLuck.TabIndex = 4;
            this.tryLuck.Text = "Try Luck";
            this.tryLuck.UseVisualStyleBackColor = false;
            this.tryLuck.Click += new System.EventHandler(this.TryLuck_Click);
            // 
            // setknife
            // 
            this.setknife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.setknife.FlatAppearance.BorderSize = 3;
            this.setknife.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setknife.Location = new System.Drawing.Point(35, 31);
            this.setknife.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setknife.Name = "setknife";
            this.setknife.Size = new System.Drawing.Size(135, 41);
            this.setknife.TabIndex = 0;
            this.setknife.Text = "Set Knife";
            this.setknife.UseVisualStyleBackColor = false;
            this.setknife.Click += new System.EventHandler(this.SetKnife_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.playAgain.FlatAppearance.BorderSize = 3;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(35, 190);
            this.playAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(135, 41);
            this.playAgain.TabIndex = 5;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playAgain);
            this.panel2.Controls.Add(this.setknife);
            this.panel2.Controls.Add(this.tryLuck);
            this.panel2.Location = new System.Drawing.Point(468, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 254);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 473);
            this.panel1.TabIndex = 6;
            // 
            // ZombieKillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(704, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.throwKnife);
            this.Name = "ZombieKillForm";
            this.Text = "Kill Zombie";
            this.Load += new System.EventHandler(this.ZombieKillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button throwKnife;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalScore;
        private System.Windows.Forms.Label winLose;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button tryLuck;
        private System.Windows.Forms.Button setknife;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

