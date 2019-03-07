using ReviewsSites.Models;
using System.Collections.Generic;
using System.Linq;

namespace ReviewsSites.Repositories
{
    public class UserReviewRepository : IUserReviewRepository
    {
        ReviewsContext db;

        public UserReviewRepository(ReviewsContext db)
        {
            this.db = db;
        }

        public UserReview GetById(int Id)
        {
            return db.UserReviews.Single(UserReview => UserReview.UserReviewId == Id);
        }

        public IEnumerable<UserReview> GetAll()
        {
            return db.UserReviews.ToList();
        }

        public void Create(UserReview userReview)
        {

            db.UserReviews.Add(userReview);
            db.SaveChanges();
        }

        public void Edit(UserReview userReview)
        {
            db.UserReviews.Update(userReview);
            db.SaveChanges();
        }

        public void Delete(UserReview userReview)
        {
            db.UserReviews.Remove(userReview);
            db.SaveChanges();
        }
    }
}
