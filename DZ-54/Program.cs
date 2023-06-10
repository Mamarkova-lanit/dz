// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] masive = new int[m, n];

void Rung(int[,] array)
{
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                num = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = num;
                Rung(array);
            }
        }
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
    for (int i = 0; i < masive.GetLength(0); i++)
    {
        {
            for (int j = 0; j < masive.GetLength(1); j++)
                Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Randome(masive);
PrintArray(masive);
Rung(masive);
Console.WriteLine("сортированный массив");
PrintArray(masive);

