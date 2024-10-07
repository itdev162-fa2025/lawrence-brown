using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmodLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second Post",
                        Body = "Enim lacus vestibulum maximus neque facilisis mauris mus",
                        Date = DateTime.Now.AddDays(-7),
                    },
                    new Post {
                        Title = "Third Post",
                        Body = "Commodo fames tortor auctor taciti augue integer magna volutpat placerat",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}