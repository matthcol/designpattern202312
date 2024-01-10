using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistributeurBillet.Model.State;

namespace DistributeurBillet.Model
{
    public class ATM
    {
        // TODO: visibility setter to states only
        public IATMState State { get; set; } = ReadyState.Instance();
        public Card? Card { get; set; }

        public void InsertCard(Card card)
        {
            State.InsertCard(this, card);
        }

        public void Authenticate(int code)
        {
            State.Authenticate(this, code);
        }

        public void AskAmount(int amount)
        {
            State.AskAmount(this, amount);
        }

        public void CancelOperation()
        {
            State.CancelOperation(this);

        }

        // TODO: visibility to states only

        public Card? RestituteCard() {
            Console.WriteLine($"Restitute card: {Card}");
            var card =  Card;
            Card = null;
            return card;
        }

        public void SwallowCard()
        {
            Console.WriteLine($"Swallow card: {Card}");
            // TODO: swallow (put in a box ...)
            Card = null;
        }

        public int DeliverMoney(int amount)
        {
            Console.WriteLine($"Deliver money: {amount:C}");
            return amount;
        }
    }
}
