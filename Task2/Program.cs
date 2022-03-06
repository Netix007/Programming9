// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum(int m, int n, int sum)
{
    sum = sum + m;
    if (m < n)
    {
        m++;
        sum = GetSum(m,n,sum);
    }
    return sum;    
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
int sum = 0;
if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
sum = GetSum(m,n,sum);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
