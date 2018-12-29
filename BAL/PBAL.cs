using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PBAL
    {
        public bool Update(string a, string b, string c)
        {
            return new PDAL().update(a, b, c);
        }
        public bool Update2(string a, string b, string c)
        {
            return new PDAL().update2(a, b, c);
        }
        public bool Delete(string a)
        {
            return new PDAL().delete(a);
        }
        public bool Delete2(string a)
        {
            return new PDAL().delete2(a);
        }
    }
}
