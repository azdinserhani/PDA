using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace PDA
{
    public partial class playScreen : Form
    {
        public int startCount = 0;
        public string randomNumber;
        public static int score, nombreTentative,maxTentativeNumber;

        public Joueur currentJoueur;
        public string type;
        private List<Statistic> ListStatistic;
        public DateTime startTime;
        public DateTime endTime;

        public playScreen(Joueur jeuour,string type)
        {
            InitializeComponent();
         
          
            startTime = DateTime.Now;    
            currentJoueur = jeuour;
            this.name.Text = jeuour.Joueur_prenom;
            DateTime currentDateTime =  DateTime.Now;
            int year = currentDateTime.Year;
            int month = currentDateTime.Month;
            int day = currentDateTime.Day;
            int hour = currentDateTime.Hour;
            int minute = currentDateTime.Minute;
            int sec = currentDateTime.Second;
            this.label4.Text = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            this.label5.Text = hour.ToString() + "H:" + minute.ToString() + "m:" + sec.ToString() + "s";
       
            if (type == "Easy")
            {

                score = 6;
                nombreTentative = 4;
                 randomNumber = GenerateRandomNumber(2).ToString();
            }
            else if (type == "Medium")
            {
                score = 10;
                nombreTentative = 8;
                randomNumber = GenerateRandomNumber(4).ToString();
            }
            else if (type == "Hard")
            {
                score = 15;
                nombreTentative = 12;
                randomNumber = GenerateRandomNumber(6).ToString();
            }
            this.textBox1.Text = randomNumber;
            this.label1.Text = score.ToString();

        }

        private void PlaySound(string url)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(url+".wav"); // Adjust the path as necessary
                player.Play(); // or use player.PlaySync() for synchronous playing
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private int GenerateRandomNumber(int length)
        {
            Random random = new Random();
            // Calculate the minimum and maximum values based on the length
            int minValue = (int)Math.Pow(10, length - 1); // e.g., length 3 => 100
            int maxValue = (int)Math.Pow(10, length) - 1; // e.g., length 3 => 999

          
            return random.Next(minValue, maxValue + 1); // maxValue + 1 to include maxValue
            
          
        }
        static int BienPlaces(int num1, int num2)
        {
            int digit1, digit2;
            int chB = 0;

            // Loop until both numbers have no more digits
            while (num1 > 0 || num2 > 0)
            {
                // Extract rightmost digit of both numbers
                digit1 = num1 % 10;
                digit2 = num2 % 10;

                // Compare the digits
                if (digit1 == digit2)
                {
                    chB += 1;
                }

                // Remove the rightmost digit from both numbers
                num1 /= 10;
                num2 /= 10;
            }

            return chB;
        }

        // Method to count the number of "incorrect places" (malPlaces)
        static int MalPlaces(int num1, int num2)
        {
            int digit1, digit2;
            int chB = 0;

            // Loop until both numbers have no more digits
            while (num1 > 0 || num2 > 0)
            {
                // Extract rightmost digit of both numbers
                digit1 = num1 % 10;
                digit2 = num2 % 10;

                // Compare the digits
                if (digit1 != digit2)
                {
                    chB += 1;
                }

                // Remove the rightmost digit from both numbers
                num1 /= 10;
                num2 /= 10;
            }

            return chB;
        }

        private int rechercheScoreJoueur(string id)
        {
            int score = 0;
            if (ListStatistic == null)
            {
               // MessageBox.Show("La liste des statistiques n'est pas initialisée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                PlaySound("coins");
                startCount += 1;

                string bPlace = BienPlaces(int.Parse(textBox2.Text), int.Parse(randomNumber)).ToString();
                string mPlace = MalPlaces(int.Parse(textBox2.Text), int.Parse(randomNumber)).ToString();
                dataGridView1.Rows.Add(textBox2.Text, bPlace, mPlace);

                if (startCount >= nombreTentative)
                {
                    endTime = DateTime.Now;
                    TimeSpan timespan = endTime - startTime;

                    Loser loserForm = new Loser(currentJoueur, timespan.ToString(), score);

                    loserForm.FormClosed += (s, args) => this.Close();
                    dataGridView1.Rows.Clear();
                    loserForm.Show();
                    PlaySound("game");
                }

                if (textBox2.Text == randomNumber)
                {
                    PlaySound("Super");

                    endTime = DateTime.Now;
                    TimeSpan timespan = endTime - startTime;

                    // Retrieve the previous score for the current player
                    int previousScore = rechercheScoreJoueur(currentJoueur.Joueur_id);

                    // Add the current score to the previous score
                    int totalScore = previousScore + score;

                    // Create the statistic object with the updated score
                    Statistic stat = new Statistic(currentJoueur.Joueur_id, type, timespan.ToString(), totalScore);

                    // Update the list of statistics
                    ListStatistic = SerialisationStatistic.ouvrir();
                    if (ListStatistic == null) ListStatistic = new List<Statistic>();

                    // Add the updated statistic to the list
                    ListStatistic.Add(stat);

                    // Save the updated statistics list
                    SerialisationStatistic.enregistre(ListStatistic);

                    winer winerForm = new winer(currentJoueur, timespan.ToString(), totalScore);
                    winerForm.FormClosed += (s, args) => this.Close();
                    winerForm.Show();

                    this.Hide();
                }

                textBox2.Clear();
            }
        }


        private void playScreen_Load(object sender, EventArgs e)
        {

        }

       

       

        
    }
}
