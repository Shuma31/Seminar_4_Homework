// * Написать калькулятор с операциями +, -, /, * и возведение в степень

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
string ReadDataThree(string massage)
{
    Console.Write(massage);
    string operation = Console.ReadLine();
    return operation;
}
double number1 = ReadDataOne("Введите число A: ");
double number2 = ReadDataTwo("Введите число B: ");
string operation = ReadDataThree("Введите операцию над числом, где: + сложение; - вычитание; * умножение; / деление, ^ возведение в степень. ");

double result = 0;
if (operation == "+")
{
    result = number1 + number2;
}
else if (operation == "-")
{
    result = number1 - number2;
}
else if (operation == "/")
{
    result = number1 / number2;
}
else if (operation == "*")
{
    result = number1 * number2;
}
else if (operation == "^")
{
    result = Math.Pow(number1, number2);
}
else 
{
    Console.WriteLine("Введите корректный оператор!");
}
Console.WriteLine($"{number1} {operation} {number2} = {result}");