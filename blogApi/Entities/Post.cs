using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Entities
{
    public class Post
    {
        public long Id { get; set; }

        public long user_id { get; set; }

        public string message { get; set; }

        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }
    }
}
