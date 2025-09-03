try
{
    int max = int.MaxValue;
    int resultado = checked(max + 1);
}
catch (OverflowException ex)
{
    Console.WriteLine($"{ex.Message}");
}