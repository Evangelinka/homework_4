// Программа, которая задает массив из 8 элементов и выводит их на экран

int[] Array(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,30);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

PrintArray(Array(8));