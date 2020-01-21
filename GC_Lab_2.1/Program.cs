using System;

namespace GC_Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Human, allow me to calculate your rooms for you. >:-)");

            while (true)
            {
                Console.Write("Enter a room length: ");
                Double.TryParse(Console.ReadLine(), out double length);
                Console.Write("Enter a room width: ");
                Double.TryParse(Console.ReadLine(), out double width);
                Console.Write("Enter a room height: ");
                Double.TryParse(Console.ReadLine(), out double height);

                var area = length * width;
                var perimeter = (2 * length) + (2 * width);
                var volume = area * height;

                string roomSize;

                if (area <= 250)
                {
                    roomSize = "small.";
                }
                else if (area < 650)
                {
                    roomSize = "medium!";
                }
                else if (area >= 650)
                {
                    roomSize = "large!!";
                }
                else
                {
                    roomSize = "undefined!!!";
                }

                Console.WriteLine($"This room's perimeter is {perimeter} feet long.");
                Console.WriteLine($"This room's area is {area} square feet.");
                Console.WriteLine($"This room's volume is: {volume} cubed feet.");
                Console.WriteLine($"This room is {roomSize}");

                Console.Write("Give us more rooms to... measure? (y/n) ");
                bool haveValidAnswer = false;
                ConsoleKeyInfo answer;
                do
                {
                    answer = Console.ReadKey();

                    if (answer.KeyChar == 'y' || answer.KeyChar == 'n')
                    {
                        haveValidAnswer = true;
                    }
                } while (!haveValidAnswer);

                Console.WriteLine();

                if (answer.KeyChar == 'n')
                {
                    break;
                }

            }

            Console.WriteLine("Thank you, Human, we will make use of this detailed room informaiton.");


        }

    }
}
