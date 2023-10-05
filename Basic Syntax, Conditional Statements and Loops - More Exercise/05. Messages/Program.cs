using System;
using System.ComponentModel.Design;
using System.Net.Mail;

namespace MoreExercise

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int offset = 0;
            int mainDigit = 0;
            string letter = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());


                if (number == 0)
                {
                    letter += ' ';
                    continue;
                }
                while (number > 0)
                {
                    mainDigit = number % 10;


                    while (number > 0)
                    {
                        number /= 10;
                        offset++;
                    }

                    if (mainDigit == 1)
                    {
                        continue;
                    }
                    else if (mainDigit == 2)
                    {
                        if (offset == 1)
                        {
                            letter += 'a';

                        }
                        else if (offset == 2)
                        {
                            letter += 'b';

                        }
                        else if (offset == 3)
                        {
                            letter += 'c';

                        }



                    }
                    else if (mainDigit == 3)
                    {
                        if (offset == 1)
                        {
                            letter += 'd';

                        }
                        else if (offset == 2)
                        {
                            letter += 'e';

                        }
                        else if (offset == 3)
                        {
                            letter += 'f';

                        }



                    }
                    else if (mainDigit == 4)
                    {
                        if (offset == 1)
                        {
                            letter += 'g';

                        }
                        else if (offset == 2)
                        {
                            letter += 'h';

                        }
                        else if (offset == 3)
                        {
                            letter += 'i';

                        }



                    }
                    else if (mainDigit == 5)
                    {
                        if (offset == 1)
                        {
                            letter += 'j';

                        }
                        else if (offset == 2)
                        {
                            letter += 'k';

                        }
                        else if (offset == 3)
                        {
                            letter += 'l';

                        }



                    }
                    else if (mainDigit == 6)
                    {
                        if (offset == 1)
                        {
                            letter += 'm';

                        }
                        else if (offset == 2)
                        {
                            letter += 'n';

                        }
                        else if (offset == 3)
                        {
                            letter += 'o';

                        }



                    }
                    else if (mainDigit == 7)
                    {
                        if (offset == 1)
                        {
                            letter += 'p';

                        }
                        else if (offset == 2)
                        {
                            letter += 'q';

                        }
                        else if (offset == 3)
                        {
                            letter += 'r';

                        }
                        else if (offset == 4)
                        {
                            letter += 's';
                        }



                    }
                    else if (mainDigit == 8)
                    {
                        if (offset == 1)
                        {
                            letter += 't';

                        }
                        else if (offset == 2)
                        {
                            letter += 'u';

                        }
                        else if (offset == 3)
                        {
                            letter += 'v';

                        }



                    }
                    else if (mainDigit == 9)
                    {
                        if (offset == 1)
                        {
                            letter += 'w';

                        }
                        else if (offset == 2)
                        {
                            letter += 'x';

                        }
                        else if (offset == 3)
                        {
                            letter += 'y';

                        }
                        else if (offset == 4)
                        {
                            letter += 'z';
                        }



                    }




                }
                offset = 0;
            }

            Console.WriteLine(letter);
        }
    }
}
