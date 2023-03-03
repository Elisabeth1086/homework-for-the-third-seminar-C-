// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D простанстве
// А(3,6,8); B(2,1,-7) - 15.84
// А(7,-5,0); B(1,-1,9) - 11.53

System.Console.WriteLine("Введите координаты х точки А: ");
int[] coordsA=new int[3];
coordsA[0]=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y точки А: ");
coordsA[1]=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z точки А: ");
coordsA[2]=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты х точки B: ");
int[] coordsB=new int[3];
coordsB[0]=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y точки B: ");
coordsB[1]=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z точки B: ");
coordsB[2]=Convert.ToInt32(Console.ReadLine());

int distanceX=(int)Math.Pow(coordsB[0]-coordsA[0], 2);
int distanceY=(int)Math.Pow(coordsB[1]-coordsA[1], 2);
int distanceZ=(int)Math.Pow(coordsB[2]-coordsA[2], 2);

double result=Math.Sqrt(distanceX+distanceY+distanceZ);

System.Console.WriteLine(Math.Round(result, 2));
