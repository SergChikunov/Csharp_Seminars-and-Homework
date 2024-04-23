// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0 && num != 0)
{
    Console.WriteLine("Введено число кратное 7 и 23, это число: " + num);
}
else if (num == 0)
{
    Console.WriteLine("Введен 0");
}
else
{
    Console.WriteLine("Введено число не кратное 7 и 23, это число: " + num);
}
