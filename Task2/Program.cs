// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз! ");
    }
    return number;
}

void GetBinaryView(int num)
{
        if (num == 0) System.Console.Write(0);
        if (num == 1) System.Console.Write(1);
        else
        {
            GetBinaryView(num / 2);
            System.Console.Write(num % 2);
        }
}

int num = InputNumber("Введите число: ");
System.Console.Write($"Число {num} в двоичной системе: ");
GetBinaryView(num);