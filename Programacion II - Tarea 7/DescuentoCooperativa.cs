using System;
using System.Collections.Generic;

namespace Programacion_II___Tarea_7
{
    class DescuentoCooperativa : ISujeto
    {
        // Variable de referencia
        IObservador observador;

        // Lista de observadores del sujeto Cooperativa
        private List<IObservador> registroEmpleados = new List<IObservador>();

        public void Suscribirse(IObservador observador)
        {
            registroEmpleados.Add(observador);
            Console.WriteLine($"Se ha inscrito {observador}");
            Console.ReadKey();
        }

        public void Desuscribirse(IObservador observador)
        {
            registroEmpleados.Remove(observador);
            Console.WriteLine($"Ha desuscrito a {observador}");
            Console.ReadKey();
        }

        public void Notificar()
        {
            observador.Actualizar(this);
        }

        public double montoCooperativo(Empleado empleado)
        {
            double descuento = 0;

            float proporcion;

            if (empleado.Salario >= 1000)
            {
                proporcion = 0.05f;

                Console.WriteLine($"El descuento de cooperativa es de: {empleado.Salario * proporcion}");

                empleado.Salario -= (empleado.Salario * proporcion);

                Console.WriteLine($"Quedandole al empleado: {empleado.Salario}");

                return empleado.Salario;
            }
            else if (empleado.Salario >= 5000)
            {
                proporcion = 0.1f;

                Console.WriteLine($"El descuento de cooperativa es de: {empleado.Salario * proporcion}");

                empleado.Salario -= (empleado.Salario * proporcion);

                Console.WriteLine($"Quedandole al empleado: {empleado.Salario}");

                return empleado.Salario;
            }
            else if (empleado.Salario >= 10000)
            {
                proporcion = 0.15f;

                Console.WriteLine($"El descuento de cooperativa es de: {empleado.Salario * proporcion}");

                empleado.Salario -= (empleado.Salario * proporcion);

                Console.WriteLine($"Quedandole al empleado {empleado.Salario}");

                return empleado.Salario;
            }
            else
            {
                descuento = 0;
            }

            return descuento;
        } 
    }
}

