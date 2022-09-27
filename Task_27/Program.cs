// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadDataOne(string massage)
{
    Console.Write(massage);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

void PrintData(string massage, int znachenie)
{
    Console.WriteLine(massage + znachenie);
}

int number = ReadDataOne("Введите число: ");
int result = SumOfNumber(number);
PrintData($"Сумма цифр в числе {number} = ", result);