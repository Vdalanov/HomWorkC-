// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int [,] CreateRandom2Array()
{
    Console.Write("Input a number of строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of столбцы: ");
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

// int[,] Stremline(int[,]array)
// {


//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int n = j + 1; n < array.GetLength(1); n++)
//             {
//                 if (array[i, n] > array[i, j])
//                 {
//                     int temp = array[i, n];
//                     array[i, n] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
    
//     return array;
// }
// int [,] myArray = CreateRandom2Array();
// Show2dArray(myArray);
// Stremline(myArray);
// Show2dArray(myArray);
 // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// int[] SumElementsRows(int[,] array)
// {
//     int[] sumArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//             sumArray[i] = sum;
//         }
//     }
//     return sumArray;
// }
// void PrintSumArray(int[] array)
// {
//     Console.Write("Сумма элементов в строке: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//     }
//     Console.WriteLine();
// }
// int IndexMinElements(int[] array)
// {
//     int iMin = 0;
//     int min = array[iMin];
//     for (int i = 1; i < array.Length - 1; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             iMin = i;
//         }
//     }
//     return iMin;
// }
// int[,] newArray = CreateRandom2Array();
// Show2dArray(newArray);
// Console.WriteLine();
// int[] sumArray = SumElementsRows(newArray);
// PrintSumArray(sumArray);
// int numberRow = (IndexMinElements(sumArray) + 1);
// Console.WriteLine($"Номер строки с наименьшей суммой элементов {numberRow}.");

//
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int [,]MatrixMultiplication(int [,]array,int [,]myarray)
// {
//     if (array.GetLength(1)!= myarray.GetLength(0))
//     {
//         Console.WriteLine("Нужно чтобы количество столбцов первого масива  соотвествовало количеству строк второго");
//         return null;
//     }
//     else    
//         {
//             int [,] newarray = new int [myarray.GetLength(1),array.GetLength(0)]; 
//             for (int q = 0; q < myarray.GetLength(1); q++)
//             {
//                 for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     for (int j = 0; j< myarray.GetLength(0); j++)
//                     {
//                          newarray[i,q]+=array[i,j]*myarray[j,q];
                
//                     }
//                 }
        
//             }
//                 return newarray;
//         }
// }


// int [,] myArray = CreateRandom2Array();
// int [,] newArray = CreateRandom2Array();
// Show2dArray(myArray);
// Show2dArray(newArray);
// int [,]array =MatrixMultiplication(myArray,newArray);
// Show2dArray(array);




//Напишите программу, которая заполнит спирально массив 4 на 4.

// int [,] MArray(int line,int columns)
// {  
//     int i = 0;
//     int j = 0;
//     int iremains=i;
//     int jremains=j;

//     int sum=1;
//     int count =1;
//     int temp =0;
//     int [,] array = new int [line,columns];
//     while(array[i,j]==0)
//     {
//             for ( jremains=j; j < array.GetLength(1)-count && array[i,j]==0 ; j++)
//                 {
//                 array[i,j]=sum;
//                 sum+=1;
//                 }     
//             for ( iremains=i ; i < array.GetLength(0)-count && array[i,j]==0 ; i++)
//                 {
//                     array[i,j]=sum;
//                     sum+=1;
//                 }
                
//             for (jremains = j; j !=temp && array[i,j]==0   ; j--)
//                 {
//                     array[i,j]=sum;
//                     sum+=1;
                   
//                 }
//             for ( iremains=i ;i !=0 && array[i,j]==0 ; i--)
//                 {
//                     array[i,j]=sum;
//                     sum+=1;
                      
//                 }          
//                      j++;
//                      i++;
//                      temp++;
//                      count++;
                      
//     }                      
//      return array;       
// }


// Console.Write("Input a number of строки: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of столбцы: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Show2dArray(MArray(rows,columns));