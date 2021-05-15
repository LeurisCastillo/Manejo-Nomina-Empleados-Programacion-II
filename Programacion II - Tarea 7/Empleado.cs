using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_II___Tarea_7
{
    class Empleado : IObservador
    {
        #region Atributos

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public double Salario { get; set; }
        public double Consumo { get; set; }

        #endregion

        public Empleado()
        {
            Console.Clear();

            Console.Write("Introduzca su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Introduzca su apellido: ");
            Apellido = Console.ReadLine();

            Console.Write("Introduzca su email: ");
            Email = Console.ReadLine();

            Console.Write("Introduzca su salario: ");
            Salario = double.Parse(Console.ReadLine());

            FechaDeInicio = DateTime.Now;
        }

        public void Actualizar(ISujeto sujeto)
        {
            throw new NotImplementedException();
        }
    }
}
