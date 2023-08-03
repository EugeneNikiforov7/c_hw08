// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] arr)
{
    int f = 1;
    int n = 0;
    while (n < arr.GetLength(0) / 2)
    {
    for (int i = 0 + n; i < arr.GetLength(0) - n; i++) arr[n, i] = f++;
    for (int i = 1 + n; i < arr.GetLength(1) - n; i++) arr[i, arr.GetLength(1) - 1 - n] = f++;
    for (int i = n + 1; i < arr.GetLength(0) - n; i++) arr[arr.GetLength(1) - 1 - n, arr.GetLength(1) - 1 - i] = f++;
    for (int i = n + 1; i < arr.GetLength(0) - n - 1; i++) arr[arr.GetLength(1) - 1 - i, n] = f++;
    n++;
    }
    if (arr.GetLength(0) % 2 != 0) arr[arr.GetLength(0) / 2, arr.GetLength(1) / 2] = arr.GetLength(0) * arr.GetLength(1);
}

void PrintDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j].ToString().PadLeft(4));
            Console.WriteLine();
    }
}

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetNum("Введите размер массива: ");
int[,] array = new int[num, num];
FillArray(array);
PrintDoubleArray(array);