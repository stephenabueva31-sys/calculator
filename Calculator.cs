using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            int firstNumber = GetValidInteger("Enter the first number: ");
            int secondNumber = GetValidInteger("Enter the second number: ");
            string operation = GetOperation();

            if (operation == "=")
            {
                continueProgram = false;
                Console.WriteLine("Exiting the program...");
            }
            else
            {
                var result = PerformOperation(firstNumber, secondNumber, operation);
                if (result.HasValue)
                {
                    Console.WriteLine($"Result: {result.Value}");
                }
            }
        }
    }
