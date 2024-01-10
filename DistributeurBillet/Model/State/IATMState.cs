using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    public interface IATMState
    {
        void InsertCard(ATM atm, Card card);


        void Authenticate(ATM atm, int code);

        void AskAmount(ATM atm, int amount);

        void CancelOperation(ATM atm);
    }
}