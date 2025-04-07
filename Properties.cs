using System;
using System.Collections.Generic;
using System.IO;

namespace FinderTest
{
    class Games
    {
        //id;name;genre;hours;size_GB;installed;avg_session;last_played;achievements;completed;review_rating
        public string id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string hours { get; set; }
        public string size { get; set; }
        public bool installed { get; set; }
        public string avgSession { get; set; }
        public string lastPlayed { get; set; }
        public string achievements { get; set; }
        public bool completed { get; set; }
        public string reviews { get; set; }

    }
}