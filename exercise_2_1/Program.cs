using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class exercise_2_1
    {
        enum bankCards
        {
            current,
            saving
        }
        public static void Main()
        {
            
            bankCards myBankCard = bankCards.current;
            Console.WriteLine(myBankCard);
        }
    }
}