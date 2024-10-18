using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDA
{
    [Serializable]
    public class Joueur
    {
        private string id;
        private string nom, prenom,password;
        private int age;
        public string Joueur_id { get { return id; }  private set {id = value;}}
        public string Joueur_nom { get { return nom; } private set { nom = value; } }
        public string Joueur_prenom { get { return prenom; } private set { prenom = value; } }
        public string Joueur_password { get { return password; } private set { password= value; } }
        //public int Joueur_sec { get { return sec; } private set { sec= value; } }
       // public int Joueur_min { get { return min; } private set { min = value; } }
        //public int Joueur_score { get { return score; } private set { score = value; } }
        public int Joueur_age { get { return age; } private set { age = value; } }
        public Joueur(string _id, string _nom, string _prenom, int _age,string _password) {
            Joueur_id = _id;
            Joueur_nom = _nom;
            Joueur_prenom = _prenom;
            Joueur_age = _age;
            Joueur_password = _password;
        }
    }
}
