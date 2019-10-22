using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.WriteDTO
{
    public class UserWriteDTO
    {

        [Required]
        [MaxLength(50)]
        public string surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string firstname { get; set; }

        [Required]
        [MaxLength(10)]
        public string gender { get; set; }

        [Required]
        [MaxLength(15)]
        public string state { get; set; }

        public int age { get; set; }

    }
}
