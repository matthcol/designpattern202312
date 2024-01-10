using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    public class AuthenticatedClientState : CardInsertedAbstractState
    {
        public override void AskAmount(ATM atm, int amount)
        {
            Console.WriteLine($"Ask amount in authenticated state: {amount}");
            if ((amount <= atm.Card?.Balance) && (amount <= atm.Card?.CurrentSpendingLimit))
            {
                Console.WriteLine("\t=> SUCCESS");
                atm.Card.Balance -= amount;
                atm.Card.CurrentSpendingLimit -= amount;
                atm.DeliverMoney(amount);
                atm.RestituteCard();
                // next state Ready
                atm.State = ReadyState.Instance();
            } 
            else
            {
                // stay in this state, notify wrong amount
                Console.WriteLine("\t=> FAIL");
            }
        }

 

     

        // singleton:
        public static AuthenticatedClientState Instance()
        {
            if (_instance == null)
            {
                _instance = new AuthenticatedClientState();
            }
            return _instance;
        }

        private static AuthenticatedClientState? _instance = null;
        private AuthenticatedClientState() { }
    }

}
