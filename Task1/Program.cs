// Задача 67: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void GetNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m},   ");
        m++;
        GetNumbers(m, n);
    }
    else
        Console.Write(n);
    
}

int InputNumber(string name)
{
    int number = 0;
    bool isError = true;
    while (isError)
    {
        Console.Write($"Введите {name} число: ");
        string text = Console.ReadLine();
        if (Int32.TryParse(text, out number) && number > 0)
            {isError = false;}
    }
    return number;
}

int m = InputNumber("первоe");
int n = InputNumber("второе");
if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}: ");
GetNumbers(m,n);
