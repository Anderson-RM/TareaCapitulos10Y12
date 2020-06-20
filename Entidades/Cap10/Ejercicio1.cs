using System;
using System.Collections.Generic;
using System.Text;

namespace TareaCapitulos10Y12.Entidades.Cap10
{
    class Ejercicio1
    {
        /*Crear el diseño de una clase para llevar el inventario de una tienda.*/
        public class Inventario
        {
            private int ID { get; set; }
            private string nombre { get; set; }
            private double precio { get; set; }
            private double costo { get; set; }
            private double cantidad { get; set; }


            public Inventario()
            {
                ID = 0;
                precio = 0;
                costo = 0;
                cantidad = 0;
            }


            public Inventario(int id, string nombre, double costo, double precio, double cantidad)
            {
                this.ID = id;
                this.nombre = nombre;
                this.costo = costo;
                this.precio = precio;
                this.cantidad = cantidad;
            }
        }/*--------------------------------------FIN--------------------------------------------*/
    }
}
