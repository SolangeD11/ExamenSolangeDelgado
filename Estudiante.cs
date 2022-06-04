using System;
namespace Examen3B
{
    class Estudiante
    {
    string Nombre {get; set;}
    string Apellido {get; set;}
    string NombreInstitución {get; set;}
    int Cedula {get; set;}  
        public Estudiante ( string Nombre, string Apellido, string NombreInstitución, int Cedula)
    {
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.NombreInstitución=NombreInstitución;
        this.Cedula=Cedula;
    }
    public void ImprimirDatos()
    {
        Console.WriteLine("Nombre:" +Nombre);
    }
    }
}