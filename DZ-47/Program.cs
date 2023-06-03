// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите колличество строк: ");
int  m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int  n = Convert.ToInt32(Console.ReadLine());

double[,] masive = new double[m,n];

void PrintArray(double[,] array) 
{ 
    for (int i=0; i<array.GetLength(0);i++) 
        { 
        for (int j=0; j<array.GetLength(1);j++) 
            System. Console.Write($"{array[i,j]} ");
        } 
} 

void Randome(double[,] array) 
{ 
     Random rand = new Random(); 
    for (int i=0; i<array.GetLength(0);i++) 
        for (int j=0; j<array.GetLength(1);j++) 
            array[i,j] = (double)rand.NextDouble();
} 


Randome(masive);
PrintArray(masive);