// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetMinValue(int[] arr)
{
    int minValueIndex = 0;
    for (int i = 0; i < arr.Length; i++) 
    if (arr[i] < arr[minValueIndex])
    {
        minValueIndex = i;
    }
    return minValueIndex;
}

int GetMinRow(int[,] arr)
{
    int[] sumRows = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumRows[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
                sumRows[i] += arr[i, j];
        }
//        Console.Write($"{sumRows[i]} ");
    }
    return GetMinValue(sumRows);
}

void PrintDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    { 
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
            Console.WriteLine();
    }
}

int[,] CreateRandomArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(1,10);
    return arr;
}

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetNum("Введите количество строк массива: ");
int num2 = GetNum("Введите количество колонок массива: ");
int[,] doubleArray = CreateRandomArray(num1, num2);
PrintDoubleArray(doubleArray);
Console.WriteLine($"Номер строки(индекс) с наименьшей суммой элементов: {GetMinRow(doubleArray)}");
