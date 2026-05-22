using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoList
{
    
    private List<Alumno> _listaAlumnos = new List<Alumno>();

    
    public void AgregarAlumno(Alumno alumno)
    {
        _listaAlumnos.Add(alumno);
    }

    
    public List<Alumno> ObtenerLista()
    {
        return _listaAlumnos;
    }

    
    public Alumno? BuscarPorNombre(string nombre)
    {
        
        return _listaAlumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    
    public bool EliminarAlumno(Alumno alumno)
    {
        return _listaAlumnos.Remove(alumno);
    }

    
    public void EliminarEnPosicion(int posicion)
    {
       
        if (posicion >= 0 && posicion < _listaAlumnos.Count)
        {
            _listaAlumnos.RemoveAt(posicion);
        }
    }
}