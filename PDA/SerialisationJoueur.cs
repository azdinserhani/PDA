using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace PDA
{
    public class SerialisationJoueur
    {
        private static string cheminFichier = "lesJoueur.bin";
        public static void enregistre(List<Joueur> ListJoueuer){
            if(ListJoueuer != null){
                if(ListJoueuer.Count > 0){
                    FileStream fs = File.Create(cheminFichier);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, ListJoueuer);
                    fs.Close();
                }
            }
        }
        public static List<Joueur> ouvrir() {
            List<Joueur> ListJoueur = new List<Joueur>();
            if (File.Exists(cheminFichier)) {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(cheminFichier);
                    BinaryFormatter bf = new BinaryFormatter();
                    ListJoueur = (List<Joueur>)bf.Deserialize(fs);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
                finally {
                    if (fs != null)
                         fs.Close();
                }
            }
            return ListJoueur;
        }
    }
}
