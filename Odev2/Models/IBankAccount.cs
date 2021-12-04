using System.Collections.Generic;

namespace Odev2.Models
{
    public interface IBankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }

        public List<string> Transactions { get; set; }

    }
}