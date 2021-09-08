using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            var osiris = new Client();
            osiris._firstName = "osiris";
            osiris._lastName = "loera";
            osiris._pinNumber = 123;

            osiris.AccessAccount();
            
        }
    }
}
