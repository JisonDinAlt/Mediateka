using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Files
{
    public interface ImediaObject
    {
        string FileName { get; }
        double FileSize { get; }
        DateTime Creation { get; } 

    }
}
