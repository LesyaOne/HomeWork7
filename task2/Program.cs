/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
void FindIndex (int [,] array)
{
    Console.Write ("Enter the row of element: ");
    int i = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Enter the column of element: ");
    int j = Convert.ToInt32 (Console.ReadLine ());
    if (i<array.GetLength(0) && j<array.GetLength(1))
        Console.WriteLine($"Your element is {array[i,j]}");
    else Console.WriteLine("There is no such element, try again");
}
int [,] newArray = FillArray();
PrintArray(newArray);
FindIndex(newArray);