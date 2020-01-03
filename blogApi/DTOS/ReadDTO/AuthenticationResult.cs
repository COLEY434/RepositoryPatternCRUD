using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.ReadDTO
{
    public class AuthenticationResult
    {
        public int? UserId { get; set; }
        public string Token { get; set; }

        public DateTime? ExpiresIn { get; set; }

        public bool Success { get; set; }

        public string ErrorMesage { get; set; }

        public string Username { get; set; }
    }
}
