using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChiroAPI.Models
{
    public class Leiding
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public int Leeftheid { get; set; }
        public string Groep { get; set; }
        public string Email { get; set; }
        public int JaarLeiding { get; set; }
    }
}
