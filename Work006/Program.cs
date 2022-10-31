// //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// void PositivNumber(int count)
// {
   
//     Console.Write("Введите число ");
//     double a = Convert.ToDouble(Console.ReadLine()); 
    
//         while (a>0)
//             {
//                 count++;
//                 Console.WriteLine($"Количество положительных:> {count},закончить подсчет нажнимете >0<");
//                 Console.Write("Введите число ");
//                 a = Convert.ToDouble(Console.ReadLine());
//             }
//         if(a<0) 
//             {
//                 Console.WriteLine(value: $"Ваше число отрицательное ! Введите  другое число ");
//                 PositivNumber(count); 
//             } 
//         else
//             {    
//                 Console.WriteLine("Количество положительных:>"+ count);
//             }

// }   
// int count = 0;
// PositivNumber(count);






//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// double [] LineIntersection (double k1, double k2, double b1, double b2)
// {
//   double [] arr = new double [2];   
//    double x = b2 - b1/k1 - k2;
//    double y = k1*x+b1;
//     arr[0]= x;
//     arr[1] = y;
//     return arr;
// } 
// void Print(double[]arr)
// {
// Console.WriteLine("Tочкa пересечения двух прямых");

//    Console.Write("x=" +arr[0]);
//    Console.Write(", y=" +arr[1]);

// Console.WriteLine();
// }
// Console.WriteLine("input a number of k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input a number of  k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input a number of b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input a number of b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// if(k1 == k2) Console.WriteLine("Прямые параллельны, точки пересечения нет.");
// else
// {
//    Print(LineIntersection(k1,k2,b1,b2));
// }

