using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Lumia : ISmart
    {
        string ISmart.getName()
        {
            string name = "Lumia";
            Console.WriteLine(name);
            return name;
        }
    }
}
