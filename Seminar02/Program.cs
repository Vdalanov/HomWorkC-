// //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (double x, double y)
// {
//     if(x>0 && y>0) return 1;
//     if(x<0 && y>0) return 2;
//     if(x<0 && y<0) return 3;
//     if(x>0 && y<0) return 4;
//     return 0;
// }
// Console.Write("Input x-coordinate: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input y-coordinate: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"The poin A({x},{y}) is on the {FindQuart(x,y)} quart");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
// void FindQuart (int a)
// {
//     if(a==1)  Console.Write("У вас должен быть пложительный X и Y");
//     else if(a==2)  Console.Write("У вас должен быть отрицательный X и пложительный Y");
//     else if(a==3)  Console.Write("У вас должен быть отрицательный X и отрицательный Y");
//     else if(a==4)  Console.Write("У вас должен быть пложительный X и отрицательный Y" );
//  else
//  {
//     Console.WriteLine("Ваше чилсо не соотвествует номеру четверти");
//  }
// }
// Console.WriteLine("Введите номер четверти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// FindQuart(n);



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double coordinate (double xa, double ya ,double xb, double yb)
// {
//     return(Math.Sqrt(Math.Pow((xa-xb),2)+ Math.Pow((ya-yb),2)));
// }
// Console.WriteLine("Введите координаты: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// double ya = Convert.ToDouble(Console.ReadLine());
// double xb = Convert.ToDouble(Console.ReadLine());
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ($"Растоняние между точками ровно {coordinate(xa,ya,xb,yb)}");




// // Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
// void writeq(int n)
// {
//     int current=1;
//     int sum= 0;
//     while(n>=current)
//     {
//         sum=current*current;
//         Console.Write($"{sum} " );
//         current++;
//     }
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// writeq(n);

// Задача 19. Напишите программу, которая принимает на вход  число и проверяет, является ли оно палиндромом.
bool Palindrome(int num)
{
    bool res = true;
    while (num > 9)
    {
        int lastDigit = num % 10;
        int firstDigit = num;
        int countOfDigits = 0;
        while (firstDigit >= 10)
        {
            countOfDigits++;
            firstDigit /= 10;
        }
        if (lastDigit != firstDigit)
        {
            res = false;
            break;
        }
        num = num / 10 % (Convert.ToInt32(Math.Pow(10, countOfDigits - 1)));
    }
    return res;
}
Console.Write("Введите число, которое будем проверять на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(Palindrome(number));