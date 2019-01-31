//Author: Nicholas Pica
//FileName: SamsungFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart nPhone = new GalaxyS2();
            nPhone.getName();
            return nPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb nPhone = new Genie();
            nPhone.getName();
            return nPhone;
        }
    }
}
