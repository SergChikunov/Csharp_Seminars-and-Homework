/* Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка. */

Console.Write("Введите числовую координату на оси X: ");
int Xcoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите числовую координату на оси Y: ");
int Ycoordinate = Convert.ToInt32(Console.ReadLine());


if (Xcoordinate > 0 && Ycoordinate > 0)
{
    Console.WriteLine("Точка с такими координатами расположена в первой четверти окружности.");
}
else if (Xcoordinate < 0 && Ycoordinate > 0)
{
    Console.WriteLine("Точка с такими координатами расположена во второй четверти окружности.");
}
else if (Xcoordinate < 0 && Ycoordinate < 0)
{
    Console.WriteLine("Точка с такими координатами расположена в третьей четверти окружности.");
}
else if (Xcoordinate > 0 && Ycoordinate < 0)
{
    Console.WriteLine("Точка с такими координатами расположена в четвертой четверти окружности.");
}
else
{
    Console.WriteLine("Указаны некорректные координаты точки!");
}
