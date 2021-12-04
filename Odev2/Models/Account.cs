using System.Collections.Generic;

namespace Odev2.Models
{
    public class Account : IBankAccount
    {
        public int AccountNumber { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string AccountType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public decimal Balance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<string> Transactions { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        void Deposit()
        {

        }

        void Withdraw()
        {

        }
    }
}