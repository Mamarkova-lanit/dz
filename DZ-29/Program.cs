
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] masiv = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите число {i}");
    masiv[i] = Convert.ToInt32(Console.ReadLine());
}

string s = String.Join(", ", masiv);
 
        Console.WriteLine(s);       
