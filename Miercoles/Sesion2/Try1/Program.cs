//Leer un numero entero 

int numero = 0;
do
{
    Console.WriteLine("Digite un numero: ");
    try
    {

        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El numero ingresado fue {numero}");

    }
    catch (FormatException ex){
        Console.WriteLine(ex.Message);
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
} while (numero != 0);