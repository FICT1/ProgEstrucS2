int num1, num2;
float division; 

Console.Write("Digite un numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite otro numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

division = (float)num1 / (float)num2;

Console.WriteLine($"{num1} / {num2} es igual a {division}");

