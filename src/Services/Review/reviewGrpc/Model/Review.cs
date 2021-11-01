using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviewGrpc.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Explain { get; set; }
        public int Rate { get; set; }
    }
}
