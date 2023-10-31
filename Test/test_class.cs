using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class test_class
    {
        public test_class()
        {
            try
            {
                int val = 0;
                Console.WriteLine(3 / val);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
