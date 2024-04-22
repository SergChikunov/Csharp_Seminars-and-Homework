/*Напишите программу, которая будет принимать на вход два
числа и выводить, является ли первое число кратным второму.
Если первое число не кратно второму, то программа выводит
остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1 */

Console.Write("Введеите первое число: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите второе число: ");
int num02 = Convert.ToInt32(Console.ReadLine());

int ostatok = num01 % num02;

if (ostatok == 0)
{
    Console.WriteLine("Числа кратны!");
}
else
{
    Console.WriteLine("Числа не кратны! Остаток от деления равен: " + ostatok);
}