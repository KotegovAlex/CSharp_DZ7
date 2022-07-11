/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble() * new Random().Next(100*min, max+1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)}\t");
        }

    }
    Console.WriteLine();
}

int rows = Promt("Введите количество строк: ");
int columns = Promt("Введите количество столбцов: ");

double[,] matrix = GenerateArray(rows, columns, 1, 100);
PrintArray(matrix);