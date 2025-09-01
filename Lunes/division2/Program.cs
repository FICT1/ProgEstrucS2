
int num1, num2;
int division=0;
Console.Write("Digite un numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite otro numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

try
{
    division = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {division}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre 0");
}
