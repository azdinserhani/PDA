using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PDA
{
    public partial class login : Form
    {
        public Joueur curentJoueur;
        private List<Joueur> ListJoueuer;
            

        public login()
        {
            InitializeComponent();
            ListJoueuer = SerialisationJoueur.ouvrir();
            this.usernameInput.Focus();
        }
        
        private void loginJoueur()
        {
            string username = this.usernameInput.Text;
            string password = this.passwordInput.Text;

            // Validate if the input fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Les informations ne sont pas complètes", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Find the player by username
            Joueur findJouer = rechercherJoueur(username);
            if (findJouer == null)
            {
                MessageBox.Show("Pas de joueur avec ce prénom", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validate password
            if (findJouer.Joueur_password == password)
            {
                curentJoueur = findJouer;
                this.Hide();
                mainScreen mainScreen = new mainScreen(curentJoueur);
                mainScreen.FormClosed += (s, args) => this.Close();
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show("Le mot de passe est incorrect", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Joueur rechercherJoueur(string st)
        {
            if (ListJoueuer == null)
            {
                MessageBox.Show("La liste des joueurs n'est pas initialisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            foreach (Joueur j in ListJoueuer)
            {
                if (j.Joueur_prenom == st)
                {
                    return j;
                }
            }

            MessageBox.Show("Pas de joueur avec ce prénom", "Login joueur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginJoueur();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordInput.Focus();
        }

        private void usernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                e.SuppressKeyPress = true;
                passwordInput.Focus();
            }
        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                loginJoueur();
            }
        }

     

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            loginJoueur();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.FormClosed += (s, args) => this.Close();
            registerForm.Show();
        }

        

       

       

       



        
    }
}
