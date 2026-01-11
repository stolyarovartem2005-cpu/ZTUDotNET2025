using System;

namespace Lab2_ATM
{
    public class AutomatedTellerMachine
    {
        public string AtmId { get; }
        public string Address { get; }
        public decimal CashAvailable { get; private set; }

        private readonly Bank _bank;
        private Account _currentAccount;

        public delegate void TransactionHandler(object sender, TransactionEventArgs e);

        public event TransactionHandler AuthenticationPerformed;
        public event TransactionHandler BalanceChecked;
        public event TransactionHandler CashWithdrawn;
        public event TransactionHandler CashDeposited;
        public event TransactionHandler MoneyTransferred;

        public AutomatedTellerMachine(string atmId, string address, decimal cashAvailable, Bank bank)
        {
            AtmId = atmId;
            Address = address;
            CashAvailable = cashAvailable;
            _bank = bank;
        }

        public bool Authenticate(string cardNumber, string pin)
        {
            var account = _bank.GetAccount(cardNumber);

            if (account != null && account.CheckPin(pin))
            {
                _currentAccount = account;
                AuthenticationPerformed?.Invoke(this,
                    new TransactionEventArgs("Authentication", cardNumber, 0, "Аутентифікація успішна"));
                return true;
            }

            AuthenticationPerformed?.Invoke(this,
                new TransactionEventArgs("Authentication", cardNumber, 0, "Помилка аутентифікації"));
            return false;
        }

        public decimal CheckBalance()
        {
            if (_currentAccount == null)
                return 0;

            BalanceChecked?.Invoke(this,
                new TransactionEventArgs("BalanceCheck", _currentAccount.CardNumber, _currentAccount.Balance,
                    "Перегляд балансу"));

            return _currentAccount.Balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (_currentAccount == null)
                return false;

            if (amount > CashAvailable)
                return false;

            if (_currentAccount.Withdraw(amount))
            {
                CashAvailable -= amount;
                CashWithdrawn?.Invoke(this,
                    new TransactionEventArgs("Withdraw", _currentAccount.CardNumber, amount,
                        $"Знято {amount} грн"));
                return true;
            }

            return false;
        }

        public bool Deposit(decimal amount)
        {
            if (_currentAccount == null)
                return false;

            if (_currentAccount.Deposit(amount))
            {
                CashDeposited?.Invoke(this,
                    new TransactionEventArgs("Deposit", _currentAccount.CardNumber, amount,
                        $"Зараховано {amount} грн"));
                return true;
            }

            return false;
        }

        public bool Transfer(string targetCardNumber, decimal amount)
        {
            if (_currentAccount == null)
                return false;

            var targetAccount = _bank.GetAccount(targetCardNumber);

            if (targetAccount == null)
                return false;

            if (_currentAccount.TransferTo(targetAccount, amount))
            {
                MoneyTransferred?.Invoke(this,
                    new TransactionEventArgs("Transfer", _currentAccount.CardNumber, amount,
                        $"Переказ {amount} грн на картку {targetCardNumber}"));
                return true;
            }

            return false;
        }
    }
}
