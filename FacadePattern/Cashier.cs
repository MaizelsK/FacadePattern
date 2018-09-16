using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Cashier
    {
        public void SayOrderReady()
        {
            Console.WriteLine("Ваш заказ готов!");
        }

        public void SayOrderReceived()
        {
            Console.WriteLine("Ваш заказ принят!");
        }
    }
}
