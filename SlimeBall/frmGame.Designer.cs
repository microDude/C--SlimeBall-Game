﻿namespace SlimeBall
{
    partial class frmGame
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
            this.tmrGameLoop = new System.Windows.Forms.Timer(this.components);
            this.tmrDecoupled = new System.Windows.Forms.Timer(this.components);
            this.lblScoreSlimer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScoreSlimer2 = new System.Windows.Forms.Label();
            this.lblBallSpeedY = new System.Windows.Forms.Label();
            this.lblBallSpeedX = new System.Windows.Forms.Label();
            this.lblPointScored = new System.Windows.Forms.Label();
            this.tmrPointScored = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrGameLoop
            // 
            this.tmrGameLoop.Enabled = true;
            this.tmrGameLoop.Interval = 5;
            this.tmrGameLoop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrDecoupled
            // 
            this.tmrDecoupled.Enabled = true;
            this.tmrDecoupled.Interval = 1;
            this.tmrDecoupled.Tick += new System.EventHandler(this.tmrDecoupled_Tick);
            // 
            // lblScoreSlimer1
            // 
            this.lblScoreSlimer1.AutoSize = true;
            this.lblScoreSlimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSlimer1.ForeColor = System.Drawing.Color.Blue;
            this.lblScoreSlimer1.Location = new System.Drawing.Point(399, 53);
            this.lblScoreSlimer1.Name = "lblScoreSlimer1";
            this.lblScoreSlimer1.Size = new System.Drawing.Size(19, 20);
            this.lblScoreSlimer1.TabIndex = 1;
            this.lblScoreSlimer1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(418, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // lblScoreSlimer2
            // 
            this.lblScoreSlimer2.AutoSize = true;
            this.lblScoreSlimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSlimer2.ForeColor = System.Drawing.Color.Blue;
            this.lblScoreSlimer2.Location = new System.Drawing.Point(440, 53);
            this.lblScoreSlimer2.Name = "lblScoreSlimer2";
            this.lblScoreSlimer2.Size = new System.Drawing.Size(19, 20);
            this.lblScoreSlimer2.TabIndex = 3;
            this.lblScoreSlimer2.Text = "0";
            // 
            // lblBallSpeedY
            // 
            this.lblBallSpeedY.AutoSize = true;
            this.lblBallSpeedY.ForeColor = System.Drawing.Color.Yellow;
            this.lblBallSpeedY.Location = new System.Drawing.Point(828, 40);
            this.lblBallSpeedY.Name = "lblBallSpeedY";
            this.lblBallSpeedY.Size = new System.Drawing.Size(13, 13);
            this.lblBallSpeedY.TabIndex = 9;
            this.lblBallSpeedY.Text = "0";
            // 
            // lblBallSpeedX
            // 
            this.lblBallSpeedX.AutoSize = true;
            this.lblBallSpeedX.ForeColor = System.Drawing.Color.Yellow;
            this.lblBallSpeedX.Location = new System.Drawing.Point(828, 62);
            this.lblBallSpeedX.Name = "lblBallSpeedX";
            this.lblBallSpeedX.Size = new System.Drawing.Size(13, 13);
            this.lblBallSpeedX.TabIndex = 8;
            this.lblBallSpeedX.Text = "0";
            // 
            // lblPointScored
            // 
            this.lblPointScored.BackColor = System.Drawing.Color.Transparent;
            this.lblPointScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointScored.ForeColor = System.Drawing.Color.Crimson;
            this.lblPointScored.Location = new System.Drawing.Point(223, 76);
            this.lblPointScored.Name = "lblPointScored";
            this.lblPointScored.Size = new System.Drawing.Size(497, 62);
            this.lblPointScored.TabIndex = 10;
            this.lblPointScored.Text = "POINT SCORED MESSAGE";
            this.lblPointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPointScored.Visible = false;
            // 
            // tmrPointScored
            // 
            this.tmrPointScored.Interval = 2000;
            this.tmrPointScored.Tick += new System.EventHandler(this.tmrPointScored_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(435, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "P2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(399, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Press SPACE to Pause";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "New Game : Click anywhere on the form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(714, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ball Vertical Speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(714, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ball Horizontal Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(713, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "INFORMATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(20, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Player1 : W, A, D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(18, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "CONTROLS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(20, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Player2 : Up, Left, Right";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Aqua;
            this.label13.Location = new System.Drawing.Point(394, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "SCORE";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPointScored);
            this.Controls.Add(this.lblBallSpeedY);
            this.Controls.Add(this.lblBallSpeedX);
            this.Controls.Add(this.lblScoreSlimer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScoreSlimer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "SlimeBall";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGame_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGame_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrGameLoop;
        private System.Windows.Forms.Timer tmrDecoupled;
        private System.Windows.Forms.Label lblScoreSlimer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScoreSlimer2;
        private System.Windows.Forms.Label lblBallSpeedY;
        private System.Windows.Forms.Label lblBallSpeedX;
        private System.Windows.Forms.Label lblPointScored;
        private System.Windows.Forms.Timer tmrPointScored;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

