using System;
namespace ATM
{
    public class Client:Account
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        //public Account _account { get; set; }


        public void AccessAccount()
        {
            Console.WriteLine("******Welcome to SU Banking******");
            Console.WriteLine("Please enter your PIN (Make sure no one is looking!)");
            int enteredPin = Convert.ToInt32(Console.ReadLine());

            if(enteredPin == _pinNumber)
            {
                Console.WriteLine("Welcome {0} {1}",_firstName, _lastName);
                GoToChecking();
            }
            else
            {
                Console.WriteLine("Sorry wrong pin ...CALLING SECURITY!");
            }

        }
    }
}
