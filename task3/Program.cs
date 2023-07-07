// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
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
    
int [,] ResultingMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
    }
    return arrayC;
}

int[,] firstArray = Creat2DArray(5,5,0,10);
int[,] secondArray = Creat2DArray(5,5,0,10);
Show2DArray(firstArray);
Show2DArray(secondArray);
Show2DArray(ResultingMatrix(firstArray,secondArray));
