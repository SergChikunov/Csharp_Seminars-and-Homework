/* Семинар 5. Задание 1. Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

int[,] CreateTwoDimArray(int rowsCount, int columnsCount)
{
	int[,] array = new int[rowsCount, columnsCount];
	Random rnd = new Random();
	for(int i = 0; i < array.GetLength(0); i++) //заполнение массива данными, в i цикле заполняем первое измерение - перебираем строки
	{
		for(int j = 0; j < array.GetLength(1); j++) //заполнение массива данными, в j цикле заполняем второе измерение - перебираем элементы в строках
		{
			array[i, j] = rnd.Next(1, 100);
		}
	}
	return array;
		
}

int[,] FindEvenIndexesAndTheirReplace(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			if(i % 2 == 0 && j % 2 == 0)
			{
				array[i, j] = array[i, j] * array[i, j];
			}
		}
	}
	return array;
}

void ShowArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t"); //подобный вывод называется интерполяция строк
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте число строк в массиве: ");
int rowsCount = int.Parse(Console.ReadLine());
Console.Write("\nЗадайте число столбцов в массиве: ");
int columnsCount = int.Parse(Console.ReadLine());
int[,] arrDim2 = CreateTwoDimArray(rowsCount, columnsCount);
Console.WriteLine("\nСформированный массив:");
ShowArray(arrDim2);
arrDim2 = FindEvenIndexesAndTheirReplace(arrDim2);
Console.WriteLine("\nОбработанный массив:");
ShowArray(arrDim2);