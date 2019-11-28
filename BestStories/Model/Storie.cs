using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestStories.Model
{
    public class Storie
    {
        public string title { get; set; }
        public string uri { get; set; }
        public string postedBy { get; set; }
        public DateTime time { get; set; }
        public int score { get; set; }
        public int commentCount { get; set; }
    }
}
