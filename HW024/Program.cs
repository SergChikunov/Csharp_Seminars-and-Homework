/* Семинар 6. ДЗ задача 4: Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, 
в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами. */


string GetStringFromConsole() //получаем строку с консоли
{
    Console.WriteLine("Введите строку из нескольких слов, разделенных пробелами, затем нажмите Enter...");
    string? inputStr = Console.ReadLine();
    return inputStr;
}

string ReverseWord(string strNew) //формируем строку в которой все слова идут в обратном порядке, относительно исходной
{
    string[] strNewSplit = strNew.Split(); //используем метод Split, пустые скобки в нем означают, что делим строку по пробелам
    string res = ""; //в эту переменную будет записан результат работы кода
    for (int i = strNewSplit.Length - 1; i >= 0; i--) //обратный цикл, т.к. слова надо записать в обратном порядке
    {
        res += strNewSplit[i] + " "; //вставили слово и добавили пробел
    }

    return res;
}

string strNew = GetStringFromConsole();
string res = ReverseWord(strNew);
Console.WriteLine(res);