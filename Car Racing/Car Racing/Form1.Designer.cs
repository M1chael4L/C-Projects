namespace Car_Racing
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            award = new PictureBox();
            explosion = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            player = new PictureBox();
            roadTrack2 = new PictureBox();
            roadTrack1 = new PictureBox();
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)award).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(award);
            panel1.Controls.Add(explosion);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(player);
            panel1.Controls.Add(roadTrack2);
            panel1.Controls.Add(roadTrack1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 494);
            panel1.TabIndex = 0;
            // 
            // award
            // 
            award.Image = Properties.Resources.bronze;
            award.Location = new Point(116, 162);
            award.Name = "award";
            award.Size = new Size(250, 100);
            award.SizeMode = PictureBoxSizeMode.AutoSize;
            award.TabIndex = 4;
            award.TabStop = false;
            // 
            // explosion
            // 
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(38, 281);
            explosion.Name = "explosion";
            explosion.Size = new Size(64, 64);
            explosion.SizeMode = PictureBoxSizeMode.AutoSize;
            explosion.TabIndex = 4;
            explosion.TabStop = false;
            // 
            // AI2
            // 
            AI2.Image = Properties.Resources.carGrey;
            AI2.Location = new Point(349, 46);
            AI2.Name = "AI2";
            AI2.Size = new Size(50, 100);
            AI2.SizeMode = PictureBoxSizeMode.AutoSize;
            AI2.TabIndex = 4;
            AI2.TabStop = false;
            AI2.Tag = "carRight";
            // 
            // AI1
            // 
            AI1.Image = Properties.Resources.carGreen;
            AI1.Location = new Point(74, 46);
            AI1.Name = "AI1";
            AI1.Size = new Size(50, 101);
            AI1.SizeMode = PictureBoxSizeMode.AutoSize;
            AI1.TabIndex = 4;
            AI1.TabStop = false;
            AI1.Tag = "carLeft";
            // 
            // player
            // 
            player.Image = Properties.Resources.carYellow;
            player.Location = new Point(207, 356);
            player.Name = "player";
            player.Size = new Size(50, 99);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // roadTrack2
            // 
            roadTrack2.Image = Properties.Resources.roadTrack;
            roadTrack2.Location = new Point(0, 0);
            roadTrack2.Name = "roadTrack2";
            roadTrack2.Size = new Size(473, 494);
            roadTrack2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTrack2.TabIndex = 1;
            roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            roadTrack1.Image = Properties.Resources.roadTrack;
            roadTrack1.Location = new Point(0, -494);
            roadTrack1.Name = "roadTrack1";
            roadTrack1.Size = new Size(473, 494);
            roadTrack1.SizeMode = PictureBoxSizeMode.StretchImage;
            roadTrack1.TabIndex = 0;
            roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(196, 558);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(125, 49);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += restartGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 520);
            label1.Name = "label1";
            label1.Size = new Size(97, 26);
            label1.TabIndex = 2;
            label1.Text = "Score: 0";
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 621);
            label2.Name = "label2";
            label2.Size = new Size(473, 143);
            label2.TabIndex = 3;
            label2.Text = "Press Left and Right to move the car. \r\n\r\nDon't hit any other cars in the game and survive as long as you can.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(497, 773);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(515, 820);
            MinimumSize = new Size(515, 820);
            Name = "Form1";
            Text = "Car racing game";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)award).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadTrack1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private PictureBox roadTrack1;
        private PictureBox award;
        private PictureBox explosion;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox player;
        private PictureBox roadTrack2;
        private System.Windows.Forms.Timer gameTimer;
    }
}
