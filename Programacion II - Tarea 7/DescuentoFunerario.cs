using System;
using System.Collections.Generic;

namespace Programacion_II___Tarea_7
{
    class DescuentoFunerario : ISujeto
    {
        // Variable de referencia
        IObservador observador;

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

        public double MontoFunerario(Empleado empleado)
        {
            double montoFijo = 2000;

            if (empleado.Salario >= 3000)
            {
                Console.WriteLine($"El valor descontado de la funeraria es de: {empleado.Salario - montoFijo}");
                empleado.Salario -= montoFijo;
            }

            return empleado.Salario;
        }
    }
}
