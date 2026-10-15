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

        int[] array = new int [size];
        
        for (int i = 0; i <= array.Length - 1; i++)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine($"Введите элемент {i + 1}: ");
                string? input = Console.ReadLine();
                flag = int.TryParse(input, out array[i]);
                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }
    }
}