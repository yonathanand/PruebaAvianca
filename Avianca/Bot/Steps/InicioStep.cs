using TechTalk.SpecFlow;
using Avianca.Bot.Definitions;

namespace Avianca.Bot.Steps
{
    [Binding]
    public sealed class InicioStep
    {
        InicioDefinition inicio = new InicioDefinition();

        [Given(@"que abro la aplicacion en un celular (.*)")]
        public void AbrirAplicacion(string dispositivo)
        {
            inicio.AbrirAplicacion(dispositivo);
        }

        [Given(@"le doy permisos de multimedia y archivos")]
        public void ParmitirAccesoMultimedia()
        {
            inicio.PermitirAccesoMultimedia();
        }

        [Given(@"le doy permisos de ubicacion")]
        public void PermitirAccesoUbicacion()
        {
            inicio.PermitirAccesoUbicacion();
        }

        [When(@"le doy permisos de ubicacion")]
        public void PermitirAccesoUbicacionEnCuando()
        {
            inicio.PermitirAccesoUbicacion();
        }

        [When(@"Selecciono opcion Comprar vuelos")]
        public void SeleccionarOpcComprarVuelos()
        {
            inicio.SeleccionarOpcComprarVuelos();
        }      


        [Then(@"debe presentar el texto (.*)")]
        public void ValidarPresentacionLblSubtitulo(string texto)
        {
            inicio.ValidarTextoInicio(texto);

        }

        [Then(@"finalizo el escenario")]
        public void ThenFinalizoElEscenario()
        {
            inicio.Finalizar();
        }

    }
}
