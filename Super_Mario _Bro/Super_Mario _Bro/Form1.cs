using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mario__Bro
{
    public partial class Form1 : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (goLeft)
            {
                player.Left -= 5;
            }
            if (goRight)
            {
                player.Left += 5;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force = -1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = control.Top - player.Height;
                    }
                }
            }
        }

        private void door_Click(object sender, EventArgs e)
        {

        }

        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}
