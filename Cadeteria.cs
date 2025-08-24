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

    public void CargarCadete()
    {

        while (true)
        {
            Console.WriteLine("Ingrese el Nombre del cadete: ");
            var nombreCadete = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del cadete: ");
            var direcionCadete = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del cadete: ");
            int telefonoCadete = Convert.ToInt32(Console.ReadLine());
            Cadete cadete = new Cadete(nombreCadete, direcionCadete, telefonoCadete);
            Cadetes.Add(cadete);

            Console.WriteLine("Desea ingresar otro Cadete?(s/n): ");
            var agregarCadete = Console.ReadLine();

            if (agregarCadete != "s") break;
        }
    }
    public void CargarPedido()
    {
        List<Pedido> pedidos = new List<Pedido>();
        int nro = 0;
        while (true)
        {
            nro++;
            Console.WriteLine("Ingrese observacion del pedido: ");
            var observacio = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre del cliente: ");
            var nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del cliente: ");
            var direccionCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del cliente: ");
            int telefonoCliente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la referencia de la direccion del cliente: ");
            var referencia = Console.ReadLine();
            Console.WriteLine("Ingrese el estado del pedido: ");
            var estadoCliente = Console.ReadLine();
            Pedido pedido = new Pedido(nro, observacio, nombreCliente, direccionCliente, telefonoCliente, referencia, estadoCliente);
            pedidos.Add(pedido);
            Console.WriteLine("Desea ingresar otro Pedido?(s/n): ");
            var agregarPedido = Console.ReadLine();

            if (agregarPedido != "s") break;
                    
        }
    }
}