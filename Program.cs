using System;

namespace DevYou_ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Month Converter

            Console.Write("Enter number of month: ");
            int numberToConvert = int.Parse(Console.ReadLine());

            if (numberToConvert >= 1 && numberToConvert <= 12)
            {

                switch (numberToConvert)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 - 12.");
            }

            //Mini Trivia
            string sportsAnswer = "10";
            string scienceAnswer = "earth";
            string popCultureAnswer = "jackson";
            string userAnswer = "";

            Console.Write("Choose category of questions (1)Sports (2)Science (3)Pop Culture: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.Write("How many players are on a basketball court total?: ");
                     userAnswer = Console.ReadLine();

                    if (userAnswer == sportsAnswer)
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;
                case "2":
                    Console.Write("What is the third planet from the sun: ");
                    userAnswer = Console.ReadLine().ToLower();

                    if (userAnswer == scienceAnswer)
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;
                case "3":
                    Console.Write("Last name of the artist who sings the song thriller: ");
                    userAnswer = Console.ReadLine().ToLower();

                    if (userAnswer == popCultureAnswer)
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }

        }
    }
}
