/*Задайте одномерный массив, заполненный случайными числами. 
Определите количество простых чисел в этом массиве.*/

/*void GetArray()
{
    Random rnd = new Random();
    upperSize = 25;
    int[] arr = new int[upperSize];
    for(int i = 0; i < upperSize; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
}

int CountSimpleNum(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        if(array[i] / array[i] == 0 && array[i])
    }
}*/


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); // здесь хранится ссылка на объект в памяти

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
        
    }
    //return array;
}


int CountSimpleNum(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(IsSimple(array[j]))
        {
            count++;
        }
    }
    return count;
}

bool IsSimple(int num)
{
    for(int i = 2; i <= Math.Sqrt(num); i++)
    {
        if(num % i == 0) return false;
        
    }

    return true; // если условие не выполнилось, то возввращаем true
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
int count = CountSimpleNum(arr);
Console.WriteLine("\n");
Console.WriteLine("Количество простых чисел в массиве: " + count);
