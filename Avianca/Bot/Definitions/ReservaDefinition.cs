using System;
using Avianca.Bot.Pages;
using Avianca.Bot.Actions;
using NUnit.Framework;

namespace Avianca.Bot.Definitions
{
    class ReservaDefinition
    {
        public ReservaPage reserva;
        public static GeneralActions generalaction = new GeneralActions();
        GeneralActions actor = generalaction.GetActor();
        public static readonly string ERROR_MSG_TEXT = "Error, al intentar obtener texto {0} se obtuvo: {1}";

        public ReservaDefinition()
        {
            reserva = new ReservaPage();
        }

        public void ValidarTitulo(string texto)
        {
            try
            {
                string retornaMensaje = reserva.ExtraerTitulo();
                Assert.True(retornaMensaje.Equals(texto), string.Format(ERROR_MSG_TEXT + " en extraer valor titulo ", texto, retornaMensaje));
            }
            catch (Exception)
            {
                actor.Finalizar();
                Assert.Fail();
            }
        }
    }
}
