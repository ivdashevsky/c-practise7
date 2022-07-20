//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] getArray(int mLocal, int nLocal, int min, int max)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void printArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) //0 - строка
    {
        for (int j = 0; j < a.GetLength(1); j++) //1 - столбец
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
}

void findAvg(int [,] arr)
{   
    decimal sum = 0;
    decimal result;
    for (int j = 0; j < arr.GetLength(1); j++) //0 - строка
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i,j];
        }
        result = sum/arr.GetLength(0);
        Console.WriteLine(result);
        sum = 0;
    } 

}

int[,] array = getArray(4, 4, 0, 30);
printArray(array);
Console.WriteLine();
findAvg(array);