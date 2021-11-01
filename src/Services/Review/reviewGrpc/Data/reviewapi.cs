
using Microsoft.EntityFrameworkCore;
using reviewGrpc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewGrpc.Data
{
    public class reviewapi:DbContext
    {
        public reviewapi(DbContextOptions<reviewapi> options) : base(options)
        {

        }
        public DbSet<LoginReview> loginReviews { get; set; }
        public DbSet<Review> reviews { get; set; }

    }
}
