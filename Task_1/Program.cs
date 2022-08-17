// Цикл, который принимает на вход два числа (A, B) и возводит 
// число А в натуральную степень В.

int NaturalDegree(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

void PrintNaturalDegree(int A, int B)
{
    Console.WriteLine($"{A} в степени {B} = {NaturalDegree(A, B)}");
}
PrintNaturalDegree(3, 5);
PrintNaturalDegree(2, 4);