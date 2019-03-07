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
