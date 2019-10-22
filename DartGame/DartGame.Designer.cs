namespace DartGame
{
    partial class DartGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DartGameForm));
            this.throwDart = new System.Windows.Forms.Button();
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
            this.setDart = new System.Windows.Forms.Button();
            this.setBoard = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // throwDart
            // 
            this.throwDart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.throwDart.FlatAppearance.BorderSize = 3;
            this.throwDart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwDart.Location = new System.Drawing.Point(295, 702);
            this.throwDart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.throwDart.Name = "throwDart";
            this.throwDart.Size = new System.Drawing.Size(347, 57);
            this.throwDart.TabIndex = 3;
            this.throwDart.Text = "Throw Dart";
            this.throwDart.UseVisualStyleBackColor = false;
            this.throwDart.Click += new System.EventHandler(this.ThrowDart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.message.Location = new System.Drawing.Point(29, 625);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(865, 52);
            this.message.TabIndex = 1;
            this.message.Text = "Welcome to Dart Game!!";
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
            this.panel3.Location = new System.Drawing.Point(624, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 236);
            this.panel3.TabIndex = 8;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lose.Location = new System.Drawing.Point(221, 43);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(20, 24);
            this.lose.TabIndex = 6;
            this.lose.Text = "0";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.win.Location = new System.Drawing.Point(176, 43);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(20, 24);
            this.win.TabIndex = 5;
            this.win.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score.Location = new System.Drawing.Point(192, 142);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(20, 24);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // totalScore
            // 
            this.totalScore.AutoSize = true;
            this.totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalScore.Location = new System.Drawing.Point(21, 142);
            this.totalScore.Name = "totalScore";
            this.totalScore.Size = new System.Drawing.Size(116, 24);
            this.totalScore.TabIndex = 1;
            this.totalScore.Text = "Total Score :";
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winLose.Location = new System.Drawing.Point(21, 43);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(132, 24);
            this.winLose.TabIndex = 0;
            this.winLose.Text = "Wins / Loses : ";
            // 
            // setDart
            // 
            this.setDart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.setDart.FlatAppearance.BorderSize = 3;
            this.setDart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDart.Location = new System.Drawing.Point(47, 133);
            this.setDart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setDart.Name = "setDart";
            this.setDart.Size = new System.Drawing.Size(180, 50);
            this.setDart.TabIndex = 4;
            this.setDart.Text = "Set Dart";
            this.setDart.UseVisualStyleBackColor = false;
            this.setDart.Click += new System.EventHandler(this.SetDart_Click);
            // 
            // setBoard
            // 
            this.setBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.setBoard.FlatAppearance.BorderSize = 3;
            this.setBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBoard.Location = new System.Drawing.Point(47, 38);
            this.setBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setBoard.Name = "setBoard";
            this.setBoard.Size = new System.Drawing.Size(180, 50);
            this.setBoard.TabIndex = 0;
            this.setBoard.Text = "Set Board";
            this.setBoard.UseVisualStyleBackColor = false;
            this.setBoard.Click += new System.EventHandler(this.SetBoard_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.playAgain.FlatAppearance.BorderSize = 3;
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(47, 234);
            this.playAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(180, 50);
            this.playAgain.TabIndex = 5;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playAgain);
            this.panel2.Controls.Add(this.setBoard);
            this.panel2.Controls.Add(this.setDart);
            this.panel2.Location = new System.Drawing.Point(624, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 313);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 582);
            this.panel1.TabIndex = 6;
            // 
            // DartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(939, 772);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.throwDart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DartGameForm";
            this.Text = "Dart Game";
            this.Load += new System.EventHandler(this.DartGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button throwDart;
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
        private System.Windows.Forms.Button setDart;
        private System.Windows.Forms.Button setBoard;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

