using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace Posts
{
    public class Post : ComponentBase
    {
        public static string TestTitle { get; set; }
        public static string TestSubHeading { get; set; }

        public Post()
        {
            //TestTitle = title;
            //TestSubHeading = sh;
        }

    }
}
