/* ДЗ Семинар 5. Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
//далее надо найти сумму по строке
//затем сравнить суммы всех строк и выбрать наименьшую
int SumOfRowInArray(int[,] matrix)
{
	int[] array = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;    //аккумулируем сумму элементов строки в этой переменной
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
	//затем сравнить суммы всех строк и выбрать наименьшую
	int minValue = array[0];
	int minRow = 0;
	for(int i = 1; i < array.Length; i++)
	{
		if(array[i] < minValue) 
		{
			minValue = array[i];
			minRow = i;
		}
	}
	return minRow;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(array2d);

Console.WriteLine();
int rowWithMinValue = SumOfRowInArray(array2d);
Console.WriteLine("Строка с минимальным значением суммы элементов: " + rowWithMinValue);
