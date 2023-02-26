// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}
int [,] InitSpiralMatrix (int m)
{
  int[,] spiralMatrix = new int[m, m];

  int temp = 1;
  int i = 0;
  int j = 0;

  while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
  {
    spiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
      j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
      i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
      j--;
    else
      i--;
  }
  return spiralMatrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = GetNumber("Введите целое число (количество строк и стобцов) для создания квадратной матрицы ");
Console.WriteLine();
int [,] spiralMatrix = InitSpiralMatrix(m);
PrintMatrix(spiralMatrix);