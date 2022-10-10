//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine ("Input first a number:  ");
int n1=Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Input second a number:  ");
int n2=Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(n1>n2)   
{
     max=n1;
     min=n2;
} 
else
{
     max=n2;
     min=n1;
}

Console.WriteLine($"This number is bigger {max} This number is less than {min}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input three a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(max<b) max=b;
if(max<c) max=c;
Console.WriteLine("Your Max number:  "+ max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Your number: ");

int n = Convert.ToInt32(Console.ReadLine());
if (n%2<1)
{
     Console.WriteLine("Yes, your number is even ");
}
else
{
     Console.WriteLine("no, your number is not even ");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();
Console.WriteLine("Your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current=1;
Console.WriteLine("Your numbers complet: ");

while (n>current || current>n )
{
     if(n>0)
     {
          if (n%2<1)
          {
               Console.WriteLine(n);
          }
          n=n-1;
     }
     
     else 
     {
          if (n%-2==0)
          {
               
               Console.WriteLine(n);
          }
          n=n+1;
     }
     
}
*/





