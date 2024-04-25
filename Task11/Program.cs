/* задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные. */

int[] array = new int[20];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < 20; i++)
{
    array[i] = i - 10;
    Console.Write(array[i] + " ");
}
Console.Write("\n");

Console.WriteLine("Обработанный массив: ");

for (int j = 0; j < array.Length; j++)
{
    if (array[j] < 0)
    {
        array[j] = array[j] * -1;
    }
}

for (int k = 0; k < array.Length; k++)
{
    Console.Write(array[k] + " ");
}
