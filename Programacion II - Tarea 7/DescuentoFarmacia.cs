using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_II___Tarea_7
{
    class DescuentoFarmacia : ISujeto
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

        public double ConsumosFarmacia()
        {
            Console.Write("Cual es la cantidad que consumio?\n" +
                              "Introduzca el consumo aqui: ");
            double consumos = double.Parse(Console.ReadLine());

            return consumos;
        }
    }
}