/*Семинар 5. Задание 3. Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //создание двумерного массива
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
            Console.Write($"{matrix[i, j],5}"); //здесь число 5 послв элемента массива - количество знаков для размещения элемента массива
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]:F2}, "); //:F2 - округление до двух знаков после запятой
        else
            Console.Write($"{array[i]:F2}");
    }
     Console.Write("]");
}

double[] GetAverageArrayRows(int[,] matrix) //т.к. в методе есть операция деления, то тип результата должен быть вещественным
{
    double[] array = new double[matrix.GetLength(0)]; //в массив записываем значния среднего арифметического по каждй строке, поэтому double
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;    //аккумулируем сумму элементов строки в этой переменной
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1); //здесь (double) - явное преобразование типа переменной, присваиваем ср арифм элементу массива
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

double[] result = GetAverageArrayRows(array2d);
PrintArray(result);
