// Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int result = 0;

int Akkerman(int m, int n)
{
    if (m > 0 & n > 0)
    {
        result = Akkerman(m-1, Akkerman(m, n-1));
    }
    if (m > 0 & n == 0)
    {
        result = Akkerman(m-1, 1);
    }
    if (m == 0)
    {
        result = n+1;
    }
    return result;
}

int InputNumber(string text, string name)
{
    int number = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"Введите {text} число {name} = ");
        string temp = Console.ReadLine();
        if (Int32.TryParse(temp, out number) && number >= 0)
            {isError = false;}
    }
    return number;
}

int m = InputNumber("первоe", "m");
int n = InputNumber("второе", "n");

result = Akkerman(m,n);
Console.WriteLine($"Результат вычисления функции Аккермана: {result} ");
