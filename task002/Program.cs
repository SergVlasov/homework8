// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int n, int m)
{
    int[,] massiv = new int[m, n];
    return massiv;
}

void FillMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumStrings(int[,] massiv, int i)
{
    int sumRow = 0;
    int NumberRow = i + 1;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        sumRow = sumRow + massiv[i, j];
    }
    Console.WriteLine($"Line amount № {NumberRow} = {sumRow}");

    return sumRow;
}

void MinSumRow(int[,] massiv)
{
    int NumberRow = 1;
    int sumRow = SumStrings(massiv, 0);
    for (int i = 1; i < massiv.GetLength(0); i++)
    {
        int nextSumRow = SumStrings(massiv, i);
        if (sumRow > nextSumRow)
        {
            sumRow = nextSumRow;
            NumberRow = i + 1;
        }

    }
    Console.WriteLine($"The smallest amount ({sumRow}) Strings № {NumberRow}");
}

Console.Clear();
Console.Write("Enter the dimensions of the two-dimensional array n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] massiv = CreateArray(n, n);
FillMassiv(massiv);
Console.WriteLine($"An array is created with the size {n}*{n}", "\n");
Console.WriteLine();
PrintMassiv(massiv);
MinSumRow(massiv);