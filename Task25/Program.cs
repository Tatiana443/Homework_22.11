Console.WriteLine("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B < 0) B = -B;
void DegreeNum(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Number A in the degree B = {result}");
}
DegreeNum(A, B);



