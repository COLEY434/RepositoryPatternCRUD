using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Entities
{
    public class users
    {
        [Key]
        public int userId { get; set; }

        [MaxLength(20)]
        public string surname { get; set; }
         
        [MaxLength(20)]
        public string firstname { get; set; }

        [MaxLength(50)]
        public string username { get; set; }

        [MaxLength(10)]
        public string  gender { get; set; }

        [MaxLength(10)]
        public string state { get; set; }

        [MaxLength(30)]
        public string country { get; set; }

        public int? age { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        public DateTime? updated_at { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public string img_url { get; set; }

        public DateTime? last_logged_In { get; set; }
    }
}
