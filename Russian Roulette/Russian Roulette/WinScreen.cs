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
    

    public partial class WinScreen : Form
    {
        

        public WinScreen()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string StudentName;
            
            string Date;

            StudentName = txtName.Text;
            //Score = lblScore.Text;
            Date = txtDate.Text;

            // code to create a file if it does not exist and add to it
            try
            {
                string path = @"Russion Roulette.Resources.HighScores.csv";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(StudentName + " , " + Game.YourScore + " , " + Date);

                    }
                }
                else
                {
                    // Append to the same file
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(StudentName + " , " + Game.YourScore + " , " + Date);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("File seems to be missing. Please check the path");
            }
            MessageBox.Show("HighScore Submitted!");
        }


        private void BtnAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Your score is: " + Game.YourScore;
        }
    }
}
