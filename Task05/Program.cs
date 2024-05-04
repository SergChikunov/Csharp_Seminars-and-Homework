int secondChar;
string s2;
string delNumTwo;
do
{
    Console.WriteLine("Введите число состояшее минимум из трех знаков: ");
    s2 = Console.ReadLine(); // "465"
} while (s2.Length < 3 && s2.Length > 3);

secondChar = s2.Length - 2; // Длина строки, минус два - второй символ в строке

// int NumberOne = Convert.ToInt32(s2.Substring(0, 1));
// int NumberTwo = Convert.ToInt32(s2.Substring(lengthString, 1));
// int SumResult = NumberOne + NumberTwo;

delNumTwo = s2.Remove(secondChar);

Console.WriteLine("Удаленный символ: " + delNumTwo);
Console.WriteLine("Число после удаления второго символа: " + s2);

