﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Ввндите число дня недели: ");
int num = int.Parse(Console.ReadLine());

    if ((num >= 1) && (num <= 5))
    Console.WriteLine("Этот день не выходной");
else{        
     if ((num == 6) | (num == 7))
        Console.WriteLine("Выходной");
    else 
        Console.WriteLine("Не существует такого дня недели"); 
     
}