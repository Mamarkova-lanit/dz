// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void sumn(int n, int m, int sum)
{
    if (n >m)
    {

        Console.Write(sum );
        return;
    }
    else
    {
        sum+=n;
        sumn( n+1,m,sum);
    }

}
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
sumn(n,m,0);