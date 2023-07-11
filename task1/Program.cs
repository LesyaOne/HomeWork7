/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double [,] FillArray ()
{
    Console.Write ("Enter count of rows: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Enter count of columns: ");
    int n = Convert.ToInt32 (Console.ReadLine ());
    double [,] array = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array [i,j] = Math.Round((new Random().Next(0, 10) + new Random().NextDouble()), 2);
    }
    return array;
}
void PrintArray (double [,] arrayToPrint)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i<arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j<arrayToPrint.GetLength(1); j++)
            Console.Write(arrayToPrint[i,j] + "  ");
        Console.WriteLine();
    }
}
double [,] newArray = FillArray();
PrintArray(newArray);