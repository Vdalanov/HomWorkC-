 //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int []array(int size)
// {
//     int  maxnumber= 1000;
//     int minnumber=100;


//     int [] newarray = new int [size];
//     for (int i = 0; i <newarray.Length; i++)
//     {
//         newarray[i]=new Random().Next (minnumber,maxnumber);
//     }
//     return newarray;
// }
// void Print(int [] array)
// {

//     for (int i = 0; i <array.Length; i++)
//     {
//         Console.Write ($"{array[i]} ");
//     }

// }
// int evennumbers(int [] array)
// {
//     int sum=0;
//     for (int i = 0; i <array.Length; i++)
//     {
//         if(array[i]%2==0)
//         sum++;
//     }
//     return sum;
// }

// Console.Write("Введити колиство генерируемых цифр ");
// int a=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array(a);
// Print(newarray);
// int sum = evennumbers(newarray);
// Console .ForegroundColor = ConsoleColor.Blue;
// Console.Write($"Количество четных элеметов в массиве равно {sum} ");




//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] array (int size)
// {
//     int[] newarray =new int [size]; 
//     for (int i = 0; i < newarray.Length; i++)
//     {
//         newarray[i]=new Random().Next (-100,1000);    
//     }
//     return newarray;
// }
// void Print(int [] array)
// {
//      for (int i = 0; i <array.Length; i++)
//      {
//          Console.Write ($"{array[i]} ");
//     }

//  }
// int SumOfOddElements(int [] array)
// {
//     int sum = 0;
//     for (int i = 0; i <array.Length; i++)
//     {
//         if (array[i]%2>0) sum+=array[i]; 
//     }
//     return sum;
// }


// Console.Write("Введити колиство генерируемых цифр ");
// int a=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array(a);
// Print(newarray);
// int sum = SumOfOddElements(newarray);
// Console .ForegroundColor = ConsoleColor.Blue;
// Console.Write($"Сумма не четных элеметов в массиве равно {sum} ");


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// int[] array(int size)
// {
//     int [] arr  = new int [size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]= new Random().Next(1,1000);
//     } 
//     return arr;
// } 
//  void Print(int [] array)
// {
//       for (int i = 0; i <array.Length; i++)
//      {
//            Console.Write ($"{array[i]} ");
//     }
//  }
//  int DifferenceBetweenMaxAndMin(int []array)
//  {
//     int min = array[0];
//     int max = array[0];
//     int diference = 0;
//     for (int i = 0; i <array.Length; i++)
//     {
//         if(array[i]>max) max=array[i];
//         if(array[i]<min) min=array[i];
//     }
//     diference=max-min;
//     return diference;
//  }
//  Console.Write("Введити колиство генерируемых цифр ");
// int a=Convert.ToInt32(Console.ReadLine());
// int [] newarray = array(a);
// Print(newarray);
// int sum = DifferenceBetweenMaxAndMin(newarray);
// Console .ForegroundColor = ConsoleColor.Blue;
// Console.Write($"Разница между максимальным и минимальным элементам массива {sum} ");





//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array(int size)
{
    int [] arr  = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(1,10);
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
 int[] ProductofPairs(int [] array)
 {
  
    int size = array.Length;
    int size2=array.Length;
    int[]arr=new int []{};
    for (int i = 0; i <size2/2; i++)
    {
     
        arr[i]=array[i]*array[size-1];
        size--;
        
    }
    return arr;
 }
Console.Write("Введити колиство генерируемых цифр ");
int a=Convert.ToInt32(Console.ReadLine());
int [] newarray = array(a);
Print(newarray);
int[] sum = ProductofPairs(newarray);
Console .ForegroundColor = ConsoleColor.Blue;
Print(sum);