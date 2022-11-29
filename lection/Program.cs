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


//вид 1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//Вид 2

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;


//     }
    
// }
// Method2( msg:"Текс ", count:4 );
 


//Вид 3
//  int Method3()
//  {
//     return DateTime.Now.Year;

//  }

//  int year = Method3();
//  Console.WriteLine(year);

//Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // пустая строка 
//     while(i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10,"z");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
    
//     string result = String.Empty; // пустая строка 
//     for(int i = 0;i<count;i++)
//     {
//         result=result+text;
//     }
//     return result;
// }

// string res = Method4(10,"z");
// Console.WriteLine(res);


//  for(int i = 2;i<=10;i++)
//  {
//     for(int j = 2;j<=10;j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
//  }


//===---Работа с текстом
// дан текст .В тексте нужно все проблелы заменить черточками,
// маленькие буквы к заменить большими "К",
// а больште "С" заменить маленкими "с".

// string text = "-Я думаю, - сказад князь, улыбаясь,- что,"
//             +"ежеле бы вас послали вместо нашего милого Винуенгероде,"
//             +"вы бы взяли приступом согласия прусского короля."
//             +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]// r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result =String.Empty;
    
//     int length= text.Length;
    
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result=result + $"{newValue}";   
//         else result=result + $"{text[i]}";
//     }
//     return result; 
    
// }
// string newText = Replace(text,' ','|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'к','К');
// Console.WriteLine(newText);


// int[] arr = {1,4,2,3,6,7,2,4,6,9};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         int minPosition = i;

//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j]>array[minPosition]) minPosition=j;
//         }


//         int temporary = array[i];
//         array[i]=array[minPosition];
//         array[minPosition] = temporary;
//     }
// }


// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

string NumbersFor(int a, int b)
{
    string result=String.Empty;
    for (int i = a; i <=b; i++)
    {
        result+=$"{i} ";
    }
    return result;
}
string NumbersRec(int a,int b)
{
    if(a<b) return $" {a}" + NumbersRec (a+1 ,b );
    else return $" {b}";
}
Console.WriteLine(NumbersFor(2,11));
System.Console.WriteLine(NumbersRec(2,11));