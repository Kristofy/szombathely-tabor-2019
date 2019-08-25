using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsFeed2
{
    public class Article
    {
        public DateTimeOffset PublishTime { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        
    }
}
