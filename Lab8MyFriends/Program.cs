using System;

namespace Lab8MyFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome");
            Console.WriteLine("\tget to know your peers ");
            bool loop = true;
            while (loop == true)
            {

                string[] stuId = { "", "1", "2", "3", "4" };
                string[] names = { "", "Jordan", "Bobby", "Jean", "Pat" };
                string[] favoriteFoods = { "", "Avocado Toast", "Kale Chips", "Tofu", "Braunschweiger" };
                string[] boyGirl = { "", "Girl", "Boy", "Boy", "You'll never know" };
                string[] height = { "", "Tall", "Tall", "TALLLL", "Short" };


            Console.WriteLine($"Please select a student by picking a number from 1 to {names.Length - 1}");
                string input = Console.ReadLine().Trim();
                int index = 0;
                string name = "";
                try
                {
                    index = int.Parse(input);

                    if (index >= 1 && index < names.Length)
                    {
                        name = names[index];
                    }
                    else
                    {
                        throw new Exception($"That number is outside the range of 1 to {names.Length - 1}. Please try again");
                        
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number please try again!");
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (name != "")
                {
                    Console.WriteLine($"You have selected: {index} which is {name}");
                    Console.WriteLine($"What would like to learn about {name}? " +
                        $"Their Favorite food, If they are a Boy or Girl, or If they are short of tall?");

                    string response = Console.ReadLine().ToLower().Trim();

                    if (response == "favorite food")
                    {
                        Console.WriteLine($"The favorite food of {name} is {favoriteFoods[index]}");
                    }
                    else if (response == "boy or girl")
                    {
                        Console.WriteLine($"{name} is {boyGirl[index]}");
                    }
                    else if (response == "short or tall")
                    {
                        Console.WriteLine($"{name} is {height[index]}");
                    }
                    else
                        Console.WriteLine("that is not a valid entery, please try again.");
                }

                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to learn about another student? y/n");
                    string userInput = Console.ReadLine().ToLower().Trim();
                    if (userInput == "y")
                    {
                        loop = true;
                        askAgain = false;
                    }
                    else if (userInput == "n")
                    {
                        loop = false;
                        askAgain = false;
                    }
                }
            }
        }
    }
}
