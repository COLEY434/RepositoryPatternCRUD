using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.ReadDTO
{
    public class AuthFailedResponse
    {
        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
    }
}
