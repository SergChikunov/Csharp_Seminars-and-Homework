int lengthString = 0;
string s2 = " ";
do
{
    Console.WriteLine("Введите число состояшее минимум из двух знаков: ");
    s2 = Console.ReadLine(); // "465"
} while (s2.Length < 2);

// Console.WriteLine("Substring start at pos 1 (1 chars): " + s2.Substring(0, 1));
lengthString = s2.Length - 1; // Длина строки, минус единица - последний символ в строке
// Console.WriteLine("Substring start at last pos (1 chars): " + s2.Substring(lengthString, 1));

int NumberOne = Convert.ToInt32(s2.Substring(0, 1));
int NumberTwo = Convert.ToInt32(s2.Substring(lengthString, 1));
int SumResult = NumberOne + NumberTwo;

Console.WriteLine("Первая цифра введенного числа: " + s2.Substring(0, 1));
Console.WriteLine("Последняя цифра введенного: " + s2.Substring(lengthString, 1));
Console.WriteLine("Сумма первого и последнего чисел составляет: " + SumResult);
