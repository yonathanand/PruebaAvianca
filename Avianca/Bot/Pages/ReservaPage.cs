using OpenQA.Selenium.Appium.Android;
using Avianca.Bot.Actions;

namespace Avianca.Bot.Pages
{
    class ReservaPage
    {
        public static GeneralActions generalaction = new GeneralActions();
        GeneralActions actor = generalaction.GetActor();


        string lblTitulo = "areamovil.aviancataca:id/toolbar_title";

        public string ExtraerTitulo()
        {
            AndroidElement strTitulo = actor.EsperaId(lblTitulo);
            return actor.ExtraerTexto(strTitulo);
        }

    }
}
