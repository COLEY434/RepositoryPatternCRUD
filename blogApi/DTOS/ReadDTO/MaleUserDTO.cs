using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.DTOS.ReadDTO
{
    public class MaleUserDTO
    {
        public long Id { get; set; }

        public string gender { get; set; }

        public int? age { get; set; }

        public string firstname { get; set; }
    }
}
