using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class exercise_2_1
    {
        struct UserData()
        {
            public string name;
            public string city;
            public int age;
            public int PINcode;
        }

        enum CategoryOfAlcogolism
        {
            a,
            b,
            c,
            d
        }
        struct Student()
        {
            public string surname;
            public string name;
            public int indificator;
            public DateTime birthday;
            public CategoryOfAlcogolism alcoCategory;
            public int volumeDrinked;
        }

        struct Drinks()
        {
            public string name;
            public string alcoholContent;
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания из проекта");
                int numberOfExercise = int.Parse(Console.ReadLine());
                switch (numberOfExercise)
                {
                    case 1:
                        Console.WriteLine("\nНомер 1");
                        Console.WriteLine($"sbyte – {sbyte.MaxValue} – {sbyte.MinValue}");
                        Console.WriteLine($"byte – {byte.MaxValue} – {byte.MinValue}");
                        Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
                        Console.WriteLine($"ushort – {ushort.MaxValue} – {ushort.MinValue}");
                        Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
                        Console.WriteLine($"uint – {uint.MaxValue} – {uint.MinValue}");
                        Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
                        Console.WriteLine($"ulong – {ulong.MaxValue} – {ulong.MinValue}");
                        Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
                        Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
                        Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");
                        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить\n");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("\nНомер 2");
                        UserData mathew = new UserData();
                        mathew.name = "Mathew";
                        mathew.city = "Moscow";
                        mathew.age = 49;
                        mathew.PINcode = 0;
                        Console.WriteLine($"Имя: {mathew.name}\nГород: {mathew.city}\n" +
                            $"Возраст: {mathew.age}\nПИН код: {mathew.PINcode}");
                        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить\n");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\nНомер 3");
                        Console.WriteLine("Введите строку");
                        string mainString = Console.ReadLine();
                        string answerString = "";

                        for (int i = 0; i < mainString.Length; i ++)
                        {
                            if (char.IsLetter(mainString[i]))
                            {
                                if (char.IsLower(mainString[i])) answerString += char.ToUpper(mainString[i]);
                                else answerString += char.ToLower(mainString[i]);
                            }
                            else answerString += mainString[i];
                        }
                        Console.WriteLine(answerString);
                        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить\n");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("\nНомер 4");
                        Console.WriteLine("Введите строку");
                        string source = Console.ReadLine();
                        Console.WriteLine("\nВведите подстроку");
                        string substring = Console.ReadLine();
                        int count = 0;
                        int currentIndex = 0;
                        while ((currentIndex = source.IndexOf(substring, currentIndex)) != -1)
                        {
                            count++;
                            currentIndex += substring.Length;
                        }
                        Console.WriteLine($"Всего подстрок: {count}");
                        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить\n");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("\nНомер 5");
                        Console.WriteLine("\nВведите цену");
                        double normPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nВведите процент");
                        double salePrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nВведите стоимость отпуска");
                        double holidayPrice = double.Parse(Console.ReadLine());
                        double economy = 0.0;
                        double answer = 0;
                        economy = normPrice * (salePrice / 100);
                        answer = holidayPrice / economy;
                        answer = Math.Floor(answer);
                        Console.WriteLine($"{answer}, {economy}");
                        Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить\n");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.WriteLine("\nНомер 6");

                        break;

                    default:
                        break;
                }
            }
	    }
    }
}