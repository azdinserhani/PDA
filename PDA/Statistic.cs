using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDA
{
    [Serializable]
   public class Statistic
    {
        private string userId,type,time;
        private int  score;
        
       public string Statistic_userId { get { return userId; } private set { userId = value; } }  
    public string Statistic_type { get { return type; } private set { type = value; } }
    public int Statistic_score { get { return score; } private set { score = value; } }
    public string Statistic_time { get { return time; } private set { time = value; } }


    public Statistic(string _userId, string _type, string _time, int _score)
        {
            Statistic_userId = _userId;
            Statistic_type = _type;
            Statistic_time = _time;
            Statistic_score = _score;
        }
    }
}
