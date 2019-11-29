using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.ReadDTO
{
    public class GetPostReadDTO
    {
        public int Id { get; set; }

        [Required]
        public string message { get; set; }

        public string username { get; set; }

        public string img_url { get; set; }

        [Required]
        public DateTime date_posted { get; set; }

        public DateTime? date_updated { get; set; }
    }
}
