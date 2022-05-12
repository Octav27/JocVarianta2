using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Joc
{
    class Bullet
    {
        public int bulletTop;
        public int bulletLeft;
        public Dir directie;
   

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);
            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if(directie == Dir.Left)
            {
                bullet.Left -= speed;
            }
            if (directie == Dir.Right)
            {
                bullet.Left += speed;
            }
            if (directie == Dir.Up)
            {
                bullet.Top -= speed;
            }
            if (directie == Dir.Down)
            {
                bullet.Top += speed;
            }


            if(bullet.Left<0 || bullet.Left>830 || bullet.Top < 0 || bullet.Top > 520)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }


        }


    }
}
