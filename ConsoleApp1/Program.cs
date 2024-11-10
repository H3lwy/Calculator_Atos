namespace ConsoleApp1
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            bool continueCalculations = true;

            while (continueCalculations)
            {
                int value1;
                while (true)
                {
                    Console.Write("Enter first number: ");
                    if (int.TryParse(Console.ReadLine(), out value1))
                        break;
                    Console.WriteLine("Please enter a valid number.");
                }

                string operation;
                while (true)
                {
                    Console.Write("Enter an operator (+, -, *, /): ");
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                        break;
                    Console.WriteLine("Please enter +, -, * or /.");
                }

                int value2;
                while (true)
                {
                    Console.Write("Enter second number: ");
                    if (int.TryParse(Console.ReadLine(), out value2))
                        break;
                    Console.WriteLine("Please enter a valid number.");
                }

                int result;
                switch (operation)
                {
                    case "+":
                        result = exercise.Sum(value1, value2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "-":
                        result = exercise.Sub(value1, value2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "*":
                        result = exercise.Multi(value1, value2);
                        Console.WriteLine("Result: " + result);
                        break;
                    case "/":
                        result = exercise.Divide(value1, value2);
                        if (result != int.MaxValue)
                        {
                            Console.WriteLine("Result: " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.Write("Would you like to perform another calculation? (y/n): ");
                string response = Console.ReadLine();
                continueCalculations = response.ToLower() == "y";
            }

            Console.WriteLine("Thank you");
        }

        private int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        private int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        private int Multi(int number1, int number2)
        {
            return number1 * number2;
        }

        private int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return int.MaxValue;
            }
            return number1 / number2;
        }
    }
}
