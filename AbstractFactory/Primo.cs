using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Primo : IDumb
    {
        string IDumb.getName()
        {
            string name = "Primo";
            Console.WriteLine(name);
            return name;
        }
    }
}
