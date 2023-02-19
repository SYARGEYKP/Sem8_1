// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array) // печатаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int [,] Pusyr(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = array.GetLength(1) - 1; j > i; j--)
                if (array[rows, j] > array[rows, j - 1])
                {
                    int temp = array[rows, j];
                    array[rows, j] = array[rows, j - 1];
                    array[rows, j - 1] = temp;
                }
    return array;
}

int[,] matrix = GenerateArray(3, 3);
PrintArray(matrix);
System.Console.WriteLine();
Pusyr(matrix);
PrintArray(matrix);
