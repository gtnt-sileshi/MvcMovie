using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                //looking for movie
                if (context.Movie.Any())
                {
                    return; // Db has been seeded
                }

                context.Movie.AddRange(


                    new Movie
                    {
                        Title = "ዝምታዬ",
                        ReleaseDate = DateTime.Parse("2023-02-12"),
                        Genre = "Drama",
                        Price = 300,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "ላምባ",
                        ReleaseDate = DateTime.Parse("2023-03-12"),
                        Genre = "Drama",
                        Price = 200,
                        Rating = "B"
                    });
                context.SaveChanges();
            }

        }
    }
}
