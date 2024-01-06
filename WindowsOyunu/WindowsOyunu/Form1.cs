using Microsoft.VisualBasic.Devices;

namespace WindowsOyunu
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameStart();

        }
        private Point bulletStartPosition;
        private Point bulletEndPosition;
        bool GoLeft, GoRight, Shoot, GoUp, GoDown, mouseClick;
        int laserSpeed = PlayerStats.laserSpeed;
        int playerSpeed = PlayerStats.playerSpeed;
        float laserleftt;
        float lasertopp;


        private void GameMainTime(object sender, EventArgs e)
        {
            int formHeight = ClientRectangle.Height;
            int formWidth = ClientRectangle.Width;
            if (GoLeft == true && Player.Left > 0)
            {
                Player.Left -= playerSpeed;
            }
            if (GoRight == true && Player.Left < formWidth - 35)
            {
                Player.Left += playerSpeed;
            }
            /*if((GoRight==true && Player.Left == formWidth - 60) )
            {
                this.Size = new Size(formHeight, formWidth + playerSpeed);
                Player.Left += playerSpeed;
                System.Threading.Thread.Sleep(10);
                
                
            }
            */
           

            if (GoUp == true && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }
            if (GoDown == true && Player.Top < formHeight - 35)
            {
                Player.Top += playerSpeed;

            }
            if (Shoot)
            {
                Laser.Visible = true;
                Laser.Top += (int)Math.Round(lasertopp);
                Laser.Left += (int)Math.Round(laserleftt);
                if(Laser.Top<-30 | Laser.Left < -30)
                {
                    Shoot = false;
                }
            }
            
            /*if (Player.Top==0)sa
            {
                Form1 test= new Form1();
                test.StartPosition = FormStartPosition.Manual;
                test.Location = new Point(10,10);
                test.ShowDialog();
            }
            */
        }

        public void GameStart()
        {
            DoubleBuffered = true;
            timer1.Start();
        }
        private void GameStop()
        {

        }

        private void OpenSkilTab()
        {

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left | e.KeyCode == Keys.A)
            {
                GoLeft = false;

            }
            if (e.KeyCode == Keys.Right | e.KeyCode == Keys.D)
            {
                GoRight = false;

            }
            if (e.KeyCode == Keys.Up | e.KeyCode == Keys.W)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down | e.KeyCode == Keys.S)
            {
                GoDown = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left | e.KeyCode == Keys.A)
            {
                GoLeft = true;

            }
            if (e.KeyCode == Keys.Right | e.KeyCode == Keys.D)
            {
                GoRight = true;

            }
            if (e.KeyCode == Keys.Up | e.KeyCode == Keys.W)
            {
                GoUp = true;
            }
            if (e.KeyCode == Keys.Down | e.KeyCode == Keys.S)
            {
                GoDown = true;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                bulletStartPosition = new Point(Player.Left, Player.Top - 23);
                bulletEndPosition = new Point((Size)e.Location);
                float dx = bulletEndPosition.X - bulletStartPosition.X;
                float dy = bulletEndPosition.Y - bulletStartPosition.Y;
                float length = (float)Math.Sqrt(dx * dx + dy * dy);
                bulletStartPosition.X += (int)(laserSpeed * dx / length);
                bulletStartPosition.Y += (int)(laserSpeed * dy / length);
                Laser.Location = bulletStartPosition;
                laserleftt = (laserSpeed*dx/length);
                lasertopp= (laserSpeed*dy/length);
                
                if (bulletEndPosition.Y - Player.Top > 0)
                {
                    bulletStartPosition = new Point(Player.Left, Player.Top + 23);
                    Laser.Location = bulletStartPosition;
                    

                }


                mouseClick = true;
                Shoot = true;
                /* Laser.Top = Player.Top - 23;
                Laser.Left = Player.Left ;
                mouseClick = true;
                Shoot = true;
               */
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseClick = false;

            }
        }

       
    }
}
