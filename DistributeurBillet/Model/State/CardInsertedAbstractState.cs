using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBillet.Model.State
{
    // macro state
    public abstract class CardInsertedAbstractState: AbstractATMState
    {
        public override void CancelOperation(ATM atm)
        {
            atm.RestituteCard();
            // next state Ready
            atm.State = ReadyState.Instance();
        }
    }
}
