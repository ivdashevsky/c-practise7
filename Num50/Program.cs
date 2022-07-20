//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void findPosition(int[,] a, int pos1, int pos2)
{
    if ((pos1 < a.GetLength(0) && pos1 >= 0) && (pos2 < a.GetLength(1) && pos2 >= 0))
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (i == pos1 && j == pos2)
                {
                    Console.WriteLine($"Значение элемента: {a[i, j]}");
                }
            }
        }
    }
    else Console.WriteLine($"Значений позиций не существует.\nНужно ввести числа от 0 до {a.GetLength(0)-1} для 1 позиции и от 0 до {a.GetLength(1)-1} для 2 позиции.");

}

int[,] array = getArray(5, 8, 0, 30);
printArray(array);
findPosition(array, 4, 7);