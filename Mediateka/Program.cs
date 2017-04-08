using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                BasicFile file1 = new BasicFile("Картинка1", 100, "jpg");
                file1.rewrite();
                

            }
        }

        public  class BasicFile
        {

            public string FileName
            {
                get;
                protected set;
            }

            public double FileSize
            {
                get;
                protected set;
            }

            public string FileType
            {
                get;
                protected set;
            }

            public string FileUlr
            {
                get;
                protected set;
            }

            public BasicFile(string N, double S, string T)
            {
                FileName = N;
                FileSize = S;
                FileType = T;

            }
            public void  rewrite()
            {
                Console.WriteLine("Название файла - {0}, размер файла - {1}, тип фала - {2} ", FileName, FileSize, FileType);

            }
        }

        

    }
}
