/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

const int itemCount = 8;
int[] array = new int[itemCount];
Random rnd = new Random();

InitArray();

PrintArray();


int GetRandomNumber()
{
    return rnd.Next(1, 1000);
}

void InitArray()
{
    for (int i = 0; i < itemCount; i++)
    {
        array[i] = GetRandomNumber();
    }
}

void PrintArray()
{
    foreach (int elem in array)
    {
        Console.Write($"{(elem == array.First() ? "[" + elem : (elem == array.Last() ? "," + elem + "]" : "," + elem))}");
    }
}