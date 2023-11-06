using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    internal class Musics
    {
        public int MusicId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int CategoryId { get; set; }
    }
}
