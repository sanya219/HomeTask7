/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GenerateArray2DDbl (int rows, int cols, int min, int max)
{
    double[,] array = new double[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            array[i, j] += new Random().NextDouble(); 
        }
    return array;
}

void PrintArray2DDbl (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + Math.Round(array[i, j], 1) + "\t");
        Console.Write("\n");
    }
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimal integer value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal integer value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray47 = GenerateArray2DDbl(rows, cols, min, max);
PrintArray2DDbl(myArray47);

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

int[,] GenerateArray2DInt (int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray2DInt (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + "\t");
        Console.Write("\n");
    }
}

int GetArrayElement(int row, int col, int[,] array)
{
    return array[row, col];
}

Console.Write("Enter number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimal value: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal value: ");
max = Convert.ToInt32(Console.ReadLine());
int[,] myArray50 = GenerateArray2DInt(rows, cols, min, max);
PrintArray2DInt(myArray50);
Console.Write("Enter number of the row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of the column: ");
int col = Convert.ToInt32(Console.ReadLine());
if(row < 0 || col < 0 || row >= rows || col >= cols)
    Console.WriteLine($"Entered element [{row}, {col}] does not exist!");
else
{
    int element = GetArrayElement(row, col, myArray50);
    Console.WriteLine($"Element [{row}, {col}] = {element}");
}

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double GetRowAverage(int[,] array, int rowIndex)
{
    double result = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        result += array[rowIndex, i];
    return result / array.GetLength(1);
}

Console.Write("Enter number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimal value: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal value: ");
max = Convert.ToInt32(Console.ReadLine());
int[,] myArray52 = GenerateArray2DInt(rows, cols, min, max);
PrintArray2DInt(myArray52);
Console.Write("Average of each column is: ");
for(int i = 0; i < rows; i++)
    Console.Write(GetRowAverage(myArray52, i) + " ");


