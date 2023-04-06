// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows1 = InputNumbers("Введите число строк 1-й матрицы: ");
int column = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int columns2 = InputNumbers("Введите число столбцов 2-й матрицы: ");




void MultiplyMatrix(int[,] matr1, int[,] matr2, int[,] matrres)
{
  for (int i = 0; i < matrres.GetLength(0); i++)
  {
    for (int j = 0; j < matrres.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum += matr1[i,k] * matr2[k,j];
      }
      matrres[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


int[,] firstMartrix = new int[rows1, column];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[column, columns2];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[rows1,columns2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);




