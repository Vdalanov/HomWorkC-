
// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double [,] array ( )
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
   
//     double [,] array = new double [columns,rows];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(1,100); 
//             array[i,j]= Math.Round(array[i,j]+= new Random().NextDouble(),1);
            
//         }
//         }
//         return array;
// }

// void Show2dArray(double[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write ($"({array[i,j]}) "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double [,] newarray = array(); 
// Show2dArray(newarray);

// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// void FindingOfElementsArray(double [,]array )
// {
//     Console.Write("Введите номер строки элемента : ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца : ");
//     int columns = Convert.ToInt32(Console.ReadLine());


//     double elements = -1;
//      if(rows>array.GetLength(0)||columns>array.GetLength(1))
//             {
//              Console.WriteLine($"На заданой позиции {rows},{columns} элемента нет ");
//             }
//     else      
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if(array[i,j]==array[rows-1,columns-1])
//                 elements = array[rows-1,columns-1];  // -1 что бы визуально соотвестовало  сторочки и столбцу
           
//             }   
//             }
//             Console.WriteLine($"Ваш элемент {elements}");
//     }
     
// } 
// FindingOfElementsArray(newarray);




//Задача 52.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//  int [,] CreateRandom2Array()
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

// void ShowArray(double[]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//            Console.Write (array[i]+" "); 
//     }
//     Console.WriteLine();
// }
// void Show2dArray(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write ($"({array[i,j]}) "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

//  double [] ArithmeticMeanOfElementsColumns(int[,]array)
// {
//     double sum = 0;
//     double[] newarr =  new double [array.GetLength(1)]; 
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
        
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum+= array[i,j];
            
//         }
//     newarr[j]=sum/ array.GetLength(0);
//     sum=0;
//     }
//     return newarr;
// } 


//  int[,] newarr = CreateRandom2Array();
//  Show2dArray(newarr);
//  double [] newarr2= ArithmeticMeanOfElementsColumns(newarr);
//  ShowArray(newarr2);
