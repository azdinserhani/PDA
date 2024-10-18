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
    public partial class Loser : Form
    {
        public Joueur curentJoueur;
        public Loser (Joueur jeuour,string time,int score)
        {
            InitializeComponent();
            curentJoueur = jeuour;
            this.label2.Text = time;
            this.label1.Text = score.ToString();
        }
        public string type;
        //public Joueur curentJoueur;
        

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            mainScreen newForm = new mainScreen(curentJoueur);
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loser_Load(object sender, EventArgs e)
        {

        }

        
        

    }
}
