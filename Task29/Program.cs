int[] array = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(array);
