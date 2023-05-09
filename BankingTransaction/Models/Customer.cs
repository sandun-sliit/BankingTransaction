namespace BankingTransaction.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; } = string.Empty;
        public string customerEmail { get; set; } = string.Empty;
        public string customerPhone { get; set; } = string.Empty;
        public string customerNIC { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set;}
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }

        public Account account { get; set; }
        public int accountId { get; set; }

    }
}
