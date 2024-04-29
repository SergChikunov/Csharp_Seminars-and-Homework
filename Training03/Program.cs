/* Выполнить: Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), 
которая вычисляет периметр треугольника по длинам трех его сторон.
  
Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
Указание 2: Метод не должен возвращать никакого значения, поэтому вы должны использовать 
ключевое слово void в сигнатуре */

void Perimeter(int sideA, int sideB, int sideC)
{
    int result = sideA + sideB + sideC;
    Console.WriteLine("Периметр треугольника равен: " + result);
}

bool IfTriangExist(int sideA, int sideB, int sideC) // проверяем существование треугольника с указанными сторонами
{
    bool isExist = false; // определим максимальное значение из введенных и сравним его с суммой двух других, сумма должна быть больше
    int max = sideA;
    int tempVal = 0;
    if(sideB > max)
    {
        max = sideB;
        tempVal = sideA + sideC;
        isExist = sideB < tempVal ? true : false; //сравниваем значение стороны В с суммой двух других
    }
    if(sideC > max)
    {
        max = sideC;
        tempVal = sideA + sideB;
        isExist = sideC < tempVal ? true : false;
    }
    else
    {
        tempVal = sideB + sideC;
        isExist = sideA < tempVal ? true : false;
    }
    return isExist;
}

Console.WriteLine("Введите первую сторону треугольника: "); //ввод значений сторон треугольника тоже можно было организовать в виде метода
int aSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите вторую сторону треугольника: ");
int bSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите третью сторону треугольника: ");
int cSide = Convert.ToInt32(Console.ReadLine());

bool TriangleIsToBe = IfTriangExist(aSide, bSide, cSide);

if(TriangleIsToBe != false)
{
    Perimeter(aSide, bSide, cSide);
}
else
{
    Console.WriteLine("Треугольника с такими значениями длин сторон не может существовать!");
}
