using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestStories.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BestStories.Model
{
    public class ManageStorie
    {


        public static List<ReturnedStorie> getTopTwenty()

        {
            string url = "https://hacker-news.firebaseio.com/v0/beststories.json";
            var storiesIds = SerialializeJson.SerializeJson<List<int>>(url);
            storiesIds = storiesIds.OrderByDescending(x=>x).Take(20).ToList();
            List<ReturnedStorie> stories = new List<ReturnedStorie>();
            foreach (var id in storiesIds)

            {
                string urlStorie = "https://hacker-news.firebaseio.com/v0/item/" + id + ".json";
                var storie = SerialializeJson.SerializeJson<Storie>(urlStorie);             
                ReturnedStorie returnedStorie = new ReturnedStorie
                {
                    title = storie.title,
                    uri = storie.url,
                    postedBy = storie.by,
                    time = getDateTimeFromTimeStamp(storie.time),
                    score = storie.score,
                    commentCount = storie.descendants
                };

                stories.Add(returnedStorie);
            }

            stories.OrderByDescending(x => x.score).ToList();
            return stories;

        }



        private static DateTime getDateTimeFromTimeStamp(int timestamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp);
        }

    }
}
