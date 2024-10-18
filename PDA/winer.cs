using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDA
{
    public partial class winer : Form
    {
        public Joueur curentJoueur;

        public winer(Joueur jeuour,string time,int score)
        {
            InitializeComponent();
            curentJoueur = jeuour;
            this.label2.Text = time;
            this.label1.Text = score.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen newForm = new mainScreen(curentJoueur);
         newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
