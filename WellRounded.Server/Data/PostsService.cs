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

        //public string ApplyCategoryFilter(string category)
        //{

        //}

        /// <summary>
        ///     Get all posts when passing null or all posts of a category when passing category name 
        /// </summary>
        //public static List<TestPost1> GetPosts(string category = null)
        //{
        //    List<TestPost1> allPosts = new List<TestPost1>();
        //    //IEnumerable<Type> allPosts = new IEnumerable<Type>();

        //    IEnumerable<Type> posts = Assembly
        //        .GetExecutingAssembly()
        //        .GetTypes()
        //        .Where(t => t.Namespace.Equals("Posts"))
        //        .OrderBy(x => x.Name);

        //    foreach (var post in posts)
        //    {
        //        if (post.FullName != "Posts.IPostMetadata" &&
        //            post.FullName != "Posts.PostMetadata" &&
        //            post.FullName != "Posts.Post")
        //        {
        //            dynamic currentPost = Activator.CreateInstance(post);
        //            allPosts.Add((TestPost1)currentPost);
        //        }
        //    }

        //    //if (category == null)
        //    //{

        //    //}

        //    return allPosts;
        //}

        //public List<PostMetadata> posts = DataService.PostsService.GetPosts(null);
    }
}