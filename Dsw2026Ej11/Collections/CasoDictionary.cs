using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    
    private Dictionary<int, Alumno> _diccionarioAlumnos = new Dictionary<int, Alumno>();

    
    public void AgregarAlumno(Alumno alumno)
    {
        
        _diccionarioAlumnos.TryAdd(alumno.Id, alumno);
    }

    
    public Alumno? BuscarAlumno(int id)
    {
        if (_diccionarioAlumnos.TryGetValue(id, out var alumno))
        {
            return alumno;
        }
        return null;
    }

    
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _diccionarioAlumnos;
    }

    
    public bool EliminarAlumno(int id)
    {
        return _diccionarioAlumnos.Remove(id);
    }
}