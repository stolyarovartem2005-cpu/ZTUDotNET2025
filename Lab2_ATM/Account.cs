using System;

namespace Lab2_ATM
{
    public class Account
    {
        public string CardNumber { get; }
        public string OwnerName { get; }
        private string PinCode { get; }
        public decimal Balance { get; private set; }

        public Account(string cardNumber, string ownerName, string pinCode, decimal initialBalance)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            PinCode = pinCode;
            Balance = initialBalance;
        }

        public bool CheckPin(string pin)
        {
            return PinCode == pin;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false;

            if (Balance < amount)
                return false;

            Balance -= amount;
            return true;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            Balance += amount;
            return true;
        }

        public bool TransferTo(Account targetAccount, decimal amount)
        {
            if (targetAccount == null)
                return false;

            if (!Withdraw(amount))
                return false;

            targetAccount.Deposit(amount);
            return true;
        }
    }
}
