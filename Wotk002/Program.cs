//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondNumber(int num)
{
  int n=num/10;
    n=n%10;
    return n;
}


Console.WriteLine("Enter a three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>99 && a<1000)
{
    int secondnumber=ShowSecondNumber(a);
    Console.WriteLine($"Your number {secondnumber}");
}
else

Console.WriteLine("Not a three digit number ");
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Showthirddigit(int num)
{
    int n=num;
    while (n>1000 || n<-1000)
    {
      n=n/10;
    }
    n=n%10;
     return n;
}
Console.WriteLine("Enter a  number: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>99 || a<-99)
  {
  int secondnumber=Showthirddigit(a);
  Console.WriteLine($"Your number {secondnumber}");
  }
 else 
  { 
     Console.WriteLine("Your number does not have a third ");
  }
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();
// string weekends(int number)
 
// {
//   string week;
//   if(number<6)
//   {
//     week= "Do you have a working day";
//   }
//   else
//   {
//     week = "Do you have a day off";
//   }
//   return week;
// }
// int a = Convert.ToInt32(Console.ReadLine());
// if(a>0 && a<8)
//   {
//   String secondnumber= weekends(a);
//   Console.WriteLine(secondnumber);

//   }
//  else 
//   { 
//      Console.WriteLine("Your number doesn't match the days of the week");
//   }
