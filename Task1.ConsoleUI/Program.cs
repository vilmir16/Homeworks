namespace Task1.ConsoleUI;

public class Program
{
    public static void Main()
    {
        bool repeat = true;
        while (repeat)
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

            bool isSorted = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    isSorted = false;
                }
            }

            if (!isSorted)
            {
                Console.WriteLine("Не отсортированный массив");
                return;
            }

            int target = 0;
            bool targetParsed = false;
            while (!targetParsed)
            {
                Console.WriteLine("Введите искомое число: ");
                string? input = Console.ReadLine();
                targetParsed = int.TryParse(input, out target);
                if (!targetParsed)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }

            int result = SearchAlgorithms.BinarySearch(array, target);

            if (result == -1)
            {
                Console.WriteLine("Элемент не найден");
            }
            else
            {
                Console.WriteLine($"Элемент найден на позиции {result}");
            }
            
            Console.WriteLine("Повторить? (y/n)");
            string? answer = Console.ReadLine()?.ToLower();

            if (answer == "y")
            {
                repeat = true;
            }
            else
            {
                repeat = false;
            }
        }
    }
}