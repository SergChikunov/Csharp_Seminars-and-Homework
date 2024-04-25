/* Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд 
числа должен располагаться на 0- м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7] */

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[3];
int count = 2;
while (num != 0)
{
    arr[count] = num % 10;
    num /= 10;
    count--;
}
for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
