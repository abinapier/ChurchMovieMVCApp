using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Missionary",
                        Image = "https://lumiere-a.akamaihd.net/v1/images/open-uri20150422-12561-1h7kvyj_5079fa1a.jpeg",
                        Price = 5.07M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "The Testaments: of One Fold and One Shepherd",
                        ReleaseDate = DateTime.Parse("2000-3-24"),
                        Genre = "Book of Mormon",
                        Image = "https://images-na.ssl-images-amazon.com/images/I/81-JS4j1zbL._AC_SL1500_.jpg ",
                        Price = 5.07M,
                        Rating = "Unrated"
                    },
                    new Movie
                    {
                        Title = "Joseph Smith: The Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-12-1"),
                        Genre = "Restoration",
                        Image = "https://assets.ldscdn.org/8b/7a/8b7a1e906d59d7b2608a3ac8ec0f8a4bcd1b60e3/joseph_smith_the_prophet_of_the_restoration.jpeg",
                        Price = 7.99M,
                        Rating = "Unrated"
                    },
                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-5-31"),
                        Genre = "Pioneers",
                        Image = "https://d1hdlz9ljonw49.cloudfront.net/product-images/000/715/548/detail/Ephraims_Rescue_DVD.jpg?1447880052",
                        Price = 11.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Pioneers",
                        Image = "https://bloximages.chicago2.vip.townnews.com/heraldextra.com/content/tncms/assets/v3/editorial/1/26/126fd491-b84b-5df4-95c4-953889c012df/578efd5f3a57f.image.jpg",
                        Price = 9.99M,
                        Rating = "PG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
