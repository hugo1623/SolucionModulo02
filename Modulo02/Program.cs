using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("sms");
           // var enviadorSMS = new EnviarMiniMensaje();
            var enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("Un mensaje");
            Console.Read();
        }
    }
    public static class FactoriaEnviadorMensaje
    {
        public static IEnviandorMensaje Factoria(string parametro)
        {
            if (parametro == "sms")
            {
                return new EnviarMiniMensaje();
            }
            else if (parametro == "correo") ;
            {
                return new EnviarCorreo();
            }
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

    class EnviarMiniMensaje : IEnviandorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Minimensaje");
        }
    }

    class EnviarCorreo : IEnviandorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Correo");
        }
    }
}
