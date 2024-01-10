namespace DistributeurBillet.Model
{
    public class Card
    {
        public const int MAX_ATTEMPTS = 3;
        public int Balance { get; set; }
        public int CurrentSpendingLimit {  get; set; }
        public int FailedAttempts { get; set; } = 0;
        public int SecretCode { get; set; }

        public override String ToString()
        {
            return $"Card[balance={Balance} ; current spending limit={CurrentSpendingLimit} ; faild attempts={FailedAttempts}]"; 
        }
    }
}