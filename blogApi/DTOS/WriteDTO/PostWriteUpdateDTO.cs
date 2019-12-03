using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.WriteDTO
{
    public class PostWriteUpdateDTO
    {
        [Required]
        public int post_Id { get; set; }

        [Required]
        public string message { get; set; }
    }
}
