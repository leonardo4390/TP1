using System;

class Program
{
    public static void Main(String[] args)
    {
        string rutaCadeteria = "cadeteria.csv";
        string rutaCadetes = "cadetes.csv";

        Cadeteria cadeteria = new Cadeteria(rutaCadeteria, rutaCadetes);
        while (true)
        {
            Console.WriteLine("\n MENÚ DE GESTIÓN DE PEDIDOS");
            Console.WriteLine("1. Dar de alta pedido");
            Console.WriteLine("2. Asignar pedido a cadete");
            Console.WriteLine("3. Cambiar estado de pedido");
            Console.WriteLine("4. Reasignar pedido a otro cadete");
            Console.WriteLine("5. Mostrar informe");
            Console.WriteLine("6. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    cadeteria.DarDeAltaPedido();
                    break;
                case "2":
                    cadeteria.AsignarPedidoACadete();
                    break;
                case "3":
                    cadeteria.CambiarEstadoPedido();
                    break;
                case "4":
                    cadeteria.ReasignarPedido();
                    break;
                case "5":
                    cadeteria.MostrarInforme();
                    break;
                case "6":
                    Console.WriteLine("Cerrando sistema...");
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }


    }
}
