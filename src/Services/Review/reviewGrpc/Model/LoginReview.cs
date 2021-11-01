using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewGrpc.Model
{
    public class LoginReview
    {
        public int LoginReviewID { get; set; }
        public int LoginID { get; set; }
        public Review ReviewID { get; set; }
        public int ProductID { get; set; }
    }
}
