// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите колличество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Console.WriteLine("Введите колличество строк второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов второй матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[k, z];



void Multiplication(int[,] matrix, int[,] matrix2)
{
    if (matrix.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] r = new int[matrix.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    r[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("Произведение матриц: ");
        PrintArray(r);
    }
    else
    {
        Console.WriteLine("матрицы нельзя перемножить");
    }

}

void Randome(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = (int)rand.NextInt64(0, 5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Randome(matrix);
Randome(matrix2);
Console.WriteLine("Первая матрица");
PrintArray(matrix);
Console.WriteLine("Вторая матрица");
PrintArray(matrix2);
Multiplication(matrix, matrix2);



