using System;

namespace _02.X_Expression_using_Console.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbol = Console.Read();

            decimal result = symbol - '0';
            int expressionOperator = '+';

            while (symbol != '=')
            {
                symbol = Console.Read();

                if (symbol == '(')
                {
                    
                    int innerOperator = '+';
                    symbol = Console.Read();
                    decimal innerResult = symbol - '0';


                    while (symbol != ')')
                    {
                        symbol = Console.Read();

                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+':
                                    innerResult += symbol - '0';
                                    break;
                                case '-':
                                    innerResult -= symbol - '0';
                                    break;
                                case '*':
                                    innerResult *= symbol - '0';
                                    break;
                                case '/':
                                    innerResult /= symbol - '0';
                                    break;
                            }

                        }
                        else if (symbol == '+' ||
                            symbol == '-' ||
                            symbol == '/' ||
                            symbol == '*')
                        {
                            innerOperator = symbol;
                        }

                    }

                    switch (expressionOperator)
                    {
                        case '+':
                            result += innerResult;
                            break;
                        case '-':
                            result -= innerResult;
                            break;
                        case '*':
                            result *= innerResult;
                            break;
                        case '/':
                            result /= innerResult;
                            break;
                    }

                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+':
                            result += symbol - '0';
                            break;
                        case '-':
                            result -= symbol - '0';
                            break;
                        case '*':
                            result *= symbol - '0';
                            break;
                        case '/':
                            result /= symbol - '0';
                            break;
                    }

                }
                else if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '/' ||
                    symbol == '*')
                {
                    expressionOperator = symbol;
                }
            }

            Console.WriteLine($"{result:F2}");

        }
    }
}
