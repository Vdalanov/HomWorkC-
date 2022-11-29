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
// int[] array()
// {
//     int [] arr  = new int [12];
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
//  int QuantityInTheArea(int[]array,int n,int m)
// {
//     int count=0;
//  for (int i = 0; i <array.Length; i++)
//  {
//     if(array[i]>n&&array[i]<m) count++;
//     if(array[i]<n&&array[i]>m) count++;  
//  }
//  return count;
// }
//  Console.Write("Введити числа между которыми будем искать значения  ");
// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array();
// Print(newarray);
// int sum = QuantityInTheArea(newarray,a,b);
// Console .ForegroundColor = ConsoleColor.Blue;
// Console.Write($"Количество элементов между {a} и {b}  значениями {sum} ");


// Разворот массива
//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int [] CreateRandomArray()
// {
// Console.WriteLine("input a number of elements");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of max elements");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of min elements");
// int min = Convert.ToInt32(Console.ReadLine());
// int [] arr=new int [size];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i]=new Random().Next(min,max+1);
// }
// return arr;
// }
// void Print(int[]arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
//    Console.Write(arr[i]+" "); 
// }
// Console.WriteLine();
// }

// int[] ArrayReversal(int []arr)
// {

// for (int j = arr.Length-1, i = 0; i <= j; i++,j--)
// {
//     int temp = arr[i];
//     arr[i]=arr[j];
//     arr[j]=temp;
// }
// return arr;
// }
// int []arr = CreateRandomArray();
// Print(arr);
// ArrayReversal(arr);
// Print(arr);


// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// bool ExistanTriangli(double a,double b,double c)
// {
//     bool answer ;
//     if(a<b+c && b<c+a && c<b+a) answer= true; 
//     else answer = false;
//     return answer;
// }
// Console.WriteLine("input a number  a");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input a number b");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input a number c");
// double c = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Может существовать треугольник с даными сторонами {ExistanTriangli(a,b,c)} ");
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
// int [] arr (int size, int a ,int b )
// {
//     int [] arr = new int [size];
//     arr[0]= a;
//     arr[1]= b;
// for (int i = 2; i <arr.Length; i++)
// {
//     arr[i]= arr[i-2]+arr[i-1];
// }
// return arr;
// }
// void Print(int[]arr)
//  {
// for (int i = 0; i < arr.Length; i++)
// {
//    Console.Write(arr[i]+" "); 
// }
// Console.WriteLine();
// }

// Console.WriteLine("input a number of elements");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of  a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input a number of b");
// int b = Convert.ToInt32(Console.ReadLine());
// int [] newarr= arr(size,a,b);
// Print (newarr);

//Двумерные массивы 
// int [,] CreateRandom2Array()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int [,] array = new int [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return array;
// }

void Show2dArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write (array[i,j]+" "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// int [,] myArray = CreateRandom2Array();
// Show2dArray(myArray);

//Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// int [,] ArraySumIndex()
// {
//         Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int [rows,columns]; 
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= i+j;
//         }
   
//     }
//      return array;
// }
// int [,] myArray = ArraySumIndex();
// Show2dArray(myArray);


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int [,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array;
}

// void SquareOfEvenIndices(int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i+=2)
//     {
//     for (int j = 0; j < array.GetLength(1); j+=2)
//         {
//             array[i,j]*=array[i,j];
//         }
//     }
// }
// int [,] myArray = CreateRandom2Array();
// Show2dArray(myArray);
// SquareOfEvenIndices(myArray);
// Show2dArray(myArray);

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int SumMainDiagonal(int [,]array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i==j)
//             sum+= array[i,j];
//         }
      
//     }
//   return sum;
// }
// int [,] myArray = CreateRandom2Array();
// Show2dArray(myArray);
// Console.WriteLine($"Сумма элементов на главной диаганали >{SumMainDiagonal(myArray)}");

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.



// void ChangeArray(int[,] array)
// {
//     if (array.GetLength(0)== array.GetLength(1))
//     {
//         for (int i=0; i < array.GetLength(0)-1;i++)
//             for (int j = i+1;j< array.GetLength(1);j++)
//             {
//                 int temp= array[i,j];
//                 array[i,j]= array[j,i];
//                 array[j,i] = temp;
//             }
//     }       
//     else 
//         Console.WriteLine("It,s impossible");
    
// }
// int [,] myArray = CreateRandom2Array();Show2dArray(myArray);
// ChangeArray(myArray);
// Show2dArray(myArray);

//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int [,] StringReplacement(int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        if(i==array.GetLength(0)-1) 
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         int temp= array[i,j];
//         array[i,j]= array[0,j];
//         array[0,j] = temp;
//         }
//     }
//     return array;
// }
// int [,] myArray = CreateRandom2Array();Show2dArray(myArray);
// StringReplacement(myArray);
// Show2dArray(myArray);




//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int [,] DeletуRowsLine(int[,]array)
{
    int min = array[0,0] ;
    int min1=0;
    int min2=0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(array[i,j]<min) 
           {
            min = array[i,j];
            min1=i;
            min2=j;
           }
        }
    }
    int [,] myarray = new int [array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i=0,n=0; i < array.GetLength(0); i++,n++)
        {
            if(i==min1) 
            {
                n--;
                continue;
            }   
           
            for (int j = 0,m=0; j < array.GetLength(1); j++,m++)
            {
                if(j==min2)
                {
                    m--;
                    continue;
                }          
                myarray[n,m]=array[i,j];
            }
        
        }
        return myarray;
}

int [,] myArray = CreateRandom2Array();
Show2dArray(myArray);
int [,]array=DeletуRowsLine(myArray);
Show2dArray(array);
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int [,,] random3dArray ()
// {
// Console.Write("Input a number of строки: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of столбцы: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of высота: ");
//     int height = Convert.ToInt32(Console.ReadLine());
//     int [,,] array = new int [rows,columns,height];
//      int [,,] newarray = new int [rows,columns,height];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             for (int k = 0; k < array.GetLength(2); k++)
//             {         
//                     array[i,j,k]=new Random().Next(10,18);
                    
//             }
//         }
//     }
//     return array;
// }

// void Print3darray(int [,,] array)
// {

//   for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
//             }
//         }
//     }
//     Console.WriteLine();

// }

// int randomAll(int [,,]array)
// {
// int sum=0;
//       for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 1; k < array.GetLength(2); k++)
//             {
//                 sum = array[i,j,k];
//                for (int q = i; q < array.GetLength(0); q++)
//                {
                
//                for (int w = j; w < array.GetLength(1); w++)
//                {
//                     for (int e = k+1; e < array.GetLength(2); e++)
//                 {
//                      if (sum==array[q,w,e])
//                     {
//                         sum=array[q,w,e];
                        
                
//                     }
//                 }
//                }
//                }
//             }
//         }
//     }
//     return sum;
// }



// int[,,]array=random3dArray();
// Print3darray(array);
// Console.WriteLine(randomAll(array));