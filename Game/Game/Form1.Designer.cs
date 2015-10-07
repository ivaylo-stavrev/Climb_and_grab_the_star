namespace Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.screen = new System.Windows.Forms.Panel();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block0 = new System.Windows.Forms.PictureBox();
            this.bad_guy = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad_guy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.block0);
            this.screen.Controls.Add(this.bad_guy);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.pictureBox2);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1008, 730);
            this.screen.TabIndex = 0;
            // 
            // block4
            // 
            this.block4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block4.BackColor = System.Drawing.Color.Red;
            this.block4.Image = global::Game.Properties.Resources._4;
            this.block4.Location = new System.Drawing.Point(500, 205);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(75, 15);
            this.block4.TabIndex = 5;
            this.block4.TabStop = false;
            // 
            // block3
            // 
            this.block3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block3.BackColor = System.Drawing.Color.Red;
            this.block3.Image = global::Game.Properties.Resources._3;
            this.block3.Location = new System.Drawing.Point(750, 310);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(100, 15);
            this.block3.TabIndex = 4;
            this.block3.TabStop = false;
            // 
            // block2
            // 
            this.block2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block2.BackColor = System.Drawing.Color.Red;
            this.block2.Image = global::Game.Properties.Resources._2;
            this.block2.Location = new System.Drawing.Point(150, 415);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(125, 15);
            this.block2.TabIndex = 3;
            this.block2.TabStop = false;
            // 
            // block1
            // 
            this.block1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block1.BackColor = System.Drawing.Color.Red;
            this.block1.Image = global::Game.Properties.Resources._1;
            this.block1.Location = new System.Drawing.Point(600, 520);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(150, 15);
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
            // 
            // block0
            // 
            this.block0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.block0.BackColor = System.Drawing.Color.Gold;
            this.block0.Location = new System.Drawing.Point(250, 625);
            this.block0.Name = "block0";
            this.block0.Size = new System.Drawing.Size(500, 15);
            this.block0.TabIndex = 1;
            // 
            // bad_guy
            // 
            this.bad_guy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bad_guy.BackColor = System.Drawing.Color.Red;
            this.bad_guy.Location = new System.Drawing.Point(400, 560);
            this.bad_guy.Name = "bad_guy";
            this.bad_guy.Size = new System.Drawing.Size(25, 65);
            this.bad_guy.TabIndex = 0;
            this.bad_guy.TabStop = false;
            // 
            // player
            // 
            this.player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player.BackColor = System.Drawing.Color.Chartreuse;
            this.player.Location = new System.Drawing.Point(357, 702);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 730);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad_guy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bad_guy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox block0;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

