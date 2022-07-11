/* Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

    }
    Console.WriteLine();
}

void FindArrayElement(int[,] array, int rowPos, int columnPos)
{
    int row = rowPos - 1;
    int column = columnPos - 1;
    if (row < array.GetLength(0) && column < array.GetLength(1)) 
    {
        Console.WriteLine($"Элемент на позиции ({rowPos}, {columnPos})равен: {array[row, column]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет!");
    }
}

int rows = Promt("Введите количество строк: ");
int columns = Promt("Введите количество столбцов: ");

int row = Promt("Введите номер строки: ");
int column = Promt("Введите номер столбца: ");

int[,] matrix = GenerateArray(rows, columns, 1, 100);
PrintArray(matrix);
Console.WriteLine();
FindArrayElement(matrix, row, column);