using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_II___Tarea_7
{
    interface ISujeto
    {
        void Suscribirse(IObservador observador);
        void Desuscribirse(IObservador observador);
        void Notificar();
    }
}
