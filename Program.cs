Random random = new Random();
int randomNumber = random.Next(0, 100 + 1);

Console.WriteLine("Type 'exit' to exit the app.");
void game()
{
    bool exit = false;
    while (!exit)
    {
        
        Console.Write("Guess a number between 0 and 100: ");
        string input = Console.ReadLine()!;
        if (input == "exit")
        {
            Environment.Exit(0); // Estava tentando fechar o console sem aparecer o código de exit, mas acho que não é possível em um ambiente de desenvolvimento.
        }
        else
        {
            int inputAsNumber;
            bool isNumber = int.TryParse(input, out inputAsNumber); // Retorna true se o input for um número
            if (isNumber)
            {
                if (inputAsNumber < 0 || inputAsNumber > 100)
                {
                    Console.WriteLine("Write a valid number.");
                }
                else if (inputAsNumber < randomNumber)
                {
                    Console.WriteLine("The number is higher.");
                }
                else if (inputAsNumber > randomNumber)
                {
                    Console.WriteLine("The number is lower.");
                }
                else if (inputAsNumber == randomNumber)
                {
                    Console.WriteLine("You won!");
                    exit = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

game();
