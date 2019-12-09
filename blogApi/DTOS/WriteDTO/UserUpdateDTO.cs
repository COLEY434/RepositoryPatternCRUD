using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.WriteDTO
{
    public class UserUpdateDTO
    {
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }



    }
}
