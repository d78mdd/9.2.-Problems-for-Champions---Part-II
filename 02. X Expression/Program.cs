using System;

namespace _02.X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string izraz = Console.ReadLine();

            double mainResult = 0;
            double braceResult = 0;

            char mainOperator = 'n';
            char braceOperator = 'n';

            bool insideBraces = false;

            foreach (char simvol in izraz)
            {

                switch (simvol)
                {
                    case '=':
                        break;

                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        if (insideBraces)
                        {
                            switch (braceOperator)
                            {
                                case 'n':
                                    braceResult = double.Parse(simvol.ToString());
                                    break;
                                case '+':
                                    braceResult += double.Parse(simvol.ToString());
                                    break;
                                case '-':
                                    braceResult -= double.Parse(simvol.ToString());
                                    break;
                                case '*':
                                    braceResult *= double.Parse(simvol.ToString());
                                    break;
                                case '/':
                                    braceResult /= double.Parse(simvol.ToString());
                                    break;
                            }

                        }
                        else  // outside braces
                        {
                            switch (mainOperator)
                            {
                                case 'n':
                                    mainResult = double.Parse(simvol.ToString());
                                    break;
                                case '+':
                                    mainResult += double.Parse(simvol.ToString());
                                    break;
                                case '-':
                                    mainResult -= double.Parse(simvol.ToString());
                                    break;
                                case '*':
                                    mainResult *= double.Parse(simvol.ToString());
                                    break;
                                case '/':
                                    mainResult /= double.Parse(simvol.ToString());
                                    break;
                            }
                        }
                        break;

                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        if (insideBraces)
                        {
                            braceOperator = simvol;

                        }
                        else
                        {
                            mainOperator = simvol;
                        }
                        break;

                    case '(':

                        insideBraces = true;
                        break;
                    case ')':
                        braceOperator = 'n';

                        switch (mainOperator)
                        {
                            case 'n':
                                mainResult = braceResult;
                                break;
                            case '+':
                                mainResult += braceResult;
                                break;
                            case '-':
                                mainResult -= braceResult;
                                break;
                            case '*':
                                mainResult *= braceResult;
                                break;
                            case '/':
                                mainResult /= braceResult;
                                break;
                        }

                        insideBraces = false;
                        break;
                }

            }

            Console.WriteLine($"{mainResult:F2}");
        }
    }
}
