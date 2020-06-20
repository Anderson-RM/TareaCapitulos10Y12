using System;
using System.Collections.Generic;
using System.Text;

namespace TareaCapitulos10Y12.Entidades.Cap10
{
    class Ejercicio3
    {
        /*Crear una clase para polígonos con sobrecarga del constructor.*/
        public class Poligono
        {
            private float lado;
            private float altura;
            private float base1;

            public Poligono(float lado)
            {
                this.lado = lado;
                altura = 0;
                base1 = 0;
            }

            public Poligono(float base1, float altura)
            {
                lado = 0;
                this.base1 = base1;
                this.altura = altura;

            }

            public float Lado
            {
                get
                {
                    return lado;
                }
                set
                {
                    if (value <= 0)
                        lado = 1;
                    else
                        lado = value;
                }
            }

            public float Altura
            {
                get
                {
                    return altura;
                }
                set
                {
                    if (value <= 0)
                        altura = 1;
                }

            }

            private float Base1
            {
                get
                {
                    return base1;
                }
                set
                {
                    if (value <= 0)
                        base1 = 1;
                }
            }
        }/*--------------------------------------FIN--------------------------------------------*/
    }
}
