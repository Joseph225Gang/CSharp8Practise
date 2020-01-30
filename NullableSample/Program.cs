﻿using System;

namespace NullableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region nullable reference types
            var post = new BlogPost("Nullable Ref Types Rock!");
            post.Comments?.Add(new Comment("Yes they do!", new Author("John", "john@nullrefs.com")));
            post.Comments?.Add(new Comment("I love them!", new Author("Leah", "leah@nullrefs.com")));
            post.Comments.Add(null);

            PrintPostInfo(null);

            #endregion
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void PrintPostInfo(BlogPost post)
        {
            Console.WriteLine($"{post.Title} ({post.Title!.Length})");

            foreach (var comment in post.Comments)
            {
                var commentPreview = comment.Body.Length > 10 ?
                    $"{comment.Body.Substring(0, 10)}..." :
                    comment.Body;

                Console.WriteLine($"{comment.PostedBy.Name} ({comment.PostedBy.Email}): " + $"{commentPreview}");
            }
        }
    }
}
