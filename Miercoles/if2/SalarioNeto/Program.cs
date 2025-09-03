//Elaborar una aplicacion que calcule el salario neto de un empleado que gana por produccion 

// Parámetros adicionales (pueden ser fijos o variables)
//BONO_EXTRA ← 0
//LIMITE_BONO ← 1000 // Unidades mínimas para bono
//MONTO_BONO ← 200   // Bono fijo si supera el límite

using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.Write("Nombre del Empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el numero de unidades producidas: ");
        int unidadesProducidas = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el pago por unidad producida: ");
        decimal pagoPorUnidad = decimal.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el porcentaje de descuento: ");
        float porcentajeDescuento = float.Parse(Console.ReadLine()!);

        decimal bonoExtra = 0;
        int LIMITE_BONO = 1000; // Unidades mínimas para bono
        decimal MONTO_BONO = 200;   // Bono fijo si supera el límite

        //CALCULOS
        decimal salarioBruto = unidadesProducidas * pagoPorUnidad;
        if (unidadesProducidas > pagoPorUnidad)
        {
            bonoExtra += bonoExtra;
        }
        salarioBruto += bonoExtra;

        decimal descuento = salarioBruto * ((decimal)porcentajeDescuento / 100);
        decimal salarioNeto = salarioBruto - descuento;

        //Salidas finales
        Console.Write("-------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"Nombre del Empleado: {nombre} ");
        Console.WriteLine($"Salario Bruto: {salarioBruto}");
        Console.WriteLine($"Descuento: {descuento}");
        Console.WriteLine($"Salario Neto: {salarioNeto}");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------");

    }
}