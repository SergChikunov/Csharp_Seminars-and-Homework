/* Семинар 5. Задание 2. Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

int[,] CreateTwoDimArray(int rowsCount, int columnsCount) //в методе создаем двумерный массив
{
	int[,] array = new int[rowsCount, columnsCount];
	Random rnd = new Random();
    //Console.WriteLine("Укажите начало диапазона случайного числа: ");
    //int startNum = int.Parse(Console.ReadLine());
    //Console.WriteLine("Укажите окончание диапазона случайного числа: ");
    //int endNum = int.Parse(Console.ReadLine());
	for(int i = 0; i < array.GetLength(0); i++) //заполнение массива данными, в i цикле заполняем первое измерение - перебираем строки
	{
		for(int j = 0; j < array.GetLength(1); j++) //заполнение массива данными, в j цикле заполняем второе измерение - перебираем элементы в строках
		{
			array[i, j] = rnd.Next(1, 16);
		}
	}
	return array;
		
}

int FindSumFromMainDiag(int[,] array) //в методе определяем сумму элементов по главной диагонали
{
	int sum = 0; //переменная которая будет аккумулировать сумму элементов
    for(int i = 0; i < array.GetLength(0); i++) //задание строки
	{
		for(int j = 0; j < array.GetLength(1); j++) //перебор элементов текущей строки
		{
			if(i == j) //если номер строки и позиция элемента совпадают по индексу прибавляем значение элемента к сумме
			{
				sum = sum + array[i, j];
			}
		}
	}
	return sum;
}

void ShowArray(int[,] matrix) //вывод массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
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
int resultSum = FindSumFromMainDiag(arrDim2);
Console.WriteLine("\nСумма элементов массива по главной диагонали: " + resultSum);
