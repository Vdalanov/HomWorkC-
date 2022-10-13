// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void palindrom (int n)
// {                      
//         if (n < 10000 ^ n > 99999)
//     {
//         Console.WriteLine($" введено не пятизначное число.");
//     }
//     else
//     {            
//     int a = n;                   
//         if (a/10000 == a%10) a = a/10%1000;
//         if (a/100 == a%10)Console.WriteLine($"Your number {n} it is a palindrome");
//         else 
//         Console.WriteLine ($"Your number {n}  is not a palindrom" ); 
//     }
// }

// Console.WriteLine("Input a number: ");
// int n=Convert.ToInt32(Console.ReadLine());
// palindrom(n);
  
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double ax, double ay, double az, double bx, double by, double bz)


// {
//     return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
// }

// Console.WriteLine("Введите координаты точки A : ax,ay,az: ");
// double ax = Convert.ToDouble(Console.ReadLine());
// double ay = Convert.ToDouble(Console.ReadLine());
// double az = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты  точки B: bx,by,bz ");
// double bx = Convert.ToDouble(Console.ReadLine());
// double by = Convert.ToDouble(Console.ReadLine());
// double bz = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Расстояние между точкой A и b равно равно {Distance(ax, ay, az, bx, by, bz)}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kub(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.Write($"{Math.Pow(count, 3)}");
        if (count < n) Console.Write(", "); 
        count++;
    }
}
Console.WriteLine("Введите число  ");
int x = Convert.ToInt32(Console.ReadLine());
Kub(x);

