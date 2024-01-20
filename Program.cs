
string[] array = new string[4]{"hello", "cat", "21", "work"};
string[] newArray = new string[4];

void PrintArray()
{
   Console.Write($"Начальный массив: [{string.Join(", ", array)}]");
}

int index = array.Length - 1;

void PrintNewArray(string[] array, int index, int index2)
{
    int count = 0;

    if(index < 0)
    {
        return;
    }
    
    for(int i = 0; i < array[index].Length; i++)
    {
        count++;
    }

    if(count <= 3)
    {
        newArray[index2] = array[index];
        Console.Write(newArray[index2] + ", ");
    }

    PrintNewArray(array, index - 1, index2 + 1);
}


PrintArray();
Console.WriteLine();
Console.Write("Конечный массив: [");
PrintNewArray(array, index, 0);
Console.Write("]");