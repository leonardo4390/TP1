using System;
using System.Net.NetworkInformation;

class Cadeteria
{
    public string Nombre { get; private set; }
    public int Telefono { get; private set; }
    public List<Cadete> Cadetes { get; private set; }

    public Cadeteria(string nombre, int telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
        Cadetes = new List<Cadete>();
    }
}