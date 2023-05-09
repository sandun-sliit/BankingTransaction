namespace BankingTransaction.Models
{
    public class Account
    {
        public int accId { get; set; }
        public int accNo { get; set; }
        public string type { get; set; } = string.Empty;
        public float balance { get; set; }

        public Customer customer { get; set; }
        public int customerId { get; set; }
        public List<Transaction> transactions { get; set; }

    }
}
