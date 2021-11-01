using Microsoft.EntityFrameworkCore;
using reviewGrpc.Helper;
using reviewGrpc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewGrpc.Data.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly reviewapi _reviewapi;

        public ReviewRepository(reviewapi reviewapi)
        {
            _reviewapi = reviewapi;
        }
        public async void addReview(LoginReview loginReview)
        {
            _reviewapi.reviews.Add(loginReview.ReviewID);
            _reviewapi.SaveChanges();
            var review = await _reviewapi.reviews.Select(t => t).LastOrDefaultAsync();
            loginReview.ReviewID.Id = review.Id;
            _reviewapi.loginReviews.Add(loginReview);
            _reviewapi.SaveChanges();
        }

        public async Task<Pagedlist<Review>> Getreviews(UserParams userParams, int productid)
        {
            var review = _reviewapi.loginReviews.Where(t => t.ProductID == productid).Select(t => t.ReviewID);
            return await Pagedlist<Review>.CreateAsync(review, userParams.PageNumber, userParams.pageSize);
        }
    }
}
