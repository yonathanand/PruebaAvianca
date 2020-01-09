using System;
using Avianca.Bot.Pages;
using Avianca.Bot.Actions;
using NUnit.Framework;

namespace Avianca.Bot.Definitions
{
    class InicioDefinition
    {
        
        public InicioPage inicio;
        public static GeneralActions generalaction = new GeneralActions();
        GeneralActions actor = generalaction.GetActor();
        public static readonly string ERROR_MSG_TEXT = "Error, al intentar obtener texto {0} se obtuvo: {1}";


        public InicioDefinition()
        {
            inicio = new InicioPage();
        }

        public void AbrirAplicacion(string dispositivo)
        {
            inicio.AbrirAplicacion(dispositivo);
        }

        public void PermitirAccesoMultimedia()
        {
            inicio.ParmitirAccesoMultimedia();
        }

        public void PermitirAccesoUbicacion()
        {
            inicio.ParmitirAccesoMultimedia();
        }

        public void SeleccionarOpcComprarVuelos()
        {
            inicio.SeleccionarOpcComprarVuelos();
        }    


        public void ValidarTextoInicio(string texto)
        {
            try
            {
                string retornaMensaje = inicio.ExtraerLblInicio();
                Assert.True(retornaMensaje.Equals(texto), string.Format(ERROR_MSG_TEXT + " en extraer texto inicio", texto, retornaMensaje));
            }
            catch (Exception)
            {
                actor.Finalizar();
                Assert.Fail();
            }
        }

        public void Finalizar()
        {
            inicio.Finalizar();
        }

    }
}
