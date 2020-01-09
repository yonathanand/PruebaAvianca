using OpenQA.Selenium.Appium.Android;
using Avianca.Bot.Actions;

namespace Avianca.Bot.Pages
{
    class InicioPage
    {

        public static GeneralActions generalaction = new GeneralActions();
        GeneralActions actor = generalaction.GetActor();

        string btnPermitirMultimedia = "com.android.packageinstaller:id/permission_allow_button";
        string btnPermitirUbicacion = "com.android.packageinstaller:id/permission_allow_button";
        string btnComprarVuelos = "//android.view.ViewGroup[@content-desc='BookingHomeItem']//android.widget.Button";
        string lblInicio = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[3]/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.TextView";


        public void AbrirAplicacion(string dispositivo)
        {
            actor.AsignarDispositivo(dispositivo);
        }

        public void ParmitirAccesoMultimedia()
        {
            AndroidElement AccesoMultimedia = actor.EsperaId(btnPermitirMultimedia);
            actor.Click(AccesoMultimedia);
        }

        public void PermitirAccesoUbicacion()
        {
            AndroidElement AccesoUbicacion = actor.EsperaId(btnPermitirUbicacion);
            actor.Click(AccesoUbicacion);
        }

        public void SeleccionarOpcComprarVuelos()
        {
            AndroidElement ComprarVuelos = actor.EsperaXpath(btnComprarVuelos);
            actor.Click(ComprarVuelos);
        }
        

        public string ExtraerLblInicio()
        {
            AndroidElement strLblInicio = actor.EsperaXpath(lblInicio);
            return actor.ExtraerTexto(strLblInicio);
        }

        public void Finalizar()
        {
            actor.Finalizar();
        }

    }
}
