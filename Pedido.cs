using System;


using System;
using System.Collections.Generic;

class Pedido
{
    public int Nro { get; private set; }
    public string Obs { get; private set; }
    public Cliente Datocliente { get; private set; }
    public string Estado { get; private set; }
    public List<Producto> Productos { get; private set; }

    public Pedido(int nro, string obs, string nombre, string direccion, int telefono, string referenciaDireccion, string estado)
    {
        Nro = nro;
        Obs = obs;
        Datocliente = new Cliente(nombre, direccion, telefono, referenciaDireccion);
        Estado = estado;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto.Comida tipo)
    {
        Productos.Add(new Producto(tipo));
    }

    public void VerDireccionCliente()
    {
        Console.WriteLine($"Dirección: {Datocliente.Direccion} - Referencia: {Datocliente.ReferenciaDireccion}");
    }

    public void VerDatoCliente()
    {
        Console.WriteLine($"Cliente: {Datocliente.Nombre} - Tel: {Datocliente.Telefono}");
    }

    public void VerProductos()
    {
        Console.WriteLine("Productos:");
        foreach (var producto in Productos)
        {
            Console.WriteLine($"- {producto}");
        }
    }
}