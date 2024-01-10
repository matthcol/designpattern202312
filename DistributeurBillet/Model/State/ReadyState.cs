using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    public class ReadyState : AbstractATMState
    {
       
        public override void InsertCard(ATM atm, Card card)
        {
            Console.WriteLine($"Insert card in ready state: {card}");
            atm.Card = card;
            // next state
            atm.State = NonAuthenticatedClientState.Instance();
        }

        public static ReadyState Instance() {
            if (_instance == null)
            {
                _instance = new ReadyState();
            }
            return _instance;
        }

        private static ReadyState? _instance = null;

        private ReadyState() { }
    }
}
