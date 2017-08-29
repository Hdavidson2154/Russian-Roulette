using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    

    public partial class Menu : Form
    {
 


        public HighScores High;
        public Menu Men;
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            btnPlay.Enabled = false;

        }

        public void BtnScores_Click(object sender, EventArgs e)
        {

                

            HighScores Scores = new HighScores();

            Scores.Show();

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Game g = new Game();

            g.Show();
        }

        private void BtnHow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Rules to the Game!" + "1. Click Play! " + " 2. Choose to either point at you or Devil trump! " +
                " 3. Load the chamber and click Fire " + " Then hope you aernt the one with a bullet in your head! " + " Good Luck! ");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }
    }
}
