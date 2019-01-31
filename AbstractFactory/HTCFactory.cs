//Author: Nicholas Pica
//FileName: HTCFactory.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HTCFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart nPhone = new Titan();
            nPhone.getName();
            return nPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb nPhone = new Primo();
            nPhone.getName();
            return nPhone;
        }
    }
}
