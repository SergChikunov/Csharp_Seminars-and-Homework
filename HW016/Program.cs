/*Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)*/

int[] GetArray() //в методе формируем массив из случайно сгенерированных элементов
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine()); //задаем количество элементов в массиве
    Random rnd = new Random(); // подключаем генератор случайных чисел
    int[] arr = new int[size]; // объявляем массив из заданного количества элементов
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 1000); // заполняем массив случайными числами
    }
    return arr;
}

void SwapElementsInArray(int[] array, int i, int j) //метод взаимно переставляет элементы массива, т.к. массивы передаются по ссылке, я не стал указывать возвр значение в столь простом методе
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

int[] RevertArrayElements(int[] arr)
{
    int left = 0; //индекс начального элемента
    int right = arr.Length - 1; //индекс конечного элемента

    while (left < right) //выполняем цикл, пока не достигнем середины массива
    {
        SwapElementsInArray(arr, left, right); //меняем элементы местами
        right--; //приращение счетчиков
        left++; //приращение счетчиков
    }
    return arr;
}

void PrintArray(int[] arr) //метод выведет содержимое массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.Write("]");
}

int[] mainArray = GetArray();
Console.WriteLine("Исходный массив: ");
PrintArray(mainArray);
mainArray = RevertArrayElements(mainArray);
Console.WriteLine("\n\nПеревернутый массив: ");
PrintArray(mainArray);
