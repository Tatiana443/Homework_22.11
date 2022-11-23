Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = - number;
int DigitsSum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int digitsSum = DigitsSum(number);
Console.WriteLine($"Сумма цифр равна {digitsSum}");

