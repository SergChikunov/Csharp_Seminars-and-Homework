/*ДЗ Семинар 5. Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.*/

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

void FindElementAboutIndex(int[,] table, int row, int column) // SumMainDiagonal(int[,] matrix)
{
    if (table.GetLength(0) < row || table.GetLength(1) < column)
    {
        Console.WriteLine("Элемента с таким индексом в массиве не существует, работа программы закончена!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Значение элемента с указанным индексом: " + table[row, column]);
    }
    
}

int ConvertToInt(string str) //метод пытается сконвертировать введенное в консоли значение в целое число
{
    int number = 0; //сюда и поместим результат конверсии переменной
    bool isNum = false;
    if (isNum = int.TryParse(str, out int tempNum))
    {
        number = int.Parse(str);
    }
    else
    {
        Console.WriteLine("Ожидалось числовое значение, программа завершит работу!");
        Environment.Exit(0);
    }
    return number;
}

Console.WriteLine("Введите число строк в массиве: ");
string? rowsHow= Console.ReadLine();
int rowsArr = ConvertToInt(rowsHow);
//---------------------------------------------------
Console.WriteLine("Введите число столбцов в массиве: ");
string? columnsHow = Console.ReadLine();
int columnsArr = ConvertToInt(columnsHow);
//---------------------------------------------------
Console.WriteLine("Введите стартовую позицию генерации случайного числа: ");
string? minBond = Console.ReadLine();
int minBondRnd = ConvertToInt(minBond);
//---------------------------------------------------
Console.WriteLine("Введите конечную позицию генерации случайного числа: ");
string? maxBond = Console.ReadLine();
int maxBondRnd = ConvertToInt(maxBond);
//---------------------------------------------------
Console.WriteLine("Введите индекс строки массива для поиска элемента: ");
string? rowValue = Console.ReadLine();
int rowSearch = ConvertToInt(rowValue);
//---------------------------------------------------
Console.WriteLine("Введите индекс столбца массива для поиска элемента: ");
string? columnValue = Console.ReadLine();
int columnSearch = ConvertToInt(columnValue);
//---------------------------------------------------



int[,] array2d = CreateMatrixRndInt(rowsArr, columnsArr, minBondRnd, maxBondRnd);
PrintMatrix(array2d);

Console.WriteLine();

FindElementAboutIndex(array2d, rowSearch, columnSearch);
