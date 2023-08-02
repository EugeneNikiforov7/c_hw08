// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultipleArray(int[,] arr1, int[,] arr2)
{
    int maxLegth = 0;
    if (arr1.GetLength(0) > arr1.GetLength(1))
    {
        maxLegth = arr1.GetLength(0);
    }
    else
    {
        maxLegth = arr1.GetLength(1);
    }
    int[,] multArr = new int[maxLegth, maxLegth];

    for (int k = 0; k <= arr1.GetLength(1); k++)
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                //multArr[k, i] += arr1[i, j] * arr2[j, k];
                multArr[i, k] += arr1[i, j] * arr2[j, k];
            }
        }
    }
    return multArr;
}

void PrintDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j].ToString().PadLeft(4));
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
int[,] doubleArray2 = CreateRandomArray(num, num1);
PrintDoubleArray(doubleArray1);
PrintDoubleArray(doubleArray2);
Console.WriteLine("Результирующая матрица:");
int[,] doubleArray3 = MultipleArray(doubleArray1, doubleArray2);
PrintDoubleArray(doubleArray3);

