using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace PDA
{
    class SerialisationStatistic
    {
        private static string cheminFichier = "lesStatistic.bin";
        public static void enregistre(List<Statistic> ListStatistic){
            if(ListStatistic != null){
                if(ListStatistic.Count > 0){
                    FileStream fs = File.Create(cheminFichier);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs,ListStatistic);
                    fs.Close();
                }
            }
        }
        public static List<Statistic> ouvrir()
        {
            List<Statistic> ListStatistic = new List<Statistic>();
            if (File.Exists(cheminFichier))
            {
                FileStream fs = null;
                try
                {
                    fs = File.OpenRead(cheminFichier);
                    BinaryFormatter bf = new BinaryFormatter();
                    ListStatistic = (List<Statistic>)bf.Deserialize(fs);
                }
                catch (Exception exp)
                {
                    throw exp;
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
            return ListStatistic;
        }
    }
}
