using System;
namespace Examen3B
{
class EstSecundaria:Estudiante
{
    int Valor {get; set;}
public void Datos ( string Nombre, string Apellido, string NombreInstitución, int Cedula):base (Nombre,Apellido,NombreInstitución,Cedula)
{
    
}
public int Valor();
{
  rerturn 20;
}
}