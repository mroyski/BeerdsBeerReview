namespace ReviewsSites.Models
{
    public class UserReview
    {
        public int UserReviewId { get; set; }
        public int UserRating { get; set; }
        public string UserText { get; set; }

        public int BeerId { get; set; }
    }
}
