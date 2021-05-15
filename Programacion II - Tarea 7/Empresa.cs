using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_II___Tarea_7
{
    class Empresa
    {
        // Lista de empleados
        private List<Empleado> registroEmpleados = new List<Empleado>();

        // Sujetos
        DescuentoCooperativa descuentoCooperativo = new DescuentoCooperativa();
        DescuentoFarmacia descuentoFarmaceutico = new DescuentoFarmacia();
        DescuentoFunerario descuentoFunerario = new DescuentoFunerario();

        // Interfaz del usuario
        public void miEmpresa()
        {
            int opcion;
            do
            {
                Console.Clear();

                Console.Write("---Empresa---\n" +
                    "\n" +
                    " [1]Crear empleado\n [2]Inscripcion o cancelacion de servicios\n [3]Consumos de la farmacia\n [4]Calcular nomina de empleados\n [5]Salir\n" +
                    "\n" +
                    "Introduzca su opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        registroEmpleados.Add(new Empleado());

                        break;

                    case 2:
                        Console.Clear();
                        ServiciosOpcionales(registroEmpleados);

                        break;

                    case 3:
                        Console.Clear();
                        ConsumosFarmacia(registroEmpleados);
                        break;

                    case 4:
                        CalcularNomina(registroEmpleados);
                        break;

                    case 5:
                        Console.WriteLine("Adios...");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                }

            } while (opcion >= 1 && opcion <= 6);
        }

        private void ServiciosOpcionales(List<Empleado> empleados)
        {
            Console.Clear();

            // Credencial del empleado
            Console.WriteLine("----Identificacion del empleado----");
            Console.Write("Introduzca su nombre de empleado: ");
            string nombre = Console.ReadLine();

            Console.Clear();

            Console.Write("Que desea hacer?\n" +
                          "[1]Suscribirse [2]Desuscribirse [3]Atras\n" +
                          "\n" +
                          "Introduzca su opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:

                    Console.Write("[1]Cooperativo [2]Farmaceutico [3]Funerario\n" +
                                  "Elija a que servicio desea suscribirse: ");
                    int servicio = int.Parse(Console.ReadLine());

                    if (servicio == 1)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoCooperativo.Suscribirse(e);
                            }
                        }
                    }
                    else if (servicio == 2)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoFarmaceutico.Suscribirse(e);
                            }
                        }

                    }
                    else if (servicio == 3)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoFunerario.Suscribirse(e);
                            }
                        }

                    }

                    break;

                case 2:

                    servicio = 0;
                    Console.Write("[1]Cooperativo [2]Farmaceutico [3]Funerario\n" +
                                  "Elija a que servicio desea desuscribirse: ");
                    servicio = int.Parse(Console.ReadLine());

                    if (servicio == 1)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoCooperativo.Desuscribirse(e);
                            }
                        }
                    }
                    else if (servicio == 2)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoFarmaceutico.Desuscribirse(e);
                            }
                        }
                    }
                    else if (servicio == 3)
                    {
                        // Identificamos al empleado
                        foreach (var e in empleados)
                        {
                            if (e.Nombre == nombre)
                            {
                                descuentoFunerario.Desuscribirse(e);
                            }
                        }
                    }

                    break;

                case 3:
                    this.miEmpresa();
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    Console.ReadKey();
                    this.ServiciosOpcionales(empleados);
                    break;
            }
        }

        private double ConsumosFarmacia(List<Empleado> empleados)
        {
            Console.Clear();

            // Credencial del empleado
            Console.WriteLine("----Identificacion del empleado----");
            Console.Write("Introduzca su nombre de empleado: ");
            string nombre = Console.ReadLine();

            Console.Clear();

            double descuento = 0;

            // Identificamos al empleado
            foreach (var e in empleados)
            {
                if (e.Nombre == nombre)
                {
                    double consumoNeto = descuentoFarmaceutico.ConsumosFarmacia();

                    Console.WriteLine($"El consumo de {e.Nombre} es de: {consumoNeto}");
                    e.Consumo += consumoNeto;

                    descuento = e.Consumo / 2;
                    Console.WriteLine($"El monto ha descontar es de: {descuento}");

                    Console.ReadKey();
                }
            }

            return descuento;
        }

        private void CalcularNomina(List<Empleado> empleados)
        {
            Console.Clear();

            // Credencial del empleado
            Console.WriteLine("----Identificacion del empleado----");
            Console.Write("Introduzca su nombre de empleado: ");
            string nombre = Console.ReadLine();

            Console.Clear();

            foreach (var e in empleados)
            {
                if (e.Nombre == nombre)
                {
                    double descCooperativo = descuentoCooperativo.montoCooperativo(e);
                    double descFunerario = descuentoFunerario.MontoFunerario(e);
                }
            }
        }
    }
}   