// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

    String Numerics = "";

for(int i=1;i<=numN;i++){
    if (i%2==0)
{

 Numerics=Numerics + i.ToString();
 if(i<(numN-1))
    Numerics=Numerics + ", ";
    
}
}
    Console.WriteLine (Numerics);
