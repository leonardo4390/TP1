# TP1
## ¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación? 
**Composicion**:  Pedido - Cliente
**Agregacion**: Cadete - Pedido

## ¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete? 
**Cadeteria** deberia tener como minimo cargarCadete, cargarPedido, mostrarInforme
**Cadete** como minimo deberia tener eliminarPedido, agregarPedido

## Teniendo en cuenta los principios de abstracción y ocultamiento, que campos, propiedades y métodos deberían ser públicos y cuáles privados. 
Considero que como es una entrea de pedidos y encargo: el nombre de la cadeteria deberia ser visible para lectura, pero privada para escribirla, cadete, pedido, cliente lo mismo.

## ¿Cómo diseñaría los constructores de cada una de las clases? 
 **Cadeteria** para recibir el nombre de la empresa y su teléfono como parámetros obligatorios. Estos datos son esenciales para identificar la entidad principal del sistema. Además, inicializaría la lista de cadetes vacía, ya que se irán cargando dinámicamente.
 
 El constructor de **Cadete** debería recibir nombre, dirección y teléfono como datos obligatorios. También se le asigna un ID incremental automáticamente para identificarlo. La lista de pedidos se inicializa vacía, ya que los pedidos se asignan luego.

 El constructor de **Pedido** debe recibir el número de pedido, la observación, el estado del pedido y un objeto Cliente ya creado. Esto asegura que cada pedido tenga su cliente asociado desde el inicio. También se inicializa una lista vacía de productos, que se irán agregando uno por uno.

 El constructor de **Cliente** recibe nombre, dirección, teléfono y referencia de dirección. Estos datos son necesarios para que el cadete pueda ubicar al cliente y contactarlo. No depende de otras clases, pero sí está encapsulado dentro de Pedido.

## ¿Se le ocurre otra forma que podría haberse realizado el diseño de clases? 
dependiendo del enfoque que quieras priorizar: separación de responsabilidades: Lógica de negocio, como asignar pedidos, calcular jornal, validar estados.




