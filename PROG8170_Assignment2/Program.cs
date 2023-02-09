using System;

namespace PROG8170_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius = 0;

            // take radius from input
            Console.WriteLine("Please enter the radius of the circle: ");
            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Please Enter a valid integer value!");
            }

            //1.Get Circle Radius
            //2.Change Circle Radius
            //3.Get Circle Circumference
            //4.Get Circle Area
            //5.Exit

            // repeat the menu options till user press 5 for exist.
            while (true)
            {
                Console.Write("\n\n");
                Console.Write("Menu Options\n");
                Console.Write("1.Get Circle Radius\n");
                Console.Write("2.Change Circle Radius\n");
                Console.Write("3.Get Circle Circumference\n");
                Console.Write("4.Get Circle Area\n");
                Console.Write("5.Exit\n");
                Console.Write("\n\n");

                int menuOptions = 0;

                // read menu options given by user
                if (!int.TryParse(Console.ReadLine(), out menuOptions) || menuOptions < 1 || menuOptions > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu option.");
                    continue;
                }

                Circle c = new Circle(radius);

                switch (menuOptions)
                {
                    case 1:
                        Console.WriteLine("The radius of the circle is: " + c.GetRadius());
                        break;
                    case 2:
                        int newRadius = 0;

                        // validate new radius value
                        while (newRadius <= 0)
                        {
                            Console.WriteLine("Please enter the new radius of the circle: ");
                            if (!int.TryParse(Console.ReadLine(), out newRadius) || newRadius <= 0)
                            {
                                Console.WriteLine("Please enter a valid value for new radius it must be greater than 0.");
                            }
                        }
                        c.SetRadius(newRadius);
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + c.GetCircumference());
                        break;
                    case 4:
                        Console.WriteLine("The area of the circle is: " + c.GetArea());
                        break;
                    case 5:
                        return;
                }
            }

        }
    }
}
