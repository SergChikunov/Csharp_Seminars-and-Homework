/* Напишите  программу,  которая  принимает  на  вход трёхзначное целое число и на выходе показывает 
сумму первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17
if(a[0] == 'я') 
int.Parse(NumStr01.ToString())
int.Parse(NumStr03.ToString()) 
string str = c.ToString();
    string ex = s.ToString();

    Console.WriteLine(Int32.Parse(str)); 

Console.WriteLine("Введите целое трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

string? NumStr = Console.ReadLine();
char NumStr01 = NumStr[0];
Console.WriteLine(NumStr01);
char NumStr02 = NumStr[1];
Console.WriteLine(NumStr02);
char NumStr03 = NumStr[2];
Console.WriteLine(NumStr03);

string NumString01 = NumStr01.ToString();
string NumString02 = NumStr03.ToString();

int Num01 = Convert.ToInt32(NumString01);
int Num02 = Convert.ToInt32(NumString01);

Console.WriteLine(Num01);
Console.WriteLine(Num02);

int SumResult = Num01 + Num02;

Console.WriteLine("Сумма первой и последней цифры введенного числа равна: ", SumResult);
*/
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) //if (num > 99 && num < 1000)
{
    int firstDigit = num / 100; //456/10=4.56 Делим трехзначное число на 100, а так как переменная объявлена целочисленного типа, то сразу получаем первую цифру числа
    int lastDigit = num % 10; // 456 % 10=450+6 Делим число на 10, остаток от деления и есть последняя цифра введенного числа

    int result = firstDigit + lastDigit;

    Console.WriteLine($"Сумма первой и последней цифры трехзначного числа = {result}");
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное.");
}
