using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    public class NonAuthenticatedClientState : CardInsertedAbstractState
    {

        

        public override void Authenticate(ATM atm, int code)
        {
            Console.WriteLine($"Authenticate attempt in non authenticated state");
            if (atm.Card?.SecretCode == code)
            {
                Console.WriteLine("\t=> SUCCESS");
                atm.Card.FailedAttempts = 0;
                // TODO: next state AuthenticatedClient
                atm.State = AuthenticatedClientState.Instance();
            }
            else
            {                
                atm.Card.FailedAttempts++;
                Console.WriteLine($"\t=> FAIL, attempts remaining: {atm.Card.FailedAttempts}");
                if (atm.Card.FailedAttempts == Card.MAX_ATTEMPTS)
                {
                    atm.SwallowCard();
                    // next state Ready
                    atm.State = ReadyState.Instance();
                } 
                // else: stay in this state
            }
        }


        public static NonAuthenticatedClientState Instance() { 
            if (_instance == null)
            {
                _instance = new NonAuthenticatedClientState();
            }
            return _instance;
        }

        private static NonAuthenticatedClientState? _instance = null;
        private NonAuthenticatedClientState() { }
    }
}
