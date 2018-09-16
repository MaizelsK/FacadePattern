using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class KfcFacade
    {
        private Cashier cashier;
        private ChefCooker chefCooker;
        private FryerMachine fryerMachine;
        private DrinkMachine drinkMachine;

        public KfcFacade(ChefCooker chefCooker, FryerMachine fryerMachine, DrinkMachine drinkMachine, Cashier cashier)
        {
            this.cashier = cashier;
            this.chefCooker = chefCooker;
            this.fryerMachine = fryerMachine;
            this.drinkMachine = drinkMachine;
        }

        public void MakeTwisterCombo()
        {
            cashier.SayOrderReceived();

            chefCooker.MakeTwister();
            fryerMachine.MakeMediumFrenchFries();
            drinkMachine.MakeMediumCocaCola();

            cashier.SayOrderReady();
        }
    }
}
