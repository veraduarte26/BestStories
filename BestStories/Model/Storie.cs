using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestStories.Model
{
    public class Storie
    {
        public int id { get; set; }
        public string by { get; set; }
        public int descendants { get; set; }
        public List<int> kids { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public string  title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        
    }


    public class ReturnedStorie
    {
        public string title { get; set; }
        public string uri { get; set; }
        public string postedBy { get; set; }
        public DateTime time { get; set; }       
        public int score { get; set; }
        public int commentCount { get; set; }     

    }

}
