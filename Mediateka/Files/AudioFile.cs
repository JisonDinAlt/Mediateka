using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Files
{
    class AudioFile : BasicFile, IFileSizeFileTypeCreation

    {
        public string FileName { get; set; } 
        public double FileSize {get; set; }
        public string FileType { get; set; }
        public DateTime Creation { get; set; }

        
    }
}
