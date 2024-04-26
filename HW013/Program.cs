﻿/*
задача_4
Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
*/
int num = 0;
do  // циклом ограничиваем диапазон ввода числа
{
    Console.Write("Введите число от 1 до 100000: ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num < 1 || num > 100000);

int numCopy = num;  // копируем введенное число во вспомогательную переменную
int count = 0;  // переменная счетчик
int divisorVar = 1; // в этой переменной будем хранить разрядность введенного числа

while (numCopy != 0) // считаем количество цифр в числе
{
    numCopy /= 10; // последовательно делим число на десять, до достижения 0, это позволит нам узнать количество разрядов введенного числа
    count++;    // эта переменная счетчик цикла, в дополнение количество итераций цикла - разрядность введенного числа
}

int[] arr = new int[count]; // создаем массив на количество цифр
for (int j = 1; j < count; j++)
{
    divisorVar *= 10; //согласно посчитанным цифрам числа определяем его разрядность
}

arr[0] = num / divisorVar; // первый элемент массива можем получить сразу, разделив число на найденную его разрядность

int index = 1; // эта переменная будет служить индексом элемента массива, т.к. первый элемент массива уже получен, то начинаем индексацию с 1
int ostatok;    // в эту переменную будем заносить остаток от деления числа на его разрядность: 10, 100, 1000, 10000, 100000

while (divisorVar > 1)  // пока разрядность больше чем 1 выполняем цикл
{
    ostatok = num % divisorVar; //делим число на разрядность, получаем остаток от деления
    divisorVar /= 10;   // уменьшаем разрядность числа в десять раз
    arr[index] = ostatok / divisorVar; //определяем элемент очередной элемент массива
    index++;
}

Console.Write("[");
for (int i = 0; i < arr.Length; i++)    //далее следует вывод массива в консоль
{
    if (i == arr.Length - 1)
    {
        Console.Write(arr[i] + "]");
    }
    else
    {
        Console.Write(arr[i] + ", ");
    }
}
