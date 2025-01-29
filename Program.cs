using System;

class Program
{
    static void Main()
    {
        // Генериране на случайно число между 1 и 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Търсеното число
        int attempts = 0; // Брояч на опитите
        int userGuess = 0; // Въведеното от играча число

        Console.WriteLine("Добре дошли в играта 'Угадай числото'!");
        Console.WriteLine("Аз съм избрал число между 1 и 100.");
        Console.WriteLine("Опитай се да го познаеш!");

        // Играта продължава докато играчът не познае числото
        while (userGuess != secretNumber)
        {
            Console.Write("Въведи число: ");
            string input = Console.ReadLine();

            // Проверка дали въведеното не е число
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Моля въведи валидно число.");
                continue;
            }

            attempts++;

            if (userGuess < secretNumber)
            {
                Console.WriteLine("Твоето число е по-малко от търсеното.");
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("Твоето число е по-голямо от търсеното.");
            }
            else
            {
                Console.WriteLine($"Поздравления! Ти позна числото {secretNumber} за {attempts} опита.");
            }
        }
    }
}
