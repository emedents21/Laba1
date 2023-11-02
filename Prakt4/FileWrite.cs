using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Prakt4
{
    public class FileWrite : IWrite
    {
        public void write(string path, ArrayAB a)
        {
            using(StreamWriter  sw = new StreamWriter(path, false, Encoding.Default)) 
            {
                foreach(var item in a.b)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
    }
}
