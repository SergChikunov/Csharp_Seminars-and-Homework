/* Домашнее задание
Лекция 4.
Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать массив, состоящий
из цифр этой строки.
Пример
abc123def06g => [1, 2, 3, 0, 6]
Рекомендации
• Разделить логику алгоритма на функции
• Память под массив выделять необходимого размера (не больше, чем количество элементов)*/

bool IsTheDigit(char s) //метод определяет является ли переданный в него символ цифрой от 0 до 9
{
    if (Char.IsAsciiDigit(s) == true) return true;
    return false;
}
int CountArraySize(string str) //метод определяет количество символов в заданной строке являющимися цифрами, это и будет размер массива
{
    int count = 0;
    foreach (char c in str)
    {
        if (Char.IsAsciiDigit(c) == true) count++;
    }
    return count;
}
int[] GetNumericArrayFromString(string str) //формируем массив в методе
{
    int count = CountArraySize(str); //задаем размер массива
    if (count == 0) //если метод вернет 0, значит цифр в строке нет, выполняем соответствующее действие
    {
        Console.WriteLine("Во введенной строке нет цифр, программа завершает работу!");
        Environment.Exit(0); //полное завершение кода, с возвратом 0 кода ошибки
    }
    int[] arr = new int[count]; //объявляем массив размерности count, это количество цифр в строке,
    bool isDigit; //в переменной будем сохранять значение работы метода определяющего значение очередного символа
    int index = 0; //эта переменная будет служить нам индексом массива
    int tempNum;    //временная переменная для хранения результата преобразования, перед помещением значения в массив
    for (int i = 0; i < str.Length; i++) //проходим по символам строки
    {
        isDigit = IsTheDigit(str[i]); //проверяем текущий символ строки
        if (isDigit == true) //если текущий символ является цифрой          (&& index < count) пока не понял надо ли отслеживать индекс, вроде нет!!!
        {
            tempNum = (int)Char.GetNumericValue(str[i]); //то преобразуем его в десятичную цифру, (метод подсмотрен на stackoverflow.com)
            arr[index] = tempNum; //и помещаем в массив на соответствующую позицию
            index++; //выполняем приращение индекса массива, подготавливая массив к следующей итерации
        }
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("Массив цифр полученный из введенной строки:");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите строку состоящую из букв и цифр и нажмите Enter...");
string? inputStr = Console.ReadLine();
int[] array = GetNumericArrayFromString(inputStr);
PrintArray(array);
