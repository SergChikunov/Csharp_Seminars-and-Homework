/* string s = "0";

int n;
bool isNumeric = int.TryParse(s, out n);

Console.WriteLine(n);                // 123
Console.WriteLine(isNumeric);        // True

Этот код я запускал для проверки того, что я правильно выбрал операторы для определения того, что было введено число с консоли
*/

int firstNumber;
int secondNumber;
int maxNumber;

Console.WriteLine("Введите первое число, нужно ввести именно число (!!!): ");
string readNumOne = Console.ReadLine();

bool isNumeric01 = int.TryParse(readNumOne, out firstNumber); //проверка является ли ввод целым числом для первого числа, т.е. нам требуется значение True

Console.WriteLine("\nВведите первое число, нужно ввести именно число (!!!): ");
string readNumTwo = Console.ReadLine();

bool isNumeric02 = int.TryParse(readNumTwo, out secondNumber); //проверка является ли ввод целым числом для второго числа, т.е. нам требуется значение True

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30)); //Console.WriteLine(new string('.', 10));
Console.WriteLine(firstNumber);
Console.WriteLine(isNumeric01);

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30));
Console.WriteLine(secondNumber);
Console.WriteLine(isNumeric02);

if (firstNumber > secondNumber)
{
    maxNumber = firstNumber;
}
else
{
    maxNumber = secondNumber;
}

Console.WriteLine($"Максимальное из двух введенных это {maxNumber}.");
