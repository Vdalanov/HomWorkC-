﻿// //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

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

// // Задача 19. Напишите программу, которая принимает на вход  число и проверяет, является ли оно палиндромом.
// bool Palindrome(int num)
// {
//     bool res = true;
//     while (num > 9)
//     {
//         int lastDigit = num % 10;
//         int firstDigit = num;
//         int countOfDigits = 0;
//         while (firstDigit >= 10)
//         {
//             countOfDigits++;
//             firstDigit /= 10;
//         }
//         if (lastDigit != firstDigit)
//         {
//             res = false;
//             break;
//         }
//         num = num / 10 % (Convert.ToInt32(Math.Pow(10, countOfDigits - 1)));
//     }
//     return res;
// }
// Console.Write("Введите число, которое будем проверять на палиндром: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write(Palindrome(number));



// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSum(int a)
// {
//     int sum=0;
    
//     for (int current = 1; current <= a ; current++)
//     {
//         sum+=current;
//     }
//     return sum;
// }
// Console.Write("Input positive integer number : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int s = GetSum(num);
// Console.Write($"Sum of numbers from 1 to {num} is {s}");

// напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int GetSum(int a)
// {
    
//     int current = 1;
//     for ( current = 1; 10 <= a ; current++)
//     {
//         a/=10;
//     }
//     return current;
// }
// Console.Write("Input positive integer number : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int s = GetSum(num);
// Console.Write($"Sum of numbers from 1 to {num} is {s}");





// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

// int GetSum(int a)
// {
//      int sum=1;
  
    
//     for (int current = 1; current <= a ; current++)
//     {
        
//         sum*=current;
//         Console.Write($"{sum} ");
        
//     }
//     return sum;
// }
// Console.Write("Input positive integer number : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int s = GetSum(num);
// Console.Write($"Sum  {s}");


//Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

// int[] CreateRandomArray ( int size,int minValue,int maxValue)
// {
//     int[] newArray= new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i]=new Random().Next(minValue,maxValue+1);
        
//     }
//     return newArray;
// }
// void ShowArray(int[] array)


// {
//     for(int i=0;i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
        
//     }
// Console.WriteLine();
// }
// Console.Write("Inputa a number of elements:  ");
// int size=Convert.ToInt32(Console.ReadLine());
// int min = 0;
//  int max= 1;
//  int[] myArray = CreateRandomArray(size,min,max);
//  ShowArray(myArray);

// программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// int[] array(int size)
// {
//     int [] arr  = new int [size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]= new Random().Next(-10,11);
//     } 
//     return arr;
// } 
//  void Print(int [] array)
// {
//       for (int i = 0; i <array.Length; i++)
//      {
//            Console.Write ($"{array[i]} ");
           
//     }
//     Console.WriteLine();
//  }
//  int[] SwapPositiveAndNegative (int[]array)
//  {
    
//      for (int i = 0; i <array.Length; i++)
  
//     {
//    array[i]=array[i]*-1;
//     }

//     return array;    
//  }

//  Console.Write("Введити колиство генерируемых цифр ");
// int a=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array(a);
// Print(newarray);
// int[] sum = SwapPositiveAndNegative(newarray);
// Console .ForegroundColor = ConsoleColor.Blue;
// Print(newarray);

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// int[] array(int size)
// {
//     int [] arr  = new int [size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]= new Random().Next(-10,11);
//     } 
//     return arr;
// } 
//  void Print(int [] array)
// {
//       for (int i = 0; i <array.Length; i++)
//      {
//            Console.Write ($"{array[i]} ");
           
//     }
//     Console.WriteLine();
//  }
//  bool FindingNumber(int []arr, int a)
//  {
//     bool finding=false;
//     int index=0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if(arr[i]==a)  
//        {
//         finding=true;
//         index=i;
//        }         
//     }
//    if(finding==true) Console.WriteLine($"Число {a} находиться в масиве под индексом {index} ");
//     else Console.WriteLine($"Числа {a} нет в масиве");
//     return finding;
//  }

//  Console.Write("Введити колиство генерируемых цифр ");
// int size=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введити число которое нужно найти ");
// int a=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array(size);
// Print(newarray);
// FindingNumber(newarray,a);

//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] array()
{
    int [] arr  = new int [12];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(-10,11);
    } 
    return arr;
} 
 void Print(int [] array)
{
      for (int i = 0; i <array.Length; i++)
     {
           Console.Write ($"{array[i]} ");
           
    }
    Console.WriteLine();
 }
 int QuantityInTheArea(int[]array,int n,int m)
{
    int count=0;
 for (int i = 0; i <array.Length; i++)
 {
    if(array[i]>n&&array[i]<m) count++;
    if(array[i]<n&&array[i]>m) count++;  
 }
 return count;
}
 Console.Write("Введити числа между которыми будем искать значения  ");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int [] newarray = array();
Print(newarray);
int sum = QuantityInTheArea(newarray,a,b);
Console .ForegroundColor = ConsoleColor.Blue;
Console.Write($"Количество элементов между {a} и {b}  значениями {sum} ");


//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
