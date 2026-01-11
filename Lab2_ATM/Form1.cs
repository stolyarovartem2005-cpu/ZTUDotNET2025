using System;
using System.Windows.Forms;

namespace Lab2_ATM
{
    public partial class Form1 : Form
    {
        private Bank _bank;
        private AutomatedTellerMachine _atm;

        public Form1()
        {
            InitializeComponent();
            InitializeAtm();
            SubscribeToEvents();
            RunDemo();
        }

        private void InitializeAtm()
        {
            _bank = new Bank("ZTUBank");

            var acc1 = new Account("1111222233334444", "Ivan Ivanov", "1234", 5000);
            var acc2 = new Account("5555666677778888", "Petro Petrenko", "4321", 3000);

            _bank.AddAccount(acc1);
            _bank.AddAccount(acc2);

            _atm = new AutomatedTellerMachine("ATM-01", "Zhytomyr", 10000, _bank);
        }

        private void SubscribeToEvents()
        {
            _atm.AuthenticationPerformed += OnAtmEvent;
            _atm.BalanceChecked += OnAtmEvent;
            _atm.CashWithdrawn += OnAtmEvent;
            _atm.CashDeposited += OnAtmEvent;
            _atm.MoneyTransferred += OnAtmEvent;
        }

        private void OnAtmEvent(object sender, TransactionEventArgs e)
        {
            MessageBox.Show(e.Message, e.Operation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RunDemo()
        {
            _atm.Authenticate("1111222233334444", "1234");
            _atm.CheckBalance();
            _atm.Withdraw(1000);
            _atm.Deposit(500);
            _atm.Transfer("5555666677778888", 700);
        }
    }
}
