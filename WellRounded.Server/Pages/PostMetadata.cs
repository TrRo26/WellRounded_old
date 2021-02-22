using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace Posts
{
    public class PostMetadata : IPostMetadata
    {
        public string Title { get; set; }
        public string SubHeading { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string ImageLink { get; set; }

        //public static List<PostMetadata> GetPostsMetadata()
        //{
        //    List<PostMetadata> allPostsMetadata = new List<PostMetadata>();

        //    IEnumerable<Type> posts = Assembly
        //        .GetExecutingAssembly()
        //        .GetTypes()
        //        .Where(t => t.Namespace.Equals("Posts"))
        //        .OrderBy(x => x.Name);

        //    foreach (var post in posts)
        //    {
        //        if (post.FullName != "Posts.IPostMetadata" && post.FullName != "Posts.PostMetadata")
        //        {
        //            dynamic currentPost = Activator.CreateInstance(post);
        //            allPostsMetadata.Add(currentPost.postMetadata);
        //        }
        //    }

        //    return allPostsMetadata;
        //}
    }
}
