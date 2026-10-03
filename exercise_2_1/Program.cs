using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Exercise_2_1
    {
        enum BankCards
        {
            current,
            saving
        }
        public static void Main()
        {
            
            BankCards myBankCard = BankCards.current;
            Console.WriteLine(myBankCard);
        }
    }
}