using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Files
{
    public abstract class MediaObject : ImediaObject
    {

        public string FileName {get; set;}
        public double FileSize { get; set; }
        public DateTime Creation { get; set; }
           

        
        
    }
}
