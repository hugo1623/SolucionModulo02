using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var miniMensaje = new EnviarMensaje();
            var enviarCorreo = new EnviarCorreo();
            Enviar(miniMensaje), "prueba";
            Enviar(enviarCorreo), "prueba2";
        }
        public static void Enviar(IEnviarMensaje mensajero, string mensaje)
        {
            mensajero.EnviarMensaje(mensaje);
        }

    }
    interface IEnviarMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    class EnviarMensaje : IEnviarMensaje
    {
        public void Enviarmensaje(string mensaje)
        {
            
            Console.WriteLine("enviando Minimensaje ");
        }
        public string CualquierMetodo()
        {
            return "Lo que sea";
        }

    }
    class EnviarCorreo : IEnviarMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("EnviarCorreo");
        }
    }


}
