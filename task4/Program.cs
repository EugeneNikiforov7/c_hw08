// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetNoDuplicateValue(int n1, int n2, int n3, int[,,] arr)
{
    temp = new Random().Next(10, 100);
    for (int i = 0; i < n1; i++)
        for (int j = 0; j < n2; j++)
            for (int k = 0; k < n3; k++)
            {
                arr[i, j, k] = GetNoDuplicateValue(i, j, k);
            }
}

void PrintTripleArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillTripleArray(int[,,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = GetNoDuplicateValue(i, j, k, arr);
            }
}

int GetNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetNum("Введите количество строк массива: ");
int num2 = GetNum("Введите количество колонок массива: ");
int num3 = GetNum("Введите размер третей координаты массива: ");
int[,,] tripleArray = new int[num1, num2, num3];
FillTripleArray(tripleArray);
PrintTripleArray(tripleArray);