using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Entities
{
    public class Replies
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string reply_message { get; set; }

        [Required]
        public int user_Id { get; set; }

        [Required]
        public int post_Id { get; set; }
        
        [Required]
        public DateTime created_at { get; set; }

        public DateTime? updated_at { get; set; }
    }
}
