using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.ReviewsRepositories
{
    public class ReviewsRepository
    {
        public Dictionary<int, Reviews> reviewList = new Dictionary<int, Reviews>()
            {
                {1, new Reviews() {Id = 1, Beer = "Zombie Dust", Abv = 6.20f, Brewery = "Three Floyds", Rating = 4.8f, Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", ImgPath = "/Images/Zombiedust.png" } },
                {2, new Reviews() {Id = 2, Beer = "Hopslam", Abv = 10.00f, Brewery = "Bells", Rating = 4.6f, Description = "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", ImgPath = "/Images/Hopslam.png"} },
                {3, new Reviews() {Id = 3, Beer = "Boomsauce", Abv = 7.80f, Brewery = "Lord Hobo", Rating = 3.0f, Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", ImgPath = "/Images/Boomsauce.png"} }
            };

        public IEnumerable<Reviews> GetAll()
        {
            return reviewList.Values.ToList();
        }

        public object GetById(int id)
        {
            return reviewList[id];
        }
    }
}

