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

// Второй вариант решения:

// int[] RandomArrayCreation(int size, int leftValue, int rightValue)
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftValue, rightValue + 1);
//     }
//     return arr;
// }

// int[] ArrayCopying(int[] array)
// {
//     int[] arrayCopy = new int[array.Length];
//     for (int i = 0; i < arrayCopy.Length; i++)
//     {
//         arrayCopy[i] = array[i];
//     }
//     return arrayCopy;
// }


// int[] arr = RandomArrayCreation(5, 0, 10);
// Console.WriteLine("[" + string.Join(",", arr) + "]");
// int[] arr2 = ArrayCopying(arr);
// Console.WriteLine("[" + string.Join(",", arr2) + "]");