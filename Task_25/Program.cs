// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadDataOne(string massage)
{
    Console.Write(massage);
    int number1 = int.Parse(Console.ReadLine());
    return number1;
}
int ReadDataTwo(string massage)
{
    Console.Write(massage);
    int number2 = int.Parse(Console.ReadLine());
    return number2;
}

int NumberToPower(int number1, int number2)
{
    int result = 1;
    for(int i = 0; i < number2; i++)
    {
        result = result * number1;
    }
    return result;

}

void PrintData(string massage, int znachenie)
{
    Console.WriteLine(massage + znachenie);
}

int number1 = ReadDataOne("Введите число, которое нужно возвести в степень: ");
int number2 = ReadDataTwo("Введите степень, в которую нужно возвести число: ");
int result = NumberToPower(number1, number2);
PrintData($"Число {number1} в степени {number2} = ", result);
