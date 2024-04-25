/* Задайте массив.Напишите программу,которая определяет,присутствует ли заданноечисловмассиве. Программа должнавыдать ответ:Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да */

int[] array01 = { 1, 3, 4, 19, 3 };
// int[] array02 = {-4,3,4,1};

Console.WriteLine("Введите искомое число в массиве: ");
int searchVar = Convert.ToInt32(Console.ReadLine());
// int searchVar = 8;
// string equalStr = "Да";
bool isExist = false;

/* foreach (int e in array01)
{
    if(e != searchVar)
    {
        equalStr = "Нет";
    }
} */

for(int i = 0; i < array01.Length; i++)
{
    if(array01[i] == searchVar)
    {
        isExist = true;
        break;
    }
}
string result = isExist ? "Да" : "Нет";
Console.WriteLine(result);