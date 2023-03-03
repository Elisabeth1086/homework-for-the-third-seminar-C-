// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубовчисел от 1 до N
// 3-1,8,27
// 5-1,8,27,64,125

System.Console.WriteLine("Введите число: ");
int number=Math.Abs(Convert.ToInt32(Console.ReadLine()));

for(int i=1; i<=number; i++)
{
    System.Console.WriteLine(Math.Pow(i,3) + " ");
}