/* Задание: 
Создайте метод Distance который вычисляет расстояние между двумя точками на плоскости. 
Координаты точек вводятся (переменные x1,y1 — для первой точки, и x2,y2 — для второй).
  
Указание 1: Метод Distance() принимает 4 аргумента (координаты точек).
Указание 2: Метод не должен возвращать значение, поэтому следует использовать ключевое
слово void в объявлении метода
*/

void CountDistanse(double coordX1, double coordY1, double coordX2, double coordY2)
{
    double tempVal_1 = coordX2 - coordX1;
    double resultX = Math.Pow(tempVal_1, 2);

    double tempVal_2 = coordY2 - coordY1;
    double resultY = Math.Pow(tempVal_2, 2);

    double distanceVal = Math.Sqrt(resultX + resultY);

    Console.WriteLine("Расстояние между двумя указанными точками на полоскости равно: " + distanceVal);
}

Console.WriteLine("Введите координату Х, первой точки: ");
double x1Coord = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y, первой точки: ");
double y1Coord = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х, второй точки: ");
double x2Coord = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y, второй точки: ");
double y2Coord = Convert.ToDouble(Console.ReadLine());

CountDistanse(x1Coord, y1Coord, x2Coord, y2Coord);
