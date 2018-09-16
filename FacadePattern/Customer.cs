using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Customer
    {
        public void OrderTwisterCombo(KfcFacade kfc)
        {
            kfc.MakeTwisterCombo();
        }
    }
}
