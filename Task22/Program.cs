/*
На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
Указание - Метод строки ToCharArray() не использовать.
Пример  “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
*/

char[] ArrayFromString(string str)
{
    char[] strArray = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        strArray[i] = str[i];
    }
    return strArray;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
     Console.Write("]");
}

Console.WriteLine("Введите строку: ");
string inputValue = Console.ReadLine();
char[] result = ArrayFromString(inputValue);
PrintArray(result);
