// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] InitMatrix(int m)
{
    int[,] array = new int[m,m];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,5);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ResultMatrix (int [,] matrix1, int [,] matrix2)
{
    int [,] resultMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                resultMatrix[i,j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
                }
            }
        }
    }
    return resultMatrix;
}

int m = GetNumber("Введите целое число (количество строк и стобцов) для создания двух квадратных матриц ");
Console.WriteLine();
int [,] firstMatrix = InitMatrix(m);
int [,] secondMatrix = InitMatrix(m);
PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);
int [,] result = ResultMatrix(firstMatrix, secondMatrix);
PrintMatrix(result);
