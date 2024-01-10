using DistributeurBillet.Model;

Console.WriteLine($"Max attempts:{Card.MAX_ATTEMPTS}");

ATM atm = new();
Card card = new()
{
    Balance = 500,
    CurrentSpendingLimit = 800,
    SecretCode = 1234
};
Console.WriteLine($"Start with card: {card}");

atm.AskAmount(10_000);
atm.InsertCard(card);
atm.AskAmount(10_000);
atm.Authenticate(4321);
atm.Authenticate(1111);
Console.WriteLine($"card after some fails: {card}");
atm.Authenticate(1234);
atm.AskAmount(10_000);
atm.AskAmount(400);
