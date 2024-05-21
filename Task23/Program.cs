

string strValue = "поиск гласных букв в строке";
char[] vowelsLellers = new char[] {'а','е','ё','и','о','у','ы','э','ю','я'};
string tmpValue = "";
int count = 0;
for(int i = 0; i < strValue.Length; i++)
{
    if(vowelsLellers.Contains(strValue[i])) //метод Contains определяет, содержится ли символ strValue[i] в списке гласных букв
    {
        tmpValue = tmpValue + strValue[i];
        count++;
    }
}

Console.WriteLine();
Console.Write("Исходная строка: " + strValue);
Console.WriteLine();
Console.WriteLine(new string('=', 70));
Console.Write("Найдено гласных букв в исходной строке: " + count);
Console.WriteLine();
Console.WriteLine(new string('=', 70));
Console.Write("Найденные гласные в строке, в порядке появления в исходной строке: " + tmpValue);
Console.WriteLine();