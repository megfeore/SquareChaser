
namespace SquareChaser
{
    partial class Form1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreHeadingLabel = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.boxLabel2 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.purpleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.player1ScoreLabel.Location = new System.Drawing.Point(513, 72);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(37, 24);
            this.player1ScoreLabel.TabIndex = 0;
            this.player1ScoreLabel.Text = "0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.player2ScoreLabel.Location = new System.Drawing.Point(514, 115);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(22, 28);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.Text = "0";
            // 
            // winnerLabel
            // 
            this.winnerLabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.Black;
            this.winnerLabel.Location = new System.Drawing.Point(389, 185);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(183, 69);
            this.winnerLabel.TabIndex = 3;
            this.winnerLabel.Text = "winnerLabel";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winnerLabel.Visible = false;
            // 
            // player2Label
            // 
            this.player2Label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.Color.Black;
            this.player2Label.Location = new System.Drawing.Point(418, 116);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(98, 32);
            this.player2Label.TabIndex = 4;
            this.player2Label.Text = "Player 2:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1:";
            // 
            // scoreHeadingLabel
            // 
            this.scoreHeadingLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreHeadingLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreHeadingLabel.Location = new System.Drawing.Point(390, 29);
            this.scoreHeadingLabel.Name = "scoreHeadingLabel";
            this.scoreHeadingLabel.Size = new System.Drawing.Size(182, 32);
            this.scoreHeadingLabel.TabIndex = 6;
            this.scoreHeadingLabel.Text = "Player Scores";
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.Purple;
            this.boxLabel.Location = new System.Drawing.Point(392, 74);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(21, 20);
            this.boxLabel.TabIndex = 7;
            // 
            // boxLabel2
            // 
            this.boxLabel2.BackColor = System.Drawing.Color.Orange;
            this.boxLabel2.Location = new System.Drawing.Point(391, 118);
            this.boxLabel2.Name = "boxLabel2";
            this.boxLabel2.Size = new System.Drawing.Size(21, 20);
            this.boxLabel2.TabIndex = 8;
            // 
            // startLabel
            // 
            this.startLabel.BackColor = System.Drawing.Color.Black;
            this.startLabel.Location = new System.Drawing.Point(-6, -6);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(595, 330);
            this.startLabel.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(238, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 41);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(81, 41);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(416, 160);
            this.textLabel.TabIndex = 11;
            this.textLabel.Text = " ";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.Orange;
            this.orangeLabel.Location = new System.Drawing.Point(70, 29);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(437, 183);
            this.orangeLabel.TabIndex = 12;
            // 
            // purpleLabel
            // 
            this.purpleLabel.BackColor = System.Drawing.Color.Purple;
            this.purpleLabel.Location = new System.Drawing.Point(56, 18);
            this.purpleLabel.Name = "purpleLabel";
            this.purpleLabel.Size = new System.Drawing.Size(465, 205);
            this.purpleLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.purpleLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.boxLabel2);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.scoreHeadingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreHeadingLabel;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Label boxLabel2;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.Label purpleLabel;
    }
}

