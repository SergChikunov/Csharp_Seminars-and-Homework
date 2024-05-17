/* ДЗ Семинар 5. Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 3x4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

int[,] ReplaceRowsInTable(int[,] matrix)
{
    int rowFirst = 0;
    int rowLast = matrix.GetLength(0) - 1;
    int index = 0;
    int tempValue = 0;
    while(index < matrix.GetLength(1))
    {
        tempValue = matrix[rowFirst, index];
        matrix[rowFirst, index] = matrix[rowLast, index];
        matrix[rowLast, index] = tempValue;
        index++;
    }
    return matrix;
}


int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(array2d);

Console.WriteLine();

array2d = ReplaceRowsInTable(array2d);
Console.WriteLine("Массив после замены строк: ");
PrintMatrix(array2d);

Console.WriteLine();
