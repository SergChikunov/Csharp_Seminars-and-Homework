/* апишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
Примеры
a = 256  => 26
a = 891  => 81*/

Console.Write("Введеите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstNum = num / 100;
    int thirdNum = num % 10;
    int result = firstNum * 10 + thirdNum;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорретный ввод!");
}