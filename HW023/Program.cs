/* Семинар 6. ДЗ задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом (слово, которе читается одинаково в обеих направлениях). */

string GetStringFromConsole() // в этом варианте перевод строки в нижний регистр используя встроенный метод в C#
{
    Console.WriteLine("Введите слово, затем нажмите Enter...");
    string? inputStr = Console.ReadLine();
    return inputStr;
}

bool IsPalindrom(string strVal)
{
    int lastIndexChar = strVal.Length - 1; //strVal.Length - 1 - это индекс последнего элемента с конца строки!!! Сделал так чтобы не усложнять код
    if(strVal[0] != strVal[lastIndexChar]) return false; //если первый и последний символ строки не совпадают, то дальше можно не проверять
    for(int i = 1, j = lastIndexChar - 1; i < (strVal.Length - 2) / 2; i++) //если первый и последний символы совпали проверяем оставшиеся
    {
        if(strVal[i] != strVal[j]) return false; //по i идем со 2 символа строки на возрастание, по j идем с предпоследнего символа на убывание
        j--;
    }
    return true; //по итогу, если все проверки на палиндром прошли, то возвращаем значение истина
}

string inputStr = GetStringFromConsole();
bool isStringPalindrom = IsPalindrom(inputStr);
Console.WriteLine();
if(isStringPalindrom == true)
{
    Console.WriteLine("Введенная слово - палиндром!");
}
else
{
    Console.WriteLine("Введенное слово не является палиндромом!");
}