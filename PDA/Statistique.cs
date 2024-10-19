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
    public partial class Statistique : Form
    {
        private List<Joueur> ListJoueur;
        private List<Statistic> ListStatistic;
        public Joueur currentJoueur;
        public Statistique(Joueur joueur)
        {
            InitializeComponent();
            currentJoueur = joueur;
            ListJoueur = SerialisationJoueur.ouvrir();
            ListStatistic = SerialisationStatistic.ouvrir();
            label1.Text = currentJoueur.Joueur_prenom;
            label2.Text += rechercheScoreJoueur(joueur.Joueur_id).ToString();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();

            // Create a list of objects combining Joueur and their total score
            var joueursWithScores = ListJoueur.Select(joueur => new
            {
                Joueur = joueur,
                TotalScore = rechercheScoreJoueur(joueur.Joueur_id)
            }).OrderByDescending(j => j.TotalScore) // Sort by score descending
            .ToList(); // Convert to list

            // Rank counter
            int rank = 1;

            // Add rows to the DataGridView
            foreach (var joueurWithScore in joueursWithScores)
            {
                dataGridView1.Rows.Add(rank.ToString(), joueurWithScore.Joueur.Joueur_prenom, joueurWithScore.TotalScore);
                rank++; // Increment rank for each player
            }
        }



        private int rechercheScoreJoueur(string id)
        {
            int score = 0;
            if (ListStatistic == null)
            {
                MessageBox.Show("La liste des statistiques n'est pas initialisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return score; // Return 0 instead of null
            }

            foreach (Statistic s in ListStatistic)
            {
                if (s.Statistic_userId == id)
                {
                    score += s.Statistic_score;
                }
            }
            return score;
        }

        private Joueur rechercherJoueur(string st)
        {
            if (ListJoueur == null)
            {
                MessageBox.Show("La liste des joueurs n'est pas initialisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            foreach (Joueur j in ListJoueur)
            {
                if (j.Joueur_prenom == st)
                {
                    return j;
                }
            }

            MessageBox.Show("Pas de joueur avec ce prénom", "Login joueur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }



        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainScreen newForm = new mainScreen(currentJoueur);
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        
    }
}
