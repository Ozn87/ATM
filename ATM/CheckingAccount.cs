using System;
using System.Collections.Generic;

namespace ATM
{
    public class CheckingAccount
    {
        public int _checkingNumber { get; set; }
        public double _balance { get; set; }
        public List<Transaction> _history = new List<Transaction>();

        public void WithDraw()
        {
            Random rng = new Random();
            int transID = rng.Next(0, 100000);
            Console.WriteLine("You have ${0} in your account",_balance);
            Console.WriteLine("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            double oldValance = _balance;
            _balance = _balance - amount;
            _history.Add(new Transaction(transID, 'W',DateTime.Today, amount,oldValance, _balance));
            Console.WriteLine("Here is a summary of your transaction:");
            Console.WriteLine("New balance: ${0}",_balance);
            Console.WriteLine("Amount Withdrawn: ${0}", amount);
            Console.WriteLine("Transaction date: {0}",DateTime.Today);
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();


        }

        public void Deposit()
        {
            Random rng = new Random();
            int transID = rng.Next(0, 100000);
            Console.WriteLine("You have ${0} in your account", _balance);
            Console.WriteLine("Enter amount to Deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            double oldValance = _balance;
            _balance = _balance + amount;
            _history.Add(new Transaction(transID, 'D', DateTime.Today, amount, oldValance, _balance));
            Console.WriteLine("Here is a summary of your transaction:");
            Console.WriteLine("New balance: ${0}", _balance);
            Console.WriteLine("Amount Deposited: ${0}", amount);
            Console.WriteLine("Transaction date: {0}", DateTime.Today);
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();

        }

        public void PrintTransactions()
        {
            Console.Clear();
            foreach (var transaction in _history)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Transaction Date: {0}",transaction._transactionDate);
                Console.WriteLine("Transaction Type: {0}",transaction._movementType);
                Console.WriteLine("Previews Valance: $ {0}", transaction._oldValance);
                Console.WriteLine("Transaction Amount: $ {0}", transaction._amount);
                Console.WriteLine("Balance after Transaction:$ {0}", transaction._newValance);
                Console.WriteLine("----------------------------------");
                
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
