// Insertion sort algorithm page 40
void FillArray(int[] inArray)
{
    int length = inArray.Length;
    int index = 0;
    while (index < length)
    {
        inArray[index] = new Random().Next(0,987);
        index++;
    }
}

void PrintArray(int[] inArray)
{
    int length = inArray.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(inArray[index] + " - ");
        index++;
    }
}

void SortInsertionArray(int[] inArray)
{
    int key = 0;
    int length = inArray.Length;
    int i = 0, j = 0;
    for (j = 1; j < length; j++)
    {
        Console.WriteLine(j);
        key = inArray[j];
        Console.WriteLine("32 " + key);
        i = j-1;
        Console.WriteLine(i);
        if (inArray[i] > key)  {
            inArray[i+1] = inArray[i];
            inArray[i] = key;
        }
        while ( (i > 0) & (inArray[i] > key) )
        {
            inArray[i+1] = inArray[i];
            inArray[i] = key;
            i = i - 1;
      //      inArray[i] = key;
        } 
    }

}


// Console.Clear();

int[] arr = new int[6];
FillArray(arr);
Console.WriteLine();
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-------------------- now sorted array -----------------");
Console.WriteLine();
Console.WriteLine();
SortInsertionArray(arr);
Console.WriteLine();
Console.WriteLine();
PrintArray(arr);