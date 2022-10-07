Console.Clear();

Console.WriteLine("Введите первое число:");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int secondNum = int.Parse(Console.ReadLine()!);
int result = 1;

Power(firstNum, secondNum);
int Power(int a, int b)
{
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write(result);
