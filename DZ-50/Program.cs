// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и
// возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] masive = new int[m, n];

void FaindNum(int[,] array, int k)
{
    int test = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == k)
            {
                Console.WriteLine($"Строка: {i} ");
                Console.WriteLine($"Столбец: {j} ");
                test = 1;
            }
        }
    }
      if ( test == 0)
            Console.WriteLine($"Такой позиции нет ");
                

}



void Randome(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = (int)rand.NextInt64(0,5);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]} ");
    }
}

Randome(masive);
PrintArray(masive);
Console.WriteLine("Введите число для поиска: ");
int num = Convert.ToInt32(Console.ReadLine());
FaindNum(masive, num);
