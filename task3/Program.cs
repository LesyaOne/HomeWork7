/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int [,] FillArray ()
{
    Console.Write ("Enter count of rows: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Enter count of columns: ");
    int n = Convert.ToInt32 (Console.ReadLine ());
    int [,] array = new int [m, n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
            array [i, j] = new Random().Next(0, 10);
    }
    return array;
}
void PrintArray(int [,] arrayToPrint)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i<arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0;  j<arrayToPrint.GetLength(1); j++)
            Console.Write(arrayToPrint [i, j] + " ");
        Console.WriteLine();
    }
}
void Avg (int [,] array)
{
    Console.WriteLine("Averages of columns are: ");
    double avg = 0;
    for (int j=0; j<array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i<array.GetLength(0); i++)
        {
            sum = sum + array [i, j];
        }
        avg = (double)sum / array.GetLength(0);
        avg = Math.Round(avg, 2);
        Console.Write(avg + "  ");
    }
}
int [,] newArray = FillArray();
PrintArray(newArray);
Avg(newArray);