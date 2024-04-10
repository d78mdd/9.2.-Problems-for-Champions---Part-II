using System;


namespace _03.Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bikove = int.Parse(Console.ReadLine());
            int kravi = int.Parse(Console.ReadLine());

            int n1 = secretNumber / 1000;
            int n2 = (secretNumber / 100) % 10;
            int n3 = (secretNumber / 10) % 10;
            int n4 = secretNumber % 10;

            int obshtoBikove = 0;
            int obshtoKravi = 0;

            bool _i1found = false;
            bool _i2found = false;
            bool _i3found = false;
            bool _i4found = false;
            
            bool _n1found = false;
            bool _n2found = false;
            bool _n3found = false;
            bool _n4found = false;

            bool hasNumbers = false;

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (n1 == i1)
                            {
                                obshtoBikove++;
                                _i1found = true;
                                _n1found = true;
                            }
                            if (n2 == i2)
                            {
                                obshtoBikove++;
                                _i2found = true;
                                _n2found = true;
                            }
                            if (n3 == i3)
                            {
                                obshtoBikove++;
                                _i3found = true;
                                _n3found = true;
                            }
                            if (n4 == i4)
                            {
                                obshtoBikove++;
                                _i4found = true;
                                _n4found = true;
                            }


                            if (n1 == i2 && !_n1found && !_i2found)
                            {
                                obshtoKravi++;
                                _n1found = true;
                                _i2found = true;
                            }
                            else if (n1 == i3 && !_n1found && !_i3found)
                            {
                                obshtoKravi++;
                                _n1found = true;
                                _i3found = true;
                            }
                            else if (n1 == i4 && !_n1found && !_i4found)
                            {
                                obshtoKravi++;
                                _n1found = true;
                                _i4found = true;
                            }



                            if (n2 == i1 && !_n2found && !_i1found)
                            {
                                obshtoKravi++;
                                _n2found = true;
                                _i1found = true;
                            }
                            else if (n2 == i3 && !_n2found && !_i3found)
                            {
                                obshtoKravi++;
                                _n2found = true;
                                _i3found = true;
                            }
                            else if (n2 == i4 && !_n2found && !_i4found)
                            {
                                obshtoKravi++;
                                _n2found = true;
                                _i4found = true;
                            }


                            if (n3 == i1 && !_n3found && !_i1found)
                            {
                                obshtoKravi++;
                                _n3found = true;
                                _i1found = true;
                            }
                            else if (n3 == i2 && !_n3found && !_i2found)
                            {
                                obshtoKravi++;
                                _n3found = true;
                                _i2found = true;
                            }
                            else if (n3 == i4 && !_n3found && !_i4found)
                            {
                                obshtoKravi++;
                                _n3found = true;
                                _i4found = true;
                            }



                            if (n4 == i1 && !_n4found && !_i1found)
                            {
                                obshtoKravi++;
                            }
                            else if (n4 == i2 && !_n4found && !_i2found)
                            {
                                obshtoKravi++;
                            }
                            else if (n4 == i3 && !_n4found && !_i3found)
                            {
                                obshtoKravi++;
                            }


                            if (obshtoBikove == bikove && obshtoKravi == kravi)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                                hasNumbers = true;
                            }


                            _i1found = false;
                            _i2found = false;
                            _i3found = false;
                            _i4found = false;

                            _n1found = false;
                            _n2found = false;
                            _n3found = false;
                            _n4found = false;

                            obshtoKravi = 0;
                            obshtoBikove = 0;

                        }
                    }
                }
            }

            if (!hasNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}
