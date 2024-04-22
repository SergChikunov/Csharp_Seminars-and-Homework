/* Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1 */

Console.Write("Введеите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int SecondNum = num / 10 % 10;
    // int firstNum = num / 10;
    int thirdNum = num % 10;
    int result = SecondNum;
    
    for (int i = 1; i < thirdNum; i++)
    {
        result = result * SecondNum;
    }
    // result = firstNum * thirdNum;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорретный ввод!");
}