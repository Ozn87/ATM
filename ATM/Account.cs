using System;
namespace ATM
{
    public class Account
    {
        public int _pinNumber { get; set; }
        public CheckingAccount _chekingAccount { get; set; }

        public void GoToChecking()
        {
            int count = 0;
            var test = new CheckingAccount();
            while (count < 4)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Press w to Withdraw");
                Console.WriteLine("Press d to Deposit");
                Console.WriteLine("Press p to Print all transactions");
                char choise = Convert.ToChar(Console.ReadLine());
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

                count++;
            }
        }
        
    }
}
