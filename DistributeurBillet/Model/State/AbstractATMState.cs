using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    public abstract class AbstractATMState : IATMState
    {
        public virtual void AskAmount(ATM atm, int amount)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Idle Operation: {nameof(AskAmount)}");
        }

        public virtual void Authenticate(ATM atm, int code)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Idle Operation: {nameof(Authenticate)}");
        }

        public virtual void CancelOperation(ATM atm)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Idle Operation: {nameof(CancelOperation)}");
        }

        public virtual void InsertCard(ATM atm, Card card)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Idle Operation: {nameof(InsertCard)}");
        }
    }
}
