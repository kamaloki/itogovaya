
string[] array = new string[4]{"hello", "cat", "21", "work"};

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

PrintArray();