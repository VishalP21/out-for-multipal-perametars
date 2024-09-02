using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_for_multipal_perametars
{
    public class employee
    {
        public int sum(int a, int b, out int c)
        {
            c = a + b;
            return a - b;
        }
    }
}
