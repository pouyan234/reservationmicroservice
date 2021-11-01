

using reviewGrpc.Helper;
using reviewGrpc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewGrpc.Data.Repository
{
   public interface IReviewRepository
    {
        public void addReview(LoginReview loginReview);
        public Task<Pagedlist<Review>> Getreviews(UserParams userParams, int productid);
    }
}
