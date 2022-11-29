
void ShowArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {    
        Console.Write (array[i]+" ");    
    }
    Console.WriteLine();
}

string [] ArrayWithStringsOf3Char (string [] arr )
{
    string [] array = new string [arr.Length];
    for (int i = 0,j=0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3)
        {
            array[j]=arr[i];
            j++;
        }
    }
    return array;
}
string [] array = {"bd","retert","work","2","tr","tre"};
ShowArray(ArrayWithStringsOf3Char(array));