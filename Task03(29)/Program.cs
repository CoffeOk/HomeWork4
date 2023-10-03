// Вывод массива из 8 элементов


int[] RandomAray (int min, int max, int length)
{
    int[] array = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next (min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    string arr = string.Join(",", array);
    for (int i = 0; i < arr.Length; i++)
    {        
        Console.Write ($"{arr[i]}");
    }
}

int[] arr = RandomAray (0, 1000 , 8);
PrintArray (arr);
Console.Write ("-> [");
PrintArray (arr);
Console.Write ("]");

    