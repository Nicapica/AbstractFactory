//Author: Nicholas Pica
//FileName: PhoneTypeChecker.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufactures manu;

        PhoneTypeChecker(Manufactures manu)
        {
            if (manu == Manufactures.Samsung)
            {
                SamsungFactory s = new SamsungFactory();
                factory = s;
                CheckProducts(factory);
            }
            else if (manu == Manufactures.HTC)
            {
                HTCFactory htc = new HTCFactory();
                factory = htc;
                CheckProducts(factory);
            }
            else if (manu == Manufactures.Nokia)
            {
                NokiaFactory n = new NokiaFactory();
                factory = n;
                CheckProducts(factory);
            }
        }

        void CheckProducts(IPhoneFactory factory)
        {
            factory.GetSmart();
            factory.GetDumb();
        }
    }
}
