using System;
namespace ATM
{
    public class Account
    {
        public int _pinNumber { get; set; }
        public CheckingAccount _chekingAccount { get; set; }

        public void GoToChecking()
        {
            char choise = 'a';
            var test = new CheckingAccount();
            while (choise != 'e')
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Press w to Withdraw");
                Console.WriteLine("Press d to Deposit");
                Console.WriteLine("Press p to Print all transactions");
                Console.WriteLine("Press e to exit");
                choise = Convert.ToChar(Console.ReadLine());
                if (choise == 'w')
                {
                    Console.Clear();
                    test.WithDraw();
                }
                else if (choise == 'd')
                {
                    Console.Clear();
                    test.Deposit();
                }
                else if (choise == 'p')
                {
                    //Console.Clear();
                    test.PrintTransactions();
                }

                
            }
        }
        
    }
}
