using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Exercise_2_1
    {
        enum College
        {
            KFU,
            KAI,
            KChTI
        }
        struct memberOfCollege
        {
            public string name;
            public College college;
        }
        public static void Main()
        {
            memberOfCollege mathew = new memberOfCollege();
            mathew.name = "Mathew";
            mathew.college = College.KFU;
            Console.WriteLine($"Имя: {mathew.name}, ВУЗ: {mathew.college}");

        }
    }
}