using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc
{

    enum Dir
    {
        Left,
        Right,
        Up,
        Down
    }


    public partial class Form2 :  Form
    {
        //Metodele
       private static int scorMax=0;

        public static int getScor()
        {
            return scorMax;
        }

        #region variabile
        bool goLeft, goRight, goUp, goDown;//Directia de miscare a personajului
        int speed = 15, zombieSpeed = 5;//Vitezele personajelor
        Dir privire;//Directia in care priveste personajul
        int score = 0;
        int munitie = 5;
        int viata=100;
        int damage = 5;
        bool munitieExist = false;
        Random randNum = new Random();
        List<PictureBox> zombies = new List<PictureBox>();//Lista inamicilor
        #endregion

        #region Start si Desfasurare
        public Form2()
        {
            InitializeComponent();
            Restart();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            //this.SelectBitmap(Properties.Resources.Survivor);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            Player.Location = new Point(0, 0);
            Player.BackColor = Color.Transparent;

        }
        
        private void MainTimer(object sender, EventArgs e)
        {



            if (munitieExist == false&& munitie==0)
            {
                creeazaMunitie();
                munitieExist = true;
                ammo.Text = ammo.Text.Substring(0, Scor.Text.Length - 2);
                ammo.Text += munitie;
            }

            //         label1.Text = "Haha" +b;
            //       b += "a";
            if (goLeft&&Player.Left>0)
            {
                Player.Left -= speed;
                //Player.Location = new Point(Player.Location.X - speed, Player.Location.Y);

            }
            if (goRight&&Player.Left<720)
            {
                Player.Left += speed;

                //Player.Location = new Point(Player.Location.X + speed, Player.Location.Y);

            }
            if (goUp&&Player.Top>0)
            {
                Player.Top -= speed;

                //Player.Location = new Point(Player.Location.X, Player.Location.Y - speed);

            }
            if (goDown&&Player.Top<420)
            {
                Player.Top += speed;
                //Player.Location = new Point(Player.Location.X, Player.Location.Y + speed);

            }


            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (x.Left > Player.Left)
                    {
                        x.Left -= zombieSpeed;
                        //if(((PictureBox)x).Image != Properties.Resources.ZombieL)
                            ((PictureBox)x).Image = Properties.Resources.ZombieL;

                    }
                    if (x.Left < Player.Left)
                    {
                        x.Left += zombieSpeed;
                        //if (((PictureBox)x).Image != Properties.Resources.ZombiR)
                            ((PictureBox)x).Image = Properties.Resources.ZombiR;


                    }
                    if (x.Top > Player.Top)
                    {
                        x.Top -= zombieSpeed;
                        if(x.Top-Player.Top> x.Left - Player.Left) 
                            ((PictureBox)x).Image = Properties.Resources.ZombieU;


                    }
                    if (x.Top < Player.Top)
                    {
                        x.Top += zombieSpeed;
                        if (x.Top - Player.Top < x.Left - Player.Left)
                            ((PictureBox)x).Image = Properties.Resources.ZombieD;

                      

                    }
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        if (viata>0) {
                            viata -= damage;
                            Viata.Value = viata;
                        }
                        else
                        {
                            scorMax = max(scorMax, score);
                            TextRestart.Text = "Ai pierdut. Apasă pe text pentru a reîncepe!!!";
                            TextRestart.BringToFront();
                            label1.Text = "Apasă aici pentru a te întoarce acasă!!!";
                            label1.BringToFront();
                            GameTimer.Enabled = false;
                        }
                    }

                }


                foreach(Control y in this.Controls)
                {
                    if(y is PictureBox && (string)y.Tag =="bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(y.Bounds))
                        {
                            score++;
                            SetScore();



                            this.Controls.Remove(y);
                            ((PictureBox)y).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            creeazaZombie();

                        }
                    }

                }
                if (x is PictureBox && (string)x.Tag == "munitie")
                {
                    if (x.Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        munitie = 5;
                        munitieExist = false;
                        ammo.Text = ammo.Text.Substring(0, Scor.Text.Length - 2);
                        ammo.Text += munitie;

                    }

                }


            }
        }
        #endregion

        #region taste
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
              //  Player.Image = Properties.Resources.SurvivorLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                //Player.Image = Properties.Resources.SurvivorRight;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                //Player.Image = Properties.Resources.SurvivorUp;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                //Player.Image = Properties.Resources.SurvivorDown;
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
 
            if (e.KeyCode == Keys.Left) {
                goLeft = true;
                privire = Dir.Left;
                Player.Image = Properties.Resources.SurvivorLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                privire = Dir.Right;
                Player.Image = Properties.Resources.SurvivorRight;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                privire = Dir.Up;
                Player.Image = Properties.Resources.SurvivorUp;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                privire = Dir.Down;
                Player.Image = Properties.Resources.SurvivorDown;
            }

            if(e.KeyCode == Keys.Space)
            {
                if (munitie > 0)
                {
                    Impusca(privire);
                    munitie--;
                    ammo.Text = ammo.Text.Substring(0, Scor.Text.Length - 2);
                    ammo.Text += munitie;
                }
            }


        }
        #endregion

        #region actiuni
        private void Impusca(Dir directie)
        {
            Bullet impuscaBullet = new Bullet();
            impuscaBullet.directie = directie;
            impuscaBullet.bulletLeft = Player.Left + (Player.Width / 2);
            impuscaBullet.bulletTop = Player.Top + (Player.Height / 2);
            impuscaBullet.MakeBullet(this);

        }

        private void creeazaMunitie()
        {
            PictureBox patroane = new PictureBox();
            patroane.Tag = "munitie";
            patroane.Image = Properties.Resources.ammo;
            patroane.Left = randNum.Next(0, 720);
            patroane.Top = randNum.Next(0, 450);
            patroane.BackColor = Color.Transparent;


            patroane.Size = new Size(Player.Size.Width - 60, Player.Size.Height - 60);

            patroane.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(patroane);
            Player.BringToFront();
        }

        private void creeazaZombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.ZombieD;
            zombie.Left = randNum.Next(0, 800);
            zombie.Top = randNum.Next(0, 500);
            zombie.BackColor = Color.Transparent;

            zombie.Size = new Size(Player.Size.Width-40, Player.Height-40);

            zombie.SizeMode = PictureBoxSizeMode.Zoom;
            zombies.Add(zombie);


            this.Controls.Add(zombie);
            Player.BringToFront();

        }
        #endregion

        #region Restart

       private int max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }

        private void Inchide(object sender, FormClosingEventArgs e)
        {
           /* Form1 meniu = new Form1();
            this.Hide();
            meniu.ShowDialog();
            this.Close();*/
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           this.Close();
        }

        private void SetScore()
        {
            if (score < 10)
            {
                Scor.Text = Scor.Text.Substring(0, Scor.Text.Length - 3);
                Scor.Text += "00";
                Scor.Text += score;
            }
            else
            {
                Scor.Text = Scor.Text.Substring(0, Scor.Text.Length - 3);
                Scor.Text += "0";
                Scor.Text += score;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextRestart_Click(object sender, EventArgs e)
        {
            Restart();
            GameTimer.Enabled = true;
        }

        private void Restart()
        {
            Player.Image = Properties.Resources.SurvivorUp;
            if (munitieExist)
            {
                foreach(Control x in this.Controls)
                {
                    if(x is PictureBox && (string)x.Tag == "munitie")
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        munitieExist = false;

                    }
                }
            }

            viata = 100;
            Viata.Value = 100;

            munitie = 5;
            ammo.Text = ammo.Text.Substring(0, Scor.Text.Length - 2);
            ammo.Text += munitie;

            score= 0;
            SetScore();
            
            TextRestart.Text = "";
            label1.Text = "";



            foreach(PictureBox x in zombies)
            {
                this.Controls.Remove(x);
            }

            zombies.Clear();

            for(int i = 0; i < 3; i++)
            {
                creeazaZombie(); 
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;


            GameTimer.Start();

        }
        #endregion
    }
}
