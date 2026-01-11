using System;

namespace Lab2_ATM
{
    public class TransactionEventArgs : EventArgs
    {
        public string Operation { get; }
        public string CardNumber { get; }
        public decimal Amount { get; }
        public string Message { get; }

        public TransactionEventArgs(string operation, string cardNumber, decimal amount, string message)
        {
            Operation = operation;
            CardNumber = cardNumber;
            Amount = amount;
            Message = message;
        }
    }
}
