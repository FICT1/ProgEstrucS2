//**Desarrolle un programa que calcule el tiempo total en horas de un viaje en bus desde Managua a Granada,
//donde el usuario ingresa la velocidad promedio en kilómetros por hora como entrada,
//asumiendo una distancia fija de 40 kilómetros

using System;
class Program
{
    int distancia = 40; //kilometros
    static void Main(string[] args)
    {
        Program p = new Program();
        p.CalcularTiempo();
    }
    void CalcularTiempo()
    {
        Console.Write("Ingrese la velocidad promedio en km/h: ");
        double velocidad = Convert.ToDouble(Console.ReadLine());
        double tiempo = distancia / velocidad;
        Console.Write($"El tiempo total del viaje es de {tiempo} horas.");
    }

}

