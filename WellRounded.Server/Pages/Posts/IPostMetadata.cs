using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts
{
    interface IPostMetadata 
    {
        public string Title { get; set; }
        public string SubHeading { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
    }
}
