using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Cadeteria
{
    private string nombre;
    private int telefono;
    public List<Cadete> Cadetes { get; private set; }

    public Cadeteria(string nombre, int telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        Cadetes = new List<Cadete>();
    }

    public void CargarCadete()
    {
        while (true)
        {
            Console.WriteLine("Ingrese el nombre del cadete:");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cadete:");
            var direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono del cadete:");
            int telefono = Convert.ToInt32(Console.ReadLine());

            Cadete cadete = new Cadete(nombre, direccion, telefono);
            Cadetes.Add(cadete);

            Console.WriteLine("¿Desea ingresar otro cadete? (s/n):");
            if (Console.ReadLine().ToLower() != "s") break;

        }
    }

    public void CargarPedido()
    {
        int nro = 0;
        Console.WriteLine("\nGenerar Pedidos:");
        while (true)
        {
            nro++;
            Console.WriteLine("Observación del pedido: ");
            var obs = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del cliente: ");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese dirección del cliente: ");
            var direccion = Console.ReadLine();
            Console.WriteLine("Ingrese teléfono del cliente: ");
            int telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese referencia de dirección: ");
            var referencia = Console.ReadLine();
            Console.WriteLine("Estado del pedido (pendiente / entregado): ");
            var estado = Console.ReadLine();

            Cliente cliente = new Cliente(nombre, direccion, telefono, referencia);
            Pedido pedido = new Pedido(nro, obs, cliente, estado);

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Seleccione una comida:");
                foreach (var comida in Enum.GetValues(typeof(Producto.Comida)))
                {
                    Console.WriteLine($"* {comida}");
                }

                var entrada = Console.ReadLine();
                if (Enum.TryParse(entrada, out Producto.Comida tipo))
                    pedido.AgregarProducto(new Producto(tipo));
                else
                    Console.WriteLine("Comida inválida.");
                Console.WriteLine("¿Agregar otro producto? (s/n): ");
                if (Console.ReadLine().ToLower() != "s") break;

            }
            pedido.MostrarTicket();
            
            Console.WriteLine("Ingrese ID del cadete para asignar el pedido: ");
            foreach (var cad in Cadetes)
                Console.WriteLine($"ID: {cad.Id} - {cad.Nombre}");

            int id = Convert.ToInt32(Console.ReadLine());
            Cadete cadete = Cadetes.FirstOrDefault(c => c.Id == id);
            cadete?.AgregarPedido(pedido);

            Console.WriteLine("¿Agregar otro pedido? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") break;

        }
    }

    public void MostrarInforme()
    {
        Console.WriteLine($"\nInforme de actividad - {nombre}");
        foreach (var cadete in Cadetes)
        {
            int entregados = cadete.Pedidos.Count(p => p.Estado.ToLower() == "entregado");
            int jornal = entregados * 500;
            Console.WriteLine($"\nCadete: {cadete.Nombre} - ID: {cadete.Id}");
            Console.WriteLine($"Pedidos Asignados: {cadete.Pedidos.Count}");
            Console.WriteLine($"Pedidos entregados: {entregados}");
            Console.WriteLine($"\nJornal: {jornal}");
        }
    }
}