// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

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

void SumRowArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                sum = sum + arr [i,j];
            }
            Console.WriteLine($"{sum}");
        }
}

int [,] currentArray = Creat2DArray (5, 5, 0, 10);
Show2DArray (currentArray);
SumRowArray (currentArray);
