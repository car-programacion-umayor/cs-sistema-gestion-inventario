using System;
using System.Collections;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Clase encargada de la gestión del arreglo dinámico Catalogo. 
    /// Permite el almacenamiento de datos con un largo ilimitado. 
   /// </summary>
    internal class Inventario
    {
        // Estructura de datos dinámica (ArrayList) solicitada en los requerimientos.
        public static ArrayList Catalogo = new ArrayList();

         /// <summary>
         /// Método que permite la inserción de nuevos registros al catálogo de productos. 
         /// </summary>
        public static void AgregarProducto(int cod, string nom, string tip, double val, int exi)
        {
            // Se instancia y se añade el objeto Producto al ArrayList "Catalogo". 
            Catalogo.Add(new Producto(cod, nom, tip, val, exi));
        }
    }
}