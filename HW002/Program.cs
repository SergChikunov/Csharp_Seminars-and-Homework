int firstNumber;
int secondNumber;
int thirdNumber;
int maxNumber;


Console.WriteLine("Введите первое число, нужно ввести именно число (!!!): ");
string? readNumOne = Console.ReadLine();

bool isNumeric01 = int.TryParse(readNumOne, out firstNumber); //проверка является ли ввод целым числом для первого числа, т.е. нам требуется значение True
firstNumber = Convert.ToInt32(readNumOne);

Console.WriteLine("\nВведите второе число, нужно ввести именно число (!!!): ");
string? readNumTwo = Console.ReadLine();

bool isNumeric02 = int.TryParse(readNumTwo, out secondNumber); //проверка является ли ввод целым числом для второго числа, т.е. нам требуется значение True
secondNumber = Convert.ToInt32(readNumTwo);

Console.WriteLine("\nВведите третье число, нужно ввести именно число (!!!): ");
string? readNumThree = Console.ReadLine();

bool isNumeric03 = int.TryParse(readNumThree, out thirdNumber); //проверка является ли ввод целым числом для второго числа, т.е. нам требуется значение True
thirdNumber = Convert.ToInt32(readNumThree);

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30)); //Console.WriteLine(new string('.', 10));
Console.WriteLine(firstNumber);
Console.WriteLine(isNumeric01);

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30));
Console.WriteLine(secondNumber);
Console.WriteLine(isNumeric02);

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30));
Console.WriteLine(thirdNumber);
Console.WriteLine(isNumeric03);

maxNumber = firstNumber;

if (secondNumber > maxNumber)
{
    Console.WriteLine("Второе число больше");
}
else if (thirdNumber > maxNumber)
{
    Console.WriteLine("Третье число больше");
}
else
{
    Console.WriteLine("Первое число больше");
}
