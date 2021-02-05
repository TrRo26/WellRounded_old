using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Posts;

namespace DataService
{
    public class PostsService
    {
        public static List<PostMetadata> GetPostsMetadata()
        {
            List<PostMetadata> allPostsMetadata = new List<PostMetadata>();

            IEnumerable<Type> posts = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.Namespace.Equals("Posts"))
                .OrderBy(x => x.Name);

            foreach (var post in posts)
            {
                if (post.FullName != "Posts.IPostMetadata" &&
                    post.FullName != "Posts.PostMetadata" &&
                    post.FullName != "Posts.Post")
                {
                    dynamic currentPost = Activator.CreateInstance(post);
                    allPostsMetadata.Add(currentPost.postMetadata);
                }
            }

            return allPostsMetadata;
        }

        //public static List<Type> GetPosts()
        //{
        //    List<Type> allPosts = new List<Type>();

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
        //            allPosts.Add((Type)currentPost);
        //        }
        //    }

        //    return allPosts;
        //}
    }
}
