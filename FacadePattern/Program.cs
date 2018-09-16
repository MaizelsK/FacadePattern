using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChefCooker chefCooker = new ChefCooker();
            DrinkMachine drinkMachine = new DrinkMachine();
            FryerMachine fryerMachine = new FryerMachine();
            Cashier cashier = new Cashier();

            KfcFacade kfcFacade = new KfcFacade(chefCooker, fryerMachine, drinkMachine, cashier);
            Customer customer = new Customer();

            customer.OrderTwisterCombo(kfcFacade);

            Console.ReadLine();
        }
    }
}
