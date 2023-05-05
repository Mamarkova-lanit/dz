// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123


// double number = ReadInt("Введите число: ");
Console.WriteLine("Введите число: ");
string? mystring =Console.ReadLine();
int i=1;
int count = mystring.ToString().Length;
double NumericValue;
if(double.TryParse(mystring, out NumericValue)){
    if(count>1){
        if(mystring[1]==',')
            i=2;
        string result = mystring.Remove(i,1);
        double num = Convert.ToDouble(result);
        Console.Write(num.ToString());
    }else
       Console.WriteLine("Второго числа нет");
}else 
 
Console.WriteLine("Это не число");
