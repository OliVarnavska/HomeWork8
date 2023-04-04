// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Сумма элементов строки {i}: {arr[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int [] FindSum (int [,] matr)
{
    int [] sumstr = new int [matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
        sumstr[i] += (matr[i, j]);
      }  
    } 
   
    return sumstr;
}

int FindMinSum(int[] arr)
{
    int find = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];

    }
    return min;
}

int IndexOf (int [] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            return i;
        }
    }
    return -1;
}


int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int[] array = FindSum(matrix);
PrintArray1(array);
int min = FindMinSum(array);
int index = IndexOf(array, min);
Console.WriteLine($"Индекс строки с нименьшей суммой элементов: {index}");





