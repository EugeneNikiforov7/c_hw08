// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[] SortArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
    int maxIndex = j;
    int maxValue = arr[j];
    int temp = 0;
        for (int i = j; i < arr.Length; i++) 
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
                maxIndex = i;
            }  
        }
        temp = arr[j];
        arr[j] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
    return arr;
}

void SortArrayRow(int[,] arr)
{
    int[] tempRow = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) tempRow[j] = arr[i, j];
        SortArray(tempRow);
        for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = tempRow[j];
    }
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
SortArrayRow(doubleArray);
Console.WriteLine("Отсортированный массив: ");
PrintDoubleArray(doubleArray);