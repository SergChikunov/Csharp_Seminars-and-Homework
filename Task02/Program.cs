﻿/* Напишите  программу,  которая  на  вход  принимает целое  число  N,  а  на  выходе  показывает  все 
 целые числа в промежутке от -N до N.
Примеры
4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
2 => -2, -1, 0, 1, 2
15 */

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumMinus = num * (-1);
while (NumMinus <= num)
{
    Console.WriteLine(NumMinus);
    NumMinus = NumMinus + 1;
}