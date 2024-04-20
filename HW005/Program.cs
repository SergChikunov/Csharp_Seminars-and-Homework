int firstNumber;
string? readNumOne = " ";
bool isNumeric01 = false;
int i = 2;

do
{
    Console.WriteLine("Введите, нужно ввести именно число (!!!): ");
    readNumOne = Console.ReadLine();

    isNumeric01 = int.TryParse(readNumOne, out firstNumber); //проверка является ли ввод целым числом для первого числа, т.е. нам требуется значение True

} while (isNumeric01 != true);


firstNumber = Convert.ToInt32(readNumOne);

Console.WriteLine("\n");
Console.WriteLine(new string('=', 30)); //Console.WriteLine(new string('.', 10));
Console.WriteLine(firstNumber); // Для отладки и наглядности
Console.WriteLine(isNumeric01); // Для отладки и наглядности
Console.WriteLine("\n");

while (i <= firstNumber)
{
    Console.Write(i + " ");
    i += 2;
}
