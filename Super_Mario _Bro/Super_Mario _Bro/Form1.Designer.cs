namespace Super_Mario__Bro
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Brown;
            this.ground.Location = new System.Drawing.Point(0, 713);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(645, 41);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(63, 644);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(40, 62);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // background
            // 
            this.background.Image = global::Super_Mario__Bro.Properties.Resources.background1;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(2000, 480);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(0, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 43);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // door
            // 
            this.door.Image = global::Super_Mario__Bro.Properties.Resources.door_closed;
            this.door.Location = new System.Drawing.Point(0, 13);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(60, 90);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.door.TabIndex = 4;
            this.door.TabStop = false;
            this.door.Tag = "door";
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // player1
            // 
            this.player1.Image = global::Super_Mario__Bro.Properties.Resources.player;
            this.player1.Location = new System.Drawing.Point(86, 366);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(50, 60);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 6;
            this.player1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(305, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox3.Location = new System.Drawing.Point(497, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox4.Location = new System.Drawing.Point(427, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 43);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox5.Location = new System.Drawing.Point(263, 190);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(129, 43);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox6.Location = new System.Drawing.Point(0, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(179, 43);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox7.Location = new System.Drawing.Point(521, 102);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(129, 43);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox8.Location = new System.Drawing.Point(797, 190);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(129, 43);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox9.Location = new System.Drawing.Point(1055, 327);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(129, 43);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox10.Location = new System.Drawing.Point(1153, 169);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(129, 43);
            this.pictureBox10.TabIndex = 15;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox11.Location = new System.Drawing.Point(1490, 169);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(129, 43);
            this.pictureBox11.TabIndex = 16;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "platform";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox12.Location = new System.Drawing.Point(1239, 418);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(385, 43);
            this.pictureBox12.TabIndex = 17;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::Super_Mario__Bro.Properties.Resources.platform;
            this.pictureBox13.Location = new System.Drawing.Point(1694, 60);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(129, 43);
            this.pictureBox13.TabIndex = 18;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // key
            // 
            this.key.Image = global::Super_Mario__Bro.Properties.Resources.key;
            this.key.Location = new System.Drawing.Point(1722, 12);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(90, 47);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.key.TabIndex = 19;
            this.key.TabStop = false;
            this.key.Tag = "key";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox14.Location = new System.Drawing.Point(849, 154);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(35, 30);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 20;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox15.Location = new System.Drawing.Point(571, 66);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(35, 30);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 21;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox17.Location = new System.Drawing.Point(1204, 133);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(35, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 23;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox18.Location = new System.Drawing.Point(1527, 133);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(35, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 24;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox19.Location = new System.Drawing.Point(1273, 382);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(35, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 25;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox20.Location = new System.Drawing.Point(1366, 382);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(35, 30);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 26;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "coin";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox21.Location = new System.Drawing.Point(1459, 382);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(35, 30);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 27;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Super_Mario__Bro.Properties.Resources.coin;
            this.pictureBox22.Location = new System.Drawing.Point(1549, 382);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(35, 30);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 28;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 473);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Super Mario Bro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
    }
}

