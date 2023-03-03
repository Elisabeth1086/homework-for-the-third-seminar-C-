// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 - нет
// 23432 - да
// 12821 - да

System.Console.Write("Введите число: ");
string? number=Console.ReadLine();

int len=number!.Length;

if(len==5)
{
    if(number[0]==number[4] && number[1]==number[3])
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
    else
    {
        System.Console.WriteLine("Не пятизначное число");
    }

