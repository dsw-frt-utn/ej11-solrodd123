using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{
    
    private List<Libro> _libros = Libro.CrearLista();

    
    public Libro GetPrimero()
    {
        return _libros.First();
    }

    
    public Libro GetUltimo()
    {
        return _libros.Last();
    }

    
    public decimal GetTotalPrecios()
    {
        return _libros.Sum(l => l.Precio);
    }

    
    public decimal GetPromedioPrecios()
    {
        
        return _libros.Average(l => l.Precio);
    }

    
    public List<Libro> GetListById()
    {
        return _libros.Where(l => l.Id > 15).ToList();
    }

    
    public List<string> GetFormatoMoneda() 
    {
        return _libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }

    
    public Libro GetMayorPrecio()
    {
        return _libros.MaxBy(l => l.Precio)!;
    }

    
    public Libro GetMenorPrecio()
    {
        return _libros.MinBy(l => l.Precio)!;
    }

    
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        return _libros.Where(l => l.Precio > promedio).ToList();
    }

    
    public List<Libro> GetLibrosOrdenadosPorTituloDesc() // Cambiá el nombre si el test pide uno específico que quedó cortado
    {
        return _libros.OrderByDescending(l => l.Titulo).ToList();
    }
}