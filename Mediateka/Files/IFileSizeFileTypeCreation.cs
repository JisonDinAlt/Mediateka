using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Files
{
    interface IFileSizeFileTypeCreation
    {
        double FileSize { get; }
        string FileType { get; }
        DateTime Creation { get; } 

    }
}
