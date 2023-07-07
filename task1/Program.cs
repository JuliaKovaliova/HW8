// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
/* 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] Creat2DArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] array2D = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array2D [i,j] = new Random().Next(minValue,maxValue);
        }
    return array2D;
}

void Show2DArray ( int [,] array)
{   
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] SortDescendingRow2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int [,] currentArray = Creat2DArray (5, 5, 0, 10);
Show2DArray (currentArray);

int [,] newArray = SortDescendingRow2DArray (currentArray);
Show2DArray (currentArray);