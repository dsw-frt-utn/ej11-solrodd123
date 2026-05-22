using System;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11;

public class Ejemplos
{
    // 1. Método estático para la opción 1 del menú
    public static void EjemploList()
    {
        Console.WriteLine("=== EJECUTANDO EJEMPLO LIST ===");
        CasoList casoList = new CasoList();

        // Instanciamos alumnos de prueba
        Alumno a1 = new Alumno(1, "Sol", 9.5);
        Alumno a2 = new Alumno(2, "Javier", 8.0);

        // Agregamos y probamos los métodos de CasoList
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);

        Console.WriteLine($"Alumnos registrados en la lista: {casoList.ObtenerLista().Count}");
        
        var buscado = casoList.BuscarPorNombre("Sol");
        Console.WriteLine($"Búsqueda por nombre 'Sol': {buscado?.Nombre} - Promedio: {buscado?.Promedio}");
    }

    // 2. Método estático para la opción 2 del menú
    public static void EjemploDictionary()
    {
        Console.WriteLine("=== EJECUTANDO EJEMPLO DICTIONARY ===");
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Sol", 9.5);
        Alumno a2 = new Alumno(2, "Javier", 8.0);

        // Agregamos y probamos los métodos de CasoDictionary
        casoDict.AgregarAlumno(a1);
        casoDict.AgregarAlumno(a2);

        var buscadoDict = casoDict.BuscarAlumno(2);
        Console.WriteLine($"Búsqueda en Diccionario por ID (Clave 2): {buscadoDict?.Nombre}");
    }

    // 3. Método estático para la opción 3 del menú
    public static void EjemploLinq()
    {
        Console.WriteLine("=== EJECUTANDO EJEMPLO LINQ ===");
        CasoLinq casoLinq = new CasoLinq();

        // Probamos algunos métodos implementados con LINQ sobre los libros
        Console.WriteLine($"Primer libro de la lista: {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"Suma total de los precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Libro con el precio más alto: {casoLinq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"Promedio de precios de los libros: {casoLinq.GetPromedioPrecios():C}");
    }
}