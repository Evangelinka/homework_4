// Программа, которая принимает на вход число и выдает сумму цифр в числе.

int SumDigits(int N)
{
    int str_count = Convert.ToString(N).Length;
    int digit_count = 0;
    int result = 0;
    for(int i = 0; i < str_count; i++)
    {
        digit_count = N - N % 10;
        result += N - digit_count;
        N /= 10;
    }
    return result;
}

void PrintSumDigits(int N)
{
    Console.WriteLine($"Сумма цифр в числе {N} = {SumDigits(N)}");
}

PrintSumDigits(452);
PrintSumDigits(82);
PrintSumDigits(9012);