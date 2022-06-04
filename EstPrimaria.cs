using System;
namespace  Examen3B
{
    class EstPrimaria:Estudiante
    {
    int Valorfijo {get; set;}
    public EstPrimaria ( string Nombre, string Apellido, string NombreInstitución, int Cedula):base(Nombre,Apellido,NombreInstitución,Cedula)
    {
    this.Valorfijo=Valorfijo;
    }
    public void Valor()
    {
        Valorfijo=100;
    }
    }
}