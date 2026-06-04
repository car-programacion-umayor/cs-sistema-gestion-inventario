using System;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Clase que representa la entidad Producto según los requerimientos del sistema.
    /// </summary>
    public class Producto
    {
        // Propiedades automáticas que definen la estructura del registro 
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public int Existencia { get; set; }

        // Constructor para inicializar un nuevo producto con los datos capturados de la GUI 
        public Producto(int cod, string nom, string tip, double val, int exi)
        {
            this.Codigo = cod;
            this.Nombre = nom;
            this.Tipo = tip;
            this.Valor = val;
            this.Existencia = exi;
        }
    }
}
