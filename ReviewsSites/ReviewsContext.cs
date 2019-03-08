using Microsoft.EntityFrameworkCore;
using ReviewsSites.Models;

namespace ReviewsSites
{
    public class ReviewsContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BeerdsReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Style = "IPA",
                    ImgPath = "/Images/IPA.png",
                    DetailDescription = "Characterized by floral, fruity, citrus-like, piney or resinous American-variety hop character, the IPA beer style is all about hop flavor, aroma and bitterness. This has been the most-entered category at the Great American Beer Festival for more than a decade, and is the top-selling craft beer style in supermarkets and liquor stores across the U.S."
                },
                new Category()
                {
                    CategoryId = 2,
                    Style = "Stout",
                    ImgPath = "/Images/Stout.png",
                    DetailDescription = "A stout beer is a dark, sometimes bitter beer that was first commercially produced in the 1730s. The first versions of this drink were from Ireland, where the still most popular stout is produced by Guinness. Yet Guinness is only one of the many companies that produce and market stouts."
                },
                new Category()
                {
                    CategoryId = 3,
                    Style = "Wheat",
                    ImgPath = "/Images/Wheat-Beer.png",
                    DetailDescription = "Wheat beer is a beer, usually top-fermented, which is brewed with a large proportion of wheat relative to the amount of malted barley. The two main varieties are Weissbier and Witbier; minor types include Lambic, Berliner Weisse and Gose"
                },
                new Category()
                {
                    CategoryId = 4,
                    Style = "High ABV",
                    ImgPath = "/Images/SnakeVenom.png",
                    DetailDescription = "Strong beers have a special place in many people's hearts, primarily because they involve the delicious fizz of beer with a very powerful alcoholic punch. They get you blitzed without requiring six or more of them per sitting, and that makes them amazing. "
                });

            modelBuilder.Entity<Beer>().HasData(
                 new Beer()
                 {
                     BeerId = 1,
                     Name = "Zombie Dust",
                     Abv = 6.20f,
                     Brewery = "Three Floyds",
                     Rating = 4.8f,
                     Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.",
                     ImgPath = "/Images/Zombiedust.png",
                     CategoryId = 1
                 },
                 new Beer()
                 {
                     BeerId = 2,
                     Name = "Hopslam",
                     Abv = 10.00f,
                     Brewery = "Bells",
                     Rating = 4.6f,
                     Description = "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.",
                     ImgPath = "/Images/Hopslam.png",
                     CategoryId = 1
                 },
                 new Beer()
                 {
                     BeerId = 3,
                     Name = "Boomsauce",
                     Abv = 7.80f,
                     Brewery = "Lord Hobo",
                     Rating = 3.0f,
                     Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.",
                     ImgPath = "/Images/Boomsauce.png",
                     CategoryId = 1
                 },

                new Beer()
                {
                    BeerId = 4,
                    Name = "Guinness",
                    Abv = 4.30f,
                    Brewery = "Diageo",
                    Rating = 4.6f,
                    Description = "Guinness is an Irish dry stout that originated in the brewery of Arthur Guinness at St. James's Gate, Dublin, Ireland, in 1759. It is one of the most successful beer brands worldwide, brewed in almost 50 countries and available in over 120. Sales in 2011 amounted to 850 million litres",
                    ImgPath = "/Images/Gusiness.png",
                    CategoryId = 2
                },

                 new Beer()
                 {
                     BeerId = 5,
                     Name = "Sierra Nevada Stout",
                     Abv = 5.80f,
                     Brewery = "Sierra Nevada",
                     Rating = 4.0f,
                     Description = "Before Sierra Nevada was a reality, our founders brewed beer at home and dreamed of building a brewery one day. Back then, they brewed the beers they wanted to drink—bold and full of flavor. Stouts had always been a favorite, so when we needed a big and rich beer to test out the brewing system at our fledgling brewery, stout was the obvious choice. Thirty years later, not much has changed. We’re still brewing the beers we want to drink and our classic Stout is the same as it’s ever been—big, rich, bold, black as night and filled with the wild-eyed passion of which dreams are made.",
                     ImgPath = "/Images/Sierra_Nevada_Stout.png",
                     CategoryId = 2
                 },

                new Beer()
                {
                    BeerId = 6,
                    Name = "Darkness Russian Stout",
                    Abv = 10.30f,
                    Brewery = "Surly Brewing Co",
                    Rating = 4.5f,
                    Description = "Russian Imperial Stout contains waves of chocolate, coffee, cherry, raisin, and toffee, plus a non-traditional dose of aromatic hops.",
                    ImgPath = "/Images/DarknessStout.png",
                    CategoryId = 2
                },

                new Beer()
                {
                    BeerId = 7,
                    Name = "Blue Moon Mango Wheat",
                    Abv = 5.40f,
                    Brewery = "Coors Brewing Co",
                    Rating = 3.57f,
                    Description = "In addition to Coor's refreshingly unique Blue Moon® Belgian White Belgian-Style Wheat Ale, we also offer our collection of flavorful seasonal and limited release beers that reflect Blue Moon’s twist on various beer styles. An appreciation for the creative process and a passion for brewing enable us at Blue Moon Brewing Company® to offer a welcome twist of flavor in our beers that everyone can enjoy.",
                    ImgPath = "/Images/Wheat-Beer.png",
                    CategoryId = 3
                },

                new Beer()
                {
                    BeerId = 8,
                    Name = "GumballHead",
                    Abv = 5.60f,
                    Brewery = "3 Floyds Brewing Co",
                    Rating = 4.20f,
                    Description = "An American wheat beer with a refreshing, crisp citrus finish. This delicious session beer is brewed with boatloads of Amarillo hops",
                    ImgPath = "/Images/GumballHeadWheat.png",
                    CategoryId = 3
                },

                 new Beer()
                 {
                     BeerId = 9,
                     Name = "Snake Venom",
                     Abv = 67.50f,
                     Brewery = "BrewMeister",
                     Rating = 5.00f,
                     Description = "In certain countries, Brewmeister's Snake Venom beer isn't actually a beer because of hits insanely high ABV. This barley beer has an incredibly high proof that makes it rival, if not exceed, many liquors out there. At around $50 per bottle, this insanely powerful beer will burn a hole in your wallet - and possibly your throat.",
                     ImgPath = "/Images/SnakeVenom.png",
                     CategoryId = 4
                 },

                 new Beer()
                 {
                     BeerId = 10,
                     Name = "Sink The Bismarck",
                     Abv = 41.00f,
                     Brewery = "Brew Dog",
                     Rating = 5.00f,
                     Description = "It takes a lot to be called one of Scotland's strongest beers, but this high-ABV Imperial IPA definitely does the trick. BrewDog actually made this beer line as a way of showing their brewing prowess and outdoing competitors in the fight to have one of the strongest beers in the world.",
                     ImgPath = "/Images/SinkBismark.png",
                     CategoryId = 4
                 },

                  new Beer()
                  {
                      BeerId = 11,
                      Name = "Utopias",
                      Abv = 29.00f,
                      Brewery = "Samuel Adams",
                      Rating = 5.00f,
                      Description = "Out of all the beers on this list, buying this one is often the easiest and most cost-effective. Sam Adams, after all, is a mainstream beer brand - and it's one of the few mainstream beer brands that's also known for producing special edition batches. ",
                      ImgPath = "/Images/SamAdamsUtopia.png",
                      CategoryId = 4
                  });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 1,
                    UserRating = 4,
                    UserText = "This rocks...nuff said ya dig it.",
                    BeerId = 1
                });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 2,
                    UserRating = 5,
                    UserText = "A very creative beer with a unique, beautiful, and delicious hops profile. Nice dry, balanced base beer with enough malt backbone to support but not crowd the hops, interesting hops profile that showcases both piney, resinous, dank flavors with classic American citrus notes and tropical fruit hops flavors, and a very clean fermentation profile to boot. Extremely drinkable thanks to lower bitterness but no doubt about it, the hops are the belle of the ball. Buy by the case—it’s an excellent example of the style.",
                    BeerId = 1
                });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 3,
                    UserRating = 3,
                    UserText = "Caramel background, the smallest hint of tropical fruit, lots of pine and citrus. A good example of what it is, but what it is is still a boring, rather one-note IPA.",
                    BeerId = 2
                });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 4,
                    UserRating = 4,
                    UserText = "Slammed me like a hibbidy bibiddy hop",
                    BeerId = 2
                });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 5,
                    UserRating = 1,
                    UserText = "So that's what a hobo tastes like...",
                    BeerId = 3
                });

            modelBuilder.Entity<UserReview>().HasData(
                new UserReview()
                {
                    UserReviewId = 6,
                    UserRating = 3,
                    UserText = "This is a full-bodied rendition of the style with carbonation at the lower end of the style spectrum, while the alcohol content was quite evident -- contributing to this beer's warming presence. Very true to form, this Double IPA stands tall and should be considered for consumption as a fine example of the style.",
                    BeerId = 3
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
