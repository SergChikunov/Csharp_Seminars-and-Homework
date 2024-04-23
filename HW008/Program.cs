// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num;

do
{
    Console.WriteLine("Введите целое число из диапазона от 10 до 99: ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num < 10 || num > 99);

int firstDigit = num / 10;
int secondDigit = num % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine("Наибольшая цифра в веденном числе: " + firstDigit);
}
else
{
    Console.WriteLine("Наибольшая цифра в веденном числе: " + secondDigit);
}
