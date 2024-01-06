namespace WindowsOyunu
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
            timer1 = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            Laser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Laser).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += GameMainTime;
            // 
            // Player
            // 
            Player.Image = Properties.Resources.pixil_frame_0__1_;
            Player.Location = new Point(268, 279);
            Player.Name = "Player";
            Player.Size = new Size(35, 35);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // Laser
            // 
            Laser.Image = Properties.Resources.pixil_frame_0__3_;
            Laser.Location = new Point(268, 256);
            Laser.Name = "Laser";
            Laser.Size = new Size(24, 17);
            Laser.SizeMode = PictureBoxSizeMode.StretchImage;
            Laser.TabIndex = 1;
            Laser.TabStop = false;
            Laser.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 6, 8);
            ClientSize = new Size(584, 561);
            Controls.Add(Laser);
            Controls.Add(Player);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Laser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox Player;
        private PictureBox Laser;
    }
}
