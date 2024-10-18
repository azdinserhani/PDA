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
    public partial class Register : Form
    {
        private List<Joueur> ListJoueuer;
        Joueur curentJoueur;
        public Register()
        {
            InitializeComponent();
            
            ListJoueuer= SerialisationJoueur.ouvrir();
        }
        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void ajouterJoueur() {
            Random random = new Random();
            
            string nom = this.nomInput.Text;
            string prenom = this.prenomInput.Text;
            int age = int.Parse(this.ageInput.Text);
            string password = this.passwordInput.Text;
            string uniqueId = GenerateRandomString(10); // Generate a 10-character random string
            if (this.nomInput.Text != "" || this.prenomInput.Text != "" || this.ageInput.Text != "" || this.passwordInput.Text != "")
            {
                MessageBox.Show("Les information nest pas complete", "Alert",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Joueur jeuour = new Joueur(uniqueId,nom,prenom,age,password);
            if (rechercherDoublon(jeuour) == false)
            {
                ListJoueuer.Add(jeuour);
                curentJoueur = jeuour;
                SerialisationJoueur.enregistre(ListJoueuer);
                this.Hide();
                mainScreen mainScreen = new mainScreen(curentJoueur);
                mainScreen.FormClosed += (s, args) => this.Close();
                mainScreen.Show();
                
            }
            else {
                if (this.nomInput.Text != "" && this.prenomInput.Text != "" && this.ageInput.Text != "" && this.passwordInput.Text != "") {
                    MessageBox.Show("Cette Joueur deja exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }

        }
        private bool rechercherDoublon(Joueur jeuour)
        {
            bool bl = false;
            foreach (Joueur e in ListJoueuer)
            {
                if (e.Joueur_prenom == jeuour.Joueur_prenom)
                {
                    bl = true;
                    break;
                }
            }
            return bl;
        }
           

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ajouterJoueur();
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ajouterJoueur();
        }

        private void prenomInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                this.nomInput.Focus();
            }
        }

        private void nomInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                ageInput.Focus();
            }
        }

        private void ageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                passwordInput.Focus();
            }
        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                ajouterJoueur();
            }
        }

        

     

        
    }
}
