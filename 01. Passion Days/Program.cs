using System;

// https://csharp-book.softuni.bg/chapter-09-problems-for-champions-part-2.html#%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-%D0%B4%D0%BD%D0%B8-%D0%B7%D0%B0-%D1%81%D1%82%D1%80%D0%B0%D1%81%D1%82%D0%BD%D0%BE-%D0%BF%D0%B0%D0%B7%D0%B0%D1%80%D1%83%D0%B2%D0%B0%D0%BD%D0%B5
namespace _01.Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            double nachalniPari = double.Parse(Console.ReadLine());

            double nalichniPari = nachalniPari;

            int pokupki = 0;

            string initialCommand;
            do
            {
                initialCommand = Console.ReadLine();
            }
            while (initialCommand != "mall.Enter");

            for (; ; )
            {
                string buyCommand = Console.ReadLine();

                if (buyCommand == "mall.Exit")
                {
                    break;
                }

                for (int i = 0; i < buyCommand.Length; i++)
                {
                    char commandChar = buyCommand[i];

                    double pokupka = 0.0;
                    if (commandChar >= 'A' && commandChar <= 'Z')
                    {
                        double cena = (double)commandChar;
                        pokupka = cena * 0.5;

                        if (pokupka > nalichniPari)
                        {
                            continue;
                        }
                        nalichniPari -= pokupka;
                        pokupki++;
                    }
                    else if (commandChar >= 'a' && commandChar <= 'z')
                    {
                        double cena = (double)commandChar;
                        pokupka = cena * 0.3;

                        if (pokupka > nalichniPari)
                        {
                            continue;
                        }
                        nalichniPari -= pokupka;
                        pokupki++;
                    }
                    else if (commandChar == '%')
                    {
                        pokupka = (double)nalichniPari / 2.00;

                        Console.Write(nalichniPari);
                        Console.Write(" ");
                        Console.WriteLine(pokupka);

                        if (pokupka > nalichniPari)
                        {
                            continue;
                        }
                        nalichniPari -= pokupka;
                        pokupki++;
                    }
                    else if (commandChar == '*')
                    {
                        double iztegleno = (double)10.00;

                        Console.WriteLine(iztegleno);

                        nalichniPari += iztegleno;
                    }
                    else
                    {
                        pokupka = (double)commandChar;

                        if (pokupka > nalichniPari)
                        {
                            continue;
                        }
                        nalichniPari -= pokupka;
                        pokupki++;
                    }

                }

            }

            if (pokupki == 0)
            {
                Console.WriteLine($"No purchases. Money left: {nalichniPari:F2} lv.");
            }
            else
            {
                Console.WriteLine($"{pokupki} purchases. Money left: {nalichniPari:F2} lv.");
            }
        }
    }
}
