//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = 3;
int n = 4;
//int [,] arr = getArray(m,n,0,10);

double [,] getArray(int mLocal, int nLocal, int min, int max) 
{
    double [,] result = new double [mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(min,max),1, MidpointRounding.AwayFromZero);
        }
    }
    return result;
}

void printArray(double [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++) //0 - строка
    {
        for (int j = 0; j < a.GetLength(1); j++) //1 - столбец
        {
            Console.Write($"{a[i,j]} ");
        }      
        Console.WriteLine();
    }
}

double [,] array = getArray(m,n,0,10);
printArray(array);