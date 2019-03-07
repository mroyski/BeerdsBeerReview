using System.Collections.Generic;
using ReviewsSites.Models;

namespace ReviewsSites.Repositories
{
    public interface IUserReviewRepository
    {
        UserReview GetById(int Id);
        IEnumerable<UserReview> GetAll();
        void Create(UserReview userReview);
        void Edit(UserReview userReview);
        void Delete(UserReview userReview);      
    }
}
