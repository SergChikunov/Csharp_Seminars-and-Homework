/* Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

int[] GetArray() //в методе формируем массив из случайно сгенерированных элементов
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine()); //задаем количество элементов в массиве
    Random rnd = new Random(); // подключаем генератор случайных чисел
    int[] arr = new int[size]; // объявляем массив из заданного количества элементов
    for(int i =0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000); // заполняем массив случайными трехзначными числами
    }
    return arr;
}

int CountEvenElements(int[] array) //метод считаеи количество элементов в массиве
{
    int count = 0; //в переменной храним количество четных элементов
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr) //метод выведет содержимое массива в консоль
{
    Console.WriteLine("Исходный масcив: ");
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
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
int countEven = CountEvenElements(mainArray);
PrintArray(mainArray);
Console.WriteLine("\n\nКоличество четных элементов в массиве равно: " + countEven);
