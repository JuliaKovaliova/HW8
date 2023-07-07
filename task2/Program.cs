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

int SumRow2dArray (int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

int [,] currentArray = Creat2DArray(5,5,0,10);
Show2DArray(currentArray);


int rowMinSum = 1;
int sum = SumRow2dArray(currentArray, 0);
for (int i = 1; i < currentArray.GetLength(0); i++)
{
    if (sum > SumRow2dArray(currentArray, i))
    {
        sum = SumRow2dArray(currentArray, i);
        rowMinSum = i+1;
    }
}
Console.WriteLine($"The row with the smallest sum of elements: {rowMinSum}");




