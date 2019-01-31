//Author: Nicholas Pica
//FileName: NokiaFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class NokiaFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart nPhone = new Lumia();
            nPhone.getName();
            return nPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb nPhone = new Asha();
            nPhone.getName();
            return nPhone;
        }
    }
}
