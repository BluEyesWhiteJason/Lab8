using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays with data
            string[] names = {"Dakota", "Joshua", "Tommy", "James", "Maricela", "KimVy", "Sam", "Cody", "Jason", "Robert"};
            string[] hometown = { "Kent City", "Grand Rapids", "Raleigh", "Grand Rapids", "Morelia", "Grand Rapids", "Grand Rapids","Grand Rapids", "Holland", "Detroit" };
            string[] food = { "Pho", "Cheese Tortellini", "Chicken Curry", "Cheeseburgers and Fries", "Tacos", "Sushi", "Tacos", "Potato Soup", "Burgers", "Burgers" };

            // Get input on which student, catch exceptions
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-10):");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please input a number");
            }

            try
            {
                Console.WriteLine("Student {0} is {1}. What would you like to know about them?", input, names[input - 1]);
                Console.WriteLine("Try 'hometown' for hometown or 'food' for favorite food");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Please enter a number from 1-10");
            }

            // get what info user wants

            bool validInp = false;

            Console.WriteLine("Please enter what info you would like ('hometown' or 'food')");

            while (validInp == false)
            {
                string info = Console.ReadLine();

                if (info == "hometown")
                {
                    Console.WriteLine("{0} is from {1}", names[input - 1], hometown[input - 1]);
                    validInp = true;
                }
                else if (info == "food")
                {
                    Console.WriteLine("{0}'s favorite food is {1}", names[input - 1], food[input - 1]);
                    validInp = true;

                }
                else
                {
                    Console.WriteLine("Invalid input, please enter either 'hometown' or 'food'");
                    validInp = false;
                }
            }
            

        }
    }
}
