

void RandomArray(int[] array)
{
    Random rand = new Random();
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = rand.Next(1, 100);
        index++;
    }
}

void PrintArray(int[] printArray)
{
    string output = String.Empty;
    for (int i = 0; i < printArray.Length; i++)
    {
        output += (i < printArray.Length - 1) ? $"{printArray[i]}, " : $"{printArray[i]}";
        
    }
    Console.WriteLine($"{output} -> [{output}]");
}

int[] array = new int[8];

RandomArray(array);
PrintArray(array);
