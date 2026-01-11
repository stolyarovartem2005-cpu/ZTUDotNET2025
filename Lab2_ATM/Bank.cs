using System;
using System.Collections.Generic;

namespace Lab2_ATM
{
    public class Bank
    {
        public string Name { get; }

        private readonly List<Account> _accounts = new List<Account>();

        public Bank(string name)
        {
            Name = name;
        }

        public void AddAccount(Account account)
        {
            if (account == null)
                return;

            _accounts.Add(account);
        }

        public Account GetAccount(string cardNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.CardNumber == cardNumber)
                    return account;
            }

            return null;
        }
    }
}
