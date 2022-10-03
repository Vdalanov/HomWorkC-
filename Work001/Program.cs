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