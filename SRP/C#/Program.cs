using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Llamada a la función de prueba
        TestFunction();

        // Espera para leer los resultados
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    public static void TestFunction()
    {
        // Aquí puedes escribir tus pruebas
        // Ejemplo: prueba de suma
        int resultado = Sum(2, 3);

        // Verificación del resultado
        if (resultado == 1)
        {
            Console.WriteLine("La prueba de suma pasó correctamente.");
        }
        else
        {
            Console.WriteLine("La prueba de suma falló. El resultado esperado era 5, pero se obtuvo " + resultado);
        }
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
