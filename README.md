# Sistema de Gestión de Inventario y Ventas

**Asignatura:** Programación en C# (`cs-`)

---

Aplicación de escritorio desarrollada en C# con Windows Forms para la gestión y almacenamiento temporal de productos en memoria. 

## Arquitectura del Sistema

El sistema está implementado bajo un esquema de acoplamiento directo entre la interfaz gráfica y las estructuras de datos, utilizando principios básicos de Programación Orientada a Objetos (POO):

*   **Estructura de Datos en Memoria:** El almacenamiento de los registros se realiza mediante la clase `ArrayList` (`Catalogo`), una colección dinámica que permite la inserción continua de objetos sin un límite de tamaño fijo predefinido.
*   **Modelado de Datos (`Producto.cs`):** Clase que actúa como molde para las entidades del sistema, encapsulando cinco atributos base: código, nombre, tipo, valor y existencia (stock). Los datos son asignados a través de un constructor clásico al capturarse desde la interfaz.
*   **Punto de Entrada (`Program.cs`):** Inicializa la configuración de la interfaz gráfica y levanta de forma síncrona el formulario principal de la aplicación.
*   **Interfaz de Usuario:** Control de pantallas gestionado a través de componentes *User Controls* (`UC_`) que se cargan dinámicamente dentro de un contenedor único en el formulario principal (`FrmGestionInventario.cs`).
