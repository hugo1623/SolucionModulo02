using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorSMS = new EnviarMiniMensaje();
            var enviadorMensaje = new EnviadorMensaje(enviadorSMS);
            enviadorMensaje.EnviarMensaje("Un mensaje");
            Console.Read();
        }
    }
    public class EnviadorMensaje
    {
        public EnviadorMensaje(IEnviandorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }
        private IEnviandorMensaje _enviadorMensaje;

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }
     public interface IEnviandorMensaje
    {
       public void EnviarMensaje(string mensaje);
    }

    class EnviarMiniMensaje: IEnviandorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Minimensaje");
        }
    }

    class EnviarCorreo: IEnviandorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Correo");
        }
    }
   
}
