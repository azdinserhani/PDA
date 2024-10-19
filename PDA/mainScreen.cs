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
    public partial class mainScreen : Form
    {

      
        public Joueur curentJoueur;
        
        public mainScreen(Joueur joueur)
        {
            
          
            InitializeComponent();
            label2.Text = joueur.Joueur_prenom;
            curentJoueur = joueur;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        


    

        private void mainScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            playScreen newForm = new playScreen(curentJoueur, "Easy");
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            playScreen newForm = new playScreen(curentJoueur, "Medium");
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            playScreen newForm = new playScreen(curentJoueur, "Hard");
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistique stat = new Statistique(curentJoueur);
            stat.FormClosed += (s, args) => this.Close();
            stat.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }



     

       
    }
}
