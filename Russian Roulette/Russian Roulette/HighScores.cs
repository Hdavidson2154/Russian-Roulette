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
    public partial class HighScores : Form
    {
        
        public Menu Men;
       
        public HighScores()


        {

            InitializeComponent();
        }

        private void DGScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            string path = @"Russion Roulette.Resources.HighScores.csv";

            if (File.Exists(path))
            {

                //then read it
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        //textBox1.Text = textBox1.Text + "\r\n" + line;

                        // to seperate out 
                        //line.Split(',');

                        string[] split = line.Split(',');
                        DGScore.Rows.Add(split[0], split[1], split[2]);
                    }
                }

            }

        }
    }

}
