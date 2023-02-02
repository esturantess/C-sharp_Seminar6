// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

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

bool TriangleExistCheck(int num1, int num2, int num3)
{
    if ((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num1 + num2)) return true;
    else return false;
}

int firstNum = InputNumber("Введите первое число: ");
int secondNum = InputNumber("Введите второе число: ");
int thirdNum = InputNumber("Введите третье число: ");

if (TriangleExistCheck(firstNum, secondNum, thirdNum) == true)
{
    System.Console.WriteLine($"Треугольник с длинами сторон {firstNum}, {secondNum} и {thirdNum} может существовать.");
}
else
    System.Console.WriteLine($"Треугольник с длинами сторон {firstNum}, {secondNum} и {thirdNum} не может существовать.");

