using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Game : Form
    {

        int Bullet ;
        int Shoot ;
        int ShotCount = 5;
      


       
        public Game()
        {
            InitializeComponent();
        }

        private void pbBullet1_Click(object sender, EventArgs e)
        {

        }
        public void Game_Load(object sender, EventArgs e)
        {
            

            string Picture1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;


       



        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Shoot = Shoot + 1;
           

            lblShotCount.Text = "Shot Count: " + ShotCount.ToString();
            


            GunShot.URL = @"C:\Test\Sounds\44Magnum.mp3";

            if (Shoot == 1)
            {

                ShotCount = ShotCount - 1;

            
            }
            if (Shoot == 2)
            {
                ShotCount = ShotCount - 1;
                PbBullet2.Visible = false;

            }
            if (Shoot == 3)
            {
                ShotCount = ShotCount - 1;

                PbBullet3.Visible = false;
            }
            if (Shoot == 4)
            {
                ShotCount = ShotCount - 1;

                PbBullet4.Visible = false;
            }
            if (Shoot == 5)
            {
                ShotCount = ShotCount - 1;
                PbBullet5.Visible = false;

            }
            else if (Shoot == Bullet)
            {
               
                MessageBox.Show("Youre Dead");
            }
        






        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
           GunLoad.URL = @"C:\Test\Sounds\GunCocking.mp3";


            PbBullet1.Visible = false;
            Random rnd = new Random();





            Bullet = rnd.Next(1, 7);

            MessageBox.Show(Bullet.ToString());

        }

        private void GunShot_Enter(object sender, EventArgs e)
        {

        }

        private void RbAtTrump_CheckedChanged(object sender, EventArgs e)
        {
            pbGun.Image = Properties.Resources.GunReverse;
            
        }

        private void RbAtYou_CheckedChanged(object sender, EventArgs e)
        {
            pbGun.Image = Properties.Resources.Gun;
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBOpponent_Click(object sender, EventArgs e)
        {

        }

        private void PbPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
