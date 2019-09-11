using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What grade do you expect to get in ISM 4300?");

            try
            {

                string input = Console.ReadLine();

                int grade = int.Parse(input);

                if ((grade >= 0) && (grade < 60))
                {
                    Console.WriteLine("Your letter grade will be a F");
                    Console.WriteLine("Your GPA for the class will be a 0.00");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("Your letter grade will be a D-");
                    Console.WriteLine("Your GPA for the class will be a 0.67");
                }
                else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("Your letter grade will be a D");
                    Console.WriteLine("Your GPA for the class will be a 1.00");
                }
                else if ((grade >= 68) && (grade<= 69))
                {
                    Console.WriteLine("Your letter grade will be a D+");
                    Console.WriteLine("Your GPA for the class will be a 1.33");
                }
                else if ((grade >= 70) && (grade <=71))
                {
                    Console.WriteLine("Your letter grade will be a C-");
                    Console.WriteLine("Your GPA for the class will be a 1.67");
                }
                else if ((grade >=72) && (grade <=77))
                {
                    Console.WriteLine("Your letter grade will be a C");
                    Console.WriteLine("Your GPA for the class will be a 2.00");
                }
                else if ((grade >=78) && (grade <=79))
                {
                    Console.WriteLine("Your letter grade will be a C+");
                    Console.WriteLine("Your GPA for the class will be a 2.33");
                }
                else if ((grade >=80) && (grade <=81))
                {
                    Console.WriteLine("Your letter grade will be a B-");
                    Console.WriteLine("Your GPA for the class will be a 2.67");
                }
                else if ((grade >=82) && (grade <= 87))
                {
                    Console.WriteLine("Your letter grade will be a B");
                    Console.WriteLine("Your GPA for the class will be a 3.00");
                }
                else if ((grade >=88) && (grade <=89))
                {
                    Console.WriteLine("Your letter grade will be a B+");
                    Console.WriteLine("Your GPA for the class will be a 3.33");
                }
                else if ((grade >=90) && (grade <=91))
                {
                    Console.WriteLine("Your letter grade will be a A-");
                    Console.WriteLine("Your GPA for the class will be a 3.67");
                }
                else if ((grade >=92) && (grade <=97))
                {
                    Console.WriteLine("Your letter grade will be a A");
                    Console.WriteLine("Your GPA for the class will be a 4.00");
                }
                else if ((grade >=98) && (grade <=100))
                {
                    Console.WriteLine("Your letter grade will be a A+");
                    Console.WriteLine("Your GPA for the class will be a 4.00");
                }
             
            }
            catch
            {
                Console.WriteLine("Please enter an integer for the grade");
                Console.WriteLine("Press any key to exit the program and try again");
            }
        }
    }
}
