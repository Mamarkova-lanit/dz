// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] masive = new int[m, n];

void Rung(int[,] array)
{
    int minsum = 0;
    int cursum =0;
    int position  =0;
    for (int j = 0; j < (array.GetLength(1)); j++)
        {
            minsum  += array[0,j];
            
        }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        cursum =0;
        for (int j = 0; j < (array.GetLength(1)); j++)
        {
            cursum  += array[i,j];
        }
        if (cursum <minsum){
            minsum =cursum;
            position = i;
        }
    }
Console.WriteLine($" Строка с минимальной суммой: {position}");
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

