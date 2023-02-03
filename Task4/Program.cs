// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 11);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}


Random rand = new Random();
int[] array = new int[rand.Next(2, 11)];
FillArray(array);
PrintArray(array);
int[] newArray = CopyArray(array);
Console.WriteLine();
Console.WriteLine("Копия массива: ");
PrintArray(newArray);