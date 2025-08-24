using System;

class Program
{
    public static void Main(String[] args)
    {
        Cadeteria cadeteria = new Cadeteria("Cadetería Tucumán", 3811234);
        cadeteria.CargarCadete();
        cadeteria.CargarPedido();
        cadeteria.MostrarPedidos();

    }
}
