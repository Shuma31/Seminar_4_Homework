// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadDataOne(string massage)
{
    Console.Write(massage);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array [i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
int arrLen = ReadDataOne("Введите длину массива: ");
int[] arr = FillArray(arrLen);
PrintArray(arr);