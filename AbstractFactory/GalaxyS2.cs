using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GalaxyS2 : ISmart
    {
        string ISmart.getName()
        {
            string name = "GalaxyS2";
            Console.WriteLine(name);
            return name;
        }
    }
}
