//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// double exponentiation(double a,int b)
// {
//     double count = 1;
//  for (int i = 0; i < b; i++)
//  {
//     count*=a;
//  }
// return count;

// }
// Console.Write("Введите число A которое надо возвести в степень B A = ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите степень B B = ");
// int b = Convert.ToInt32(Console.ReadLine());
// double sum = exponentiation (a,b); 

// Console.Write($"{a} в степени {b} равно {sum}");

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int sumdigit(int a)

// {
//     int count = 0;
//     for (int i = 0; a > 0; i++)
//         {
//         count=count+a%10;
//         a=a/10;
//         }
//  return count;
// }
// Console.Write("Введите число A которое надо возвести в степень B A = ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = sumdigit (a); 
// Console.Write($" Сумма чисел в {a}  равна {sum}");

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.



//  int[] CreateArray (int size)
//     {   
//      int[]newArray = new int[size];
//      for (int i = 0; i < size; i++)
//      {  
//         Console.Write($"Введите значения масива ");
//          newArray[i] = Convert.ToInt32(Console.ReadLine());

//      }
//      return newArray;
//     }
    


// void Print(int[]array)
// {
//     for(int i=0;i<array.Length;i++)
//     {
//         Console.Write(array[i]+" ");
        
//     }
// Console.WriteLine();
// }
   
// Console.WriteLine("Введитите длину масива ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(a);
// Print(myArray);