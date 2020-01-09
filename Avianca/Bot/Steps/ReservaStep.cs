using TechTalk.SpecFlow;
using Avianca.Bot.Definitions;

namespace Avianca.Bot.Steps
{
    [Binding]
    public sealed class ReservaStep
    {
        ReservaDefinition reserva = new ReservaDefinition();

        [Then(@"debe presentar el titulo de la pagina de reservas (.*)")]
        public void ValidarTitulo(string texto)
        {
            reserva.ValidarTitulo(texto);
        }

    }
}
