// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultipleArray(int[,] arr1, int[] arr2)
{
    if (arr1.GetLength(0) > arr1.GetLength(1))
        int[,] multArr = new int[arr1.GetLength(0), arr1.GetLength(0)];
    else
        int[,] multArr = new int[arr1.GetLength(1), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            multArr[i, j] += arr1[i, j];
        }
        //        Console.Write($"{sumRows[i]} ");
    }
    return multArr;

    void PrintDoubleArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i, j]} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    int[,] CreateRandomArray(int row, int col)
    {
        int[,] arr = new int[row, col];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = new Random().Next(1, 10);
        return arr;
    }

    int GetNum(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    int num1 = GetNum("Введите количество строк первого массива: ");
    int num2 = GetNum("Введите количество колонок первого массива: ");
    int[,] doubleArray1 = CreateRandomArray(num1, num2);
    int[,] doubleArray2 = CreateRandomArray(num2, num1);
    PrintDoubleArray(doubleArray1);
    PrintDoubleArray(doubleArray1);
    Console.WriteLine("Результирующая матрица:");
    int[,] doubleArray3 = MultipleArray(doubleArray1, doubleArray2);
    PrintDoubleArray(doubleArray3);

