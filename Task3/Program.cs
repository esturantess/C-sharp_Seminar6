// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    if (num == 1)
    {
        return array;
    }
    array[1] = 1;
    if (num == 2)
    {
        return array;
    }
    else
    {
        for (int i = 2; i < num; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
        return array;
    }
}

Console.WriteLine("Введите количество первых чисел Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Некорректное число.");
}
else
    Console.WriteLine("Первые " + (number) + " чисел Фибоначчи: " + "[" + String.Join(", ", Fibonacci(number)) + "]");

// Другой вариант решения:

// int Number(string str)
// {
// System.Console.WriteLine(str);
// return Convert.ToInt32(Console.ReadLine());
// }

// int N = Number("Введите N: ");
// System.Console.WriteLine(N);

// int firstNum = 0;
// int secondNum = 1;
// System.Console.Write("0, 1");

// for (int i = 0; i < N-2; i++)
// {
// int fibonacci = firstNum + secondNum;
// System.Console.Write($", {fibonacci}");
// firstNum = secondNum;
// secondNum = fibonacci;
// }
// System.Console.WriteLine(" ");