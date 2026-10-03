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
        struct BankCardInformation
        {
            public int number;
            public BankCards bankCards;
            public int balance;
        }
        public static void Main()
        {
            BankCardInformation Jack = new BankCardInformation();
            Jack.number = 12;
            Jack.bankCards = BankCards.current;
            Jack.balance = 1000;
            Console.WriteLine($"Баланс: {Jack.balance}, номер карты: {Jack.bankCards}, тип: {Jack.number}");

        }
    }
}