using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Asha : IDumb
    {
        string IDumb.getName()
        {
            string name = "Asha";
            Console.WriteLine(name);
            return name;
        }
    }
}
