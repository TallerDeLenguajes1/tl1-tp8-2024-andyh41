// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Tarea{
    int tareaid;
    string? descripcion;
    int duracion;
    EstadoTarea estado;

    public Tarea(int tareaid, string descripcion, int duracion, EstadoTarea estado) {
        this.tareaid=tareaid;
        this.descripcion=descripcion;
        this.duracion=duracion;
        this.estado=estado;
    }
    public int Tareaid { get => tareaid; set => tareaid = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    internal EstadoTarea Estado { get => estado; set => estado = value; }

    public string ShowTarea(){
        return Tareaid + " | " + Descripcion + " | " + Duracion + " | " + Estado.ToString();
    }
}

enum EstadoTarea
{
    completado=1,
    pendiente=0
}