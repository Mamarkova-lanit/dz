// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите колличество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] masive = new int[n, m];

void Randome(int[,] array) 
{ 
     Random rand = new Random(); 
    for (int i=0; i<array.GetLength(0);i++) 
        for (int j=0; j<array.GetLength(1);j++) 
            array[i,j] = (int)rand.NextInt64(0,11);
} 

void PrintArray(int[,] array, int n, int m)
{
    for (int i = 0; i < n; i++){
    {
        for (int j = 0; j < m; j++)
            Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
}

Randome(masive);
PrintArray(masive,n,m );


void Duck(int[,] array, int n, int m)
{
    int[] mas = new int[m];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            mas[i] += array[j, i];
    }

    for (int r = 0; r < m; r++)
    {
            mas[r] = mas[r] / n;
            Console.WriteLine($"Cреднее арифмитическое столбца {r}: {mas[r]}");

    }
}

Duck(masive, n, m);



// #double [] masive2 = new double[masive.GetLength(0)];
// #masive2 = Duck()//
