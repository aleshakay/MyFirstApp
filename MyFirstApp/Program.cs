using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();
            Console.WriteLine(userEntry);
            if (userEntry == "Alesha")
            {
                // do something
                Console.WriteLine("You are awesome");
            }
            else
            {
                // do something else
                Console.WriteLine("You are awesome but not as much");
            }

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++} ...");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of i is {j++} ...");
            }

            foreach (var currentCharacter in userEntry)
            {
                Console.WriteLine($"the current character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "Alesha":
                    Console.WriteLine($"It is Me {userEntry}");
                    break;
                default:
                    Console.WriteLine($"It is not {userEntry}");
                    break;
            }

            var isAlesha = userEntry == "Alesha" ? true : false;
        }
    }
}
    