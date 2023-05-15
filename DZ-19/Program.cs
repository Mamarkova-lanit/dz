
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num.ToString().Length;
int res =0;
int num2 = num;
if(num > 9999 && num < 100000){
    for(int i=0;i<count;i++){
        res = res*10 + num %10;
        num=num /10;
    }
    if(num2 == res)
        Console.WriteLine($"{num2} является палиндромом.");
    else
        Console.WriteLine($"{num2} не является палиндромом.");
}else 
     Console.WriteLine("Введите пятизначное число! ");
