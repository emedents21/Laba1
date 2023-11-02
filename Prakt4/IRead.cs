using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prakt4
{
    public interface IRead
    {
        void read(string path, ArrayAB a);
    }
}
