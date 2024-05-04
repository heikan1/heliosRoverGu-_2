using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heliosRoverGuı_2
{
    internal class Feeds
    {
        public DateTime created_at { get; set; }
        public int entry_id { get; set; }
        
        public float field1 { get; set; }
        public float field2 { get; set; }
        public string field3 { get; set; } = string.Empty;

    }
}
