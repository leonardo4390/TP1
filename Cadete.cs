using System;

using System.Collections.Generic;

class Cadete
{
    private static int idGlobal = 0;

    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string Direccion { get; private set; }
    public int Telefono { get; private set; }
    public List<Pedido> Pedidos { get; private set; }

    public Cadete(string nombre, string direccion, int telefono)
    {
        Id = ++idGlobal;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Pedidos = new List<Pedido>();
    }
}