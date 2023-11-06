using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    internal class Artist
    {
        public int ArtistId { get; set; }
       
        public string Surname { get; set; }
        public string Name { get; set; }
       
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
}
