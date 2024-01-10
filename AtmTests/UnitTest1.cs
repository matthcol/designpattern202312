using DistributeurBillet.Model;
using DistributeurBillet.Model.State;

namespace AtmTests
{
    public class NonAuthenticatedClientStateTests
    {
        private ATM _atm;

        [SetUp]
        public void Setup()
        {
            _atm = new();
            _atm.State = NonAuthenticatedClientState.Instance();
        }

        [Test]
        public void AskAmountTest_IsIdle()
        {
            //
            Card card = new()
            {
                Balance = 500,
                CurrentSpendingLimit = 800,
                SecretCode = 1234
            };
            _atm.Card = card;
            // 
            _atm.AskAmount(300);
            // Idle state
            Assert.That(_atm.State, Is.SameAs(NonAuthenticatedClientState.Instance()));
            // Card not affected
            Assert.That(card.Balance, Is.EqualTo(500));
            Assert.That(card.CurrentSpendingLimit, Is.EqualTo(800));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AuthenticateTest_WhenSuccess(int nb)
        {
            //
            Card card = new()
            {
                Balance = 500,
                CurrentSpendingLimit = 800,
                SecretCode = 1234,
                FailedAttempts = nb,
            };
            _atm.Card = card;
            //
            _atm.Authenticate(1234);
            //
            Assert.That(_atm.State, Is.SameAs(AuthenticatedClientState.Instance()));
            Assert.That(card.FailedAttempts, Is.EqualTo(0));
        }

        [TestCase(0)]
        [TestCase(1)]
        public void AuthenticateTest_WhenFail(int nb)
        {
            //
            Card card = new()
            {
                Balance = 500,
                CurrentSpendingLimit = 800,
                SecretCode = 1234,
                FailedAttempts = nb,
            };
            _atm.Card = card;
            //
            _atm.Authenticate(4321);
            //
            Assert.That(_atm.State, Is.SameAs(NonAuthenticatedClientState.Instance()));
            Assert.That(card.FailedAttempts, Is.EqualTo(nb+1));
        }
    }
}