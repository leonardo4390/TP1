using System;


class Pedido
{
    public int Nro { get; private set; }
    public string Obs { get; private set; }
    public Cliente Datocliente { get; private set; }
    public string Estado { get; private set; }

    public Pedido(int nro, string obs, string nombre, string direccion, int telefono, string referenciaDireccion, string estado)
    {
        Nro = nro;
        Obs = obs;
        Datocliente = new Cliente(nombre, direccion, telefono, referenciaDireccion);
        Estado = estado;
    }

    public void VerDireccionCliente()
    {
        Console.WriteLine($"Direccion Cliente: {Datocliente.Direccion} - Referencia: {Datocliente.ReferenciaDireccion}");
        Console.WriteLine();
    }

    public void VerDatoCliente()
    {
        Console.WriteLine("Dato Cliente:");
        Console.WriteLine($"Nombre: {Datocliente.Nombre} - Telefono: {Datocliente.Telefono}");
        Console.WriteLine();
    }
}