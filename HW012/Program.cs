/* Задача 3.

Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Начальные условия:

int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива

Выводится: 5.15
*/

double[] array = new double[10] { 2.3, 5.45, 2.8, 3.6, 6.34, 3.114, 7.7, 8.1, 2.15, 4.7 };
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++) //определяем мин значение
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Минимальное значение: " + min);


for (int j = 0; j < array.Length; j++) //определяем макс значение
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine("Максимальное значение: " + max);


double resultMinMax = max  min;
Console.WriteLine("Разность между минимальным и максимальным значениями составляет: " + resultMinMax);
