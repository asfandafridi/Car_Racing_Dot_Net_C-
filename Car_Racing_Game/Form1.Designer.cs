namespace Car_Racing_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.overLabel = new System.Windows.Forms.Label();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(172, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(172, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(172, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(172, 362);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 100);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 485);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(376, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 485);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Car_Racing_Game.Properties.Resources.TruckBlue;
            this.enemy2.Location = new System.Drawing.Point(241, 40);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(35, 63);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::Car_Racing_Game.Properties.Resources.carOrange;
            this.enemy3.Location = new System.Drawing.Point(311, 334);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(31, 61);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 7;
            this.enemy3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::Car_Racing_Game.Properties.Resources.carGreen;
            this.enemy1.Location = new System.Drawing.Point(109, 67);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(35, 61);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 8;
            this.enemy1.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::Car_Racing_Game.Properties.Resources.carYellow;
            this.car1.Location = new System.Drawing.Point(36, 295);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(40, 72);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 9;
            this.car1.TabStop = false;
            this.car1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.car1_PreviewKeyDown);
            // 
            // overLabel
            // 
            this.overLabel.AutoSize = true;
            this.overLabel.BackColor = System.Drawing.Color.Yellow;
            this.overLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.overLabel.ForeColor = System.Drawing.Color.Red;
            this.overLabel.Location = new System.Drawing.Point(109, 193);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(141, 28);
            this.overLabel.TabIndex = 10;
            this.overLabel.Text = "Game Over";
            this.overLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Gray;
            this.coin2.Image = global::Car_Racing_Game.Properties.Resources.coin22;
            this.coin2.Location = new System.Drawing.Point(63, 222);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(13, 15);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 12;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Gray;
            this.coin3.Image = global::Car_Racing_Game.Properties.Resources.coin22;
            this.coin3.Location = new System.Drawing.Point(277, 134);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(15, 15);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Gray;
            this.coin4.Image = global::Car_Racing_Game.Properties.Resources.coin22;
            this.coin4.Location = new System.Drawing.Point(235, 362);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(15, 14);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 14;
            this.coin4.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Gray;
            this.coin1.Image = global::Car_Racing_Game.Properties.Resources.coin22;
            this.coin1.Location = new System.Drawing.Point(27, 40);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(13, 15);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 15;
            this.coin1.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(15, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 15);
            this.score.TabIndex = 16;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Yellow;
            this.score1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score1.ForeColor = System.Drawing.Color.Red;
            this.score1.Location = new System.Drawing.Point(-20, 9);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(0, 28);
            this.score1.TabIndex = 17;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(139, 382);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(111, 46);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Restart";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.overLabel);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox enemy1;
        private PictureBox car1;
        private Label overLabel;
        private PictureBox coin2;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox coin1;
        private Label score;
        private Label score1;
        private Button btn1;
    }
}