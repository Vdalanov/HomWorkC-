/*
int Max (int arg1,int arg2,int arg3)
{
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}





int [] array ={1,3,5,65,567,76,86,45,45};

int max= Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(max);

*/
//Имеятся масив необходимо найти число 4 которое задает пользователь
/*
int [] array ={1,3,4,5,6,7,8};
int n = array.Length;
int find =Convert.ToInt32(Console.ReadLine());

int index = 0;
while (index<n)
{
    if(array[index]== find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/
// Найти любое чило из рандомного массива с помощью методов (функций)

//  void FillArray(int[] collection)
// {

// int length = collection.Length;
// int index = 0;
// while (index<length)
// {
//     collection[index]=new Random().Next(1,10);
//     index++;
// }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position<count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int Indexof(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = 0;
//     while(index<count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//         }
//         index++;
//     }
//     return position;
// }


// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = Indexof(array,4);
// Console.WriteLine(pos);