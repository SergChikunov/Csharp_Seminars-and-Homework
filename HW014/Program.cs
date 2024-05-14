/*
 Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.
*/

int GetInputAndCheckValid() //запрос числа с консоли и проверка корректности введенного значения
{
    int number; //переменная в которую поместим введенное число
    string inputVal; //строковая переменная в которую сохраним ввод с консоли, т.к. нам надо будет отследить ввод символа q
    bool isWhatInput = false; //в этой переменной сохраним результат работы метода, который проведет проверку на четность
    do //цикл будет выполняться, пока не будет введено значение из допустимого диапазона
    {
        inputVal = Console.ReadLine();
        if (inputVal == "q") //отслеживаем нажатие клавиши q
        {
            PrintMessageAndExit();
        }
        number = Convert.ToInt32(inputVal);
        isWhatInput = CheckSumForEvens(number); //вызов метода проверки суммы цифр на четность
        if (isWhatInput == true) //отслеживаем четное значение суммы цифр числа
        {
            PrintMessageAndExit();
        }

    } while (number < 0 || number > 65535); //ограничим ввод значениями от 0 до 65535
    return number;
}

void PrintMessageAndExit() //вывод сообщения и завершение программы
{
    Console.WriteLine("Программа завершает работу, т.к. введен символ q или сумма цифр числа четная!");
    Environment.Exit(0); //подсмотрено в сети, как завершить программу и выйти
}

bool CheckSumForEvens(int number) //метод проверки суммы цифр числа на четность
{
    bool isEvenNnm = false;
    int count = 0;
    int sumVal = 0;
    if (number < 10 && number % 2 == 0)
    {
        isEvenNnm = true;
    }
    else
    {
        count = FindDigitCapacityOfNum(number); //в переменной сохраняем результат работы метода для определения разрядности введенного числа
        sumVal = GetSumDigitOfNumber(number, count); //в переменной сохраним результат работы метода, который суммирует цифры введенного числа
        if (sumVal % 2 == 0)
        {
            isEvenNnm = true;
        }
    }
    return isEvenNnm;
}

int FindDigitCapacityOfNum(int number) //метод определения разрядности числа
{
    int count = 0; //переменная накопитель значения разрядности числа
    while (number > 0)
    {
        number /= 10;
        count++;
    }

    return count;
}

int GetSumDigitOfNumber(int number, int count)
{
    int sum = 0; //сумма цифр числа
    int currDigit; //текущая цифра числа
    while (count > 0) //определеяем цифры числа и их сумму
    {
        currDigit = number % 10; //остаток от деления на 10 - очередная цифра числа
        sum = sum + currDigit; //аккумулируем сумму цифр
        number = number / 10; //последовательно уменьшаем число на 10
        count--; // переменная, в которую записывали разрядность уже выступает в качестве счетчика цикла, задавая количество итераций
    }
    return sum;
}

Console.WriteLine("Вводите непрерывно целые, неотрицательное числа, со значением не более 65535, и после ввода числа нажимайте Enter... ");
while (true)
{
    int num = GetInputAndCheckValid();
}
