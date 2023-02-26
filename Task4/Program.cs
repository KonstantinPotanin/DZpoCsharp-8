// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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

int [,,] Get3DArray(int a)
{
    int[,,] array = new int[a, a, a];
    int number = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += number;
                number ++;
            }
        }
    }
    return array;
}

void PrintArrayWithIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int a = GetNumber("Введите целое число для создания трёхмерного массива ");
Console.WriteLine();
int [,,] array3D = Get3DArray(a);
PrintArrayWithIndex(array3D);