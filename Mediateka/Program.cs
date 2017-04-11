using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediateka.Files;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            MediatekaObject mediatekatest = new MediatekaObject();


            mediatekatest.Add(new AudioFile()
            {
                FileName = "Track1",
                FileSize = 100,
                Creation = new DateTime(2001, 10, 10),
                Bitrate = 128,
            });




        }
 




        

       



    }
}
