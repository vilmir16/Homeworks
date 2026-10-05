namespace Task1.ConsoleUI;

public class Program
{
    public static void Main()
    {
        int size = 0;
        while (size <= 0)
        {
            Console.Write("Введите размер массива: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out size) && size > 0)
            {
                Console.WriteLine($"Размер массива: {size}");
            }
            else
            {
                Console.WriteLine("Некорректный размер массива");
            }
        }

    }
}