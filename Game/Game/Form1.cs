using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        bool right;
        bool left;
        bool jump;
        int G = 20;
        int Force;
        bool check0 = true;
        bool check1 = false;
        bool check2 = true;
        bool check3 = false;
        bool check4 = true;

        public Game()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (right == true) //moving right
            {
                player.Left += 5;
            }

            if (left == true) //moving left
            {
                player.Left -= 5;
            }

            if (jump == true) //falling (if player jumped)
            {
                player.Top -= Force;
                Force -= 1;
            }

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; // does not fall tru bottom!
                jump = false;
            }

            else
            {
                player.Top += 5; // just falling/gravity
            }

            // side (window) collision
            if (player.Right > screen.Right) //right wall
            {
                player.Left = screen.Width - player.Width;
                right = false;
            }

            if (player.Left < screen.Left) //left wall
            {
                player.Left = screen.Left;
                left = false;
            }
            //

            // here we give collision to every block
            physics(block0);
            physics(block1);
            physics(block2);
            physics(block3);
            physics(block4);

            //block0 movement and wall collision
            if (block0.Right > screen.Right) { block0.Left = screen.Width - block0.Width; check0 = false; }
            if (block0.Left < screen.Left) { block0.Left = screen.Left; check0 = true; }
            if (check0 == true) { block0.Left += 3; if (player.Bottom == block0.Top) { player.Left += 3; } }
            else { block0.Left -= 3; if (player.Bottom == block0.Top) { player.Left -= 3; } }
            //block1 movement and wall collision
            if (block1.Right > screen.Right) { block1.Left = screen.Width - block1.Width; check1 = false; }
            if (block1.Left < screen.Left) { block1.Left = screen.Left; check1 = true; }
            if (check1 == true) { block1.Left += 5; if (player.Bottom == block1.Top) { player.Left += 5; } }
            else { block1.Left -= 5; if (player.Bottom == block1.Top) { player.Left -= 5; } }
            //block2 movement and wall collision
            if (block2.Right > screen.Right) { block2.Left = screen.Width - block2.Width; check2 = false; }
            if (block2.Left < screen.Left) { block2.Left = screen.Left; check2 = true; }
            if (check2 == true) { block2.Left += 6; if (player.Bottom == block2.Top) { player.Left += 6; } }
            else { block2.Left -= 6; if (player.Bottom == block2.Top) { player.Left -= 6; } }
            //block3 movement and wall collision
            if (block3.Right > screen.Right) { block3.Left = screen.Width - block3.Width; check3 = false; }
            if (block3.Left < screen.Left) { block3.Left = screen.Left; check3 = true; }
            if (check3 == true) { block3.Left += 8; if (player.Bottom == block3.Top) { player.Left += 8; } }
            else { block3.Left -= 8; if (player.Bottom == block3.Top) { player.Left -= 8; } }
            //block4 movement and wall collision
            if (block4.Right > screen.Right) { block4.Left = screen.Width - block4.Width; check4 = false; }
            if (block4.Left < screen.Left) { block4.Left = screen.Left; check4 = true; }
            if (check4 == true) { block4.Left += 9; if (player.Bottom == block4.Top) { player.Left += 9; } }
            else { block4.Left -= 9; if (player.Bottom == block4.Top) { player.Left -= 9; } }
        }


     
   
        public void physics (System.Windows.Forms.PictureBox block)
        {
            //side collision
            //if (player.Right > block.Left && player.Left < block.Right - player.Width && player.Bottom < block.Bottom && player.Bottom > block.Top)
            //{
            //    right = false;
            //}

            //if (player.Left < block.Right && player.Right > block.Left + player.Width && player.Bottom < block.Bottom && player.Bottom > block.Top)
            //{
            //    left = false;
            //}


            // top collision 
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                jump = false;
                Force = 0;
                player.Top = block.Location.Y - player.Height;
            }

            // simple fall
            if (!(player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width) && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                jump = true;
            }


            //bottom collision

            if (player.Left + player.Width - 1 > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top - block.Bottom <= 10 && player.Top - block.Top > -10)
            {
                Force = -1;
            }

        }

      

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Left)
            {

                left = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {

                left = false;
            }

        }
    }
}
