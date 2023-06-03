// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int date = Number("Введите число: ");
Console.WriteLine($"Сумма цифр {date} = {Sumnum(date)}");

int Number(string message)
{
Console.WriteLine("Введите число:");
string a = Console.ReadLine();
int result = int.Parse(a);
return result;
}

int Sumnum(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum += n % 10;
        n = n / 10;
    }
    return sum;
}