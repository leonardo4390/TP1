using System;
using System.Collections.Generic;

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
        while (true)
        {
            nro++;
            Console.WriteLine("Ingrese observación del pedido:");
            var obs = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del cliente:");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese dirección del cliente:");
            var direccion = Console.ReadLine();
            Console.WriteLine("Ingrese teléfono del cliente:");
            int telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese referencia de dirección:");
            var referencia = Console.ReadLine();
            Console.WriteLine("Ingrese estado del pedido:");
            var estado = Console.ReadLine();

            Pedido pedido = new Pedido(nro, obs, nombre, direccion, telefono, referencia, estado);

            Console.WriteLine("¿Desea agregar productos al pedido? (s/n):");
            while (Console.ReadLine().ToLower() == "s")
            {
                Console.WriteLine("Seleccione una comida:");
                foreach (var comida in Enum.GetValues(typeof(Producto.Comida)))
                {
                    Console.WriteLine($"- {comida}");
                }

                var entrada = Console.ReadLine();
                if (Enum.TryParse(entrada, out Producto.Comida tipo))
                {
                    pedido.AgregarProducto(tipo);
                    Console.WriteLine("¿Agregar otra comida? (s/n):");
                }
                else
                {
                    Console.WriteLine("Comida inválida.");
                }
            }

            if (Cadetes.Count > 0)
            {
                Cadetes[0].Pedidos.Add(pedido);
                Console.WriteLine($"Pedido asignado a cadete: {Cadetes[0].Nombre}");
            }

            Console.WriteLine("¿Desea ingresar otro pedido? (s/n):");
            if (Console.ReadLine().ToLower() != "s") break;
        }
    }

    public void MostrarPedidos()
    {
        foreach (var cadete in Cadetes)
        {
            Console.WriteLine($"\nCadete: {cadete.Nombre} (ID: {cadete.Id})");
            foreach (var pedido in cadete.Pedidos)
            {
                Console.WriteLine($"Pedido #{pedido.Nro} - Estado: {pedido.Estado}");
                pedido.VerDatoCliente();
                pedido.VerDireccionCliente();
                pedido.VerProductos();
            }
        }
    }
}