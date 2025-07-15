using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrackSystem
{
    public class DevLogEntry
    {
        public string project { get; set; }
        public string author { get; set; }
        public DateTime created_at { get; set; }
        public string type { get; set; } 
        public string? subtype { get; set; } 
        public string file { get; set; }
        public string note { get; set; }
    }
}
