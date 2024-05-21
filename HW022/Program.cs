/*ДЗ семинар 6. Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/

/* В этом варианте посимвольный перевод строки в нижний регистр
string UpperToLower(string str)
{
    string strResult = string.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            strResult += char.ToLower(str[i]);
        }
        else
        {
            strResult += str[i];
        }
    }
    return strResult;
}


string str = "aBcD1ef!-";
string strResult = UpperToLower(str);
Console.WriteLine(strResult);
*/

string GetStringFromConsole() // в этом варианте перевод строки в нижний регистр используя встроенный метод в C#
{
    Console.WriteLine("Введите строку, которая содержит латинские буквы в обеих регистрах! Затем нажмите Enter...");
    string inputStr = Console.ReadLine();
    return inputStr;
}

string resultStr = GetStringFromConsole();
Console.Write("Введенная строка: " + resultStr);
resultStr = resultStr.ToLower();
Console.Write("\nСтрока после обработки кода: " + resultStr);