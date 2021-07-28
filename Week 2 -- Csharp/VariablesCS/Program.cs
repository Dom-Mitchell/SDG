using System;

namespace VariablesCS
{
    class Program
    {
        static void MyCoffeeData()
        {
            // My Coffee Data
            var numCoffeeCups = 1;
            var fullName = "Dom Mitchell";
            var fullDate = DateTime.Now;
            var today = fullDate.Date.ToLongDateString();

            // My Coffee Data
            Console.WriteLine($"\nMy Name is {fullName} and I drank {numCoffeeCups} cup(s) of coffee on {today}\n");
        }
        static void Greeting()
        {
            // User Data
            var userName = "";
            var usersAge = "";
            var usersFaveNum = "";

            // Math Variables
            var firstOperand = 0.0;
            var secondOperand = 0.0;
            var answer = 0.0;
            //var sum = 0.0;
            //var difference = 0.0;
            //var product = 0.0;
            //var quotient = 0.0;
            //var remainder = 0.0;

            // Users Name & Greeting
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            if (userName == "Alice")
            {
                Console.WriteLine($"\nHi {userName}, tell us how is Wonderland?");
                Console.ReadLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"\nIts a pleasure to meet you, {userName}!\n");
            }

            // Users Age & Declaration
            Console.WriteLine($"How old are you, {userName}?");
            usersAge = Console.ReadLine();
            Console.WriteLine($"\n{userName} is {usersAge} year(s) old.\n");

            // Users Favorite Number & Declaration
            Console.WriteLine($"{userName}, what is your favorite number?");
            usersFaveNum = Console.ReadLine();
            Console.WriteLine($"\n{userName}'s favorite number is {usersFaveNum}.\n");

            // Converting Data
            firstOperand = double.Parse(usersAge);
            secondOperand = double.Parse(usersFaveNum);

            // Math Addition
            answer = firstOperand + secondOperand;
            Console.WriteLine($"If you add {userName}'s age, {firstOperand} and his/her favorite number, {secondOperand} you get {answer}.\n");

            // Math Subtraction
            answer = firstOperand - secondOperand;
            Console.WriteLine($"If you subtract {userName}'s age, {firstOperand} and his/her favorite number, {secondOperand} you get {answer}.\n");

            // Math Multiplication
            answer = firstOperand * secondOperand;
            Console.WriteLine($"If you multiply {userName}'s age, {firstOperand} and his/her favorite number, {secondOperand} you get {answer}.\n");

            // Math Division
            answer = firstOperand / secondOperand;
            Console.WriteLine($"If you divide {userName}'s age, {firstOperand} and his/her favorite number, {secondOperand} you get {answer}.\n");

            // Math Remainder
            answer = firstOperand % secondOperand;
            Console.WriteLine($"If you divide {userName}'s age, {firstOperand} and his/her favorite number, {secondOperand} the remainder is {answer}.\n");
        }
        static void Main(string[] args)
        {
            // My Coffee Data
            MyCoffeeData();

            // Greeting Method
            Greeting();
        }
    }
}
