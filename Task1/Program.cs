//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 9999 && number < 100000)
    {
        string str = number.ToString();
        if(str[0] == str[4] && str[1] == str[3])
        Console.WriteLine("Является");
    
        else
        Console.WriteLine("Не является");
        
    }
    else        
    Console.WriteLine("Это не пятизначное число");
