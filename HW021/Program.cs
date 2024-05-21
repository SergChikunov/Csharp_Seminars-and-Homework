/*ДЗ семинар 6. Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/


string CreateStringFromCharArray(char[,] matrix)
{
    string reslultString = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            reslultString += matrix[i, j];
        }
    }
    return reslultString;
}

void PrintMatrix(char[,] matrix) //печать двумерного массива
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

char[,] table = { { 'a', 'b', 'c', 'd' }, { 'e', 'f', 'g', 'h' } };
Console.WriteLine("Исходный массив символов: ");
PrintMatrix(table);
string stringFromArray = CreateStringFromCharArray(table);
Console.WriteLine();
Console.Write("Строка из символов массива: " + stringFromArray);
