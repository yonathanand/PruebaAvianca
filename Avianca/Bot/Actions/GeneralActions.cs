using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Avianca.Bot.Actions
{
    class GeneralActions
    {

        public AndroidDriver<AppiumWebElement> driver;        
        private static GeneralActions actor;
        

        public GeneralActions GetActor()
        {
            if (actor == null)
            {
                actor = new GeneralActions();
            }
            return actor;
        }

        public void AsignarDispositivo(string dispositivo)
        {
            // AppiumLocalService _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();;
            //var cap = new AppiumOptions();
            AppiumOptions cap = new AppiumOptions();
            //_appiumLocalService.Start();

            switch (dispositivo)
            {
                case "Nexus":

                    cap.AddAdditionalCapability("deviceName", "3200d0085815a501");
                    cap.AddAdditionalCapability("platformName", "Android");
                    cap.AddAdditionalCapability("platformVersion", "9.0");
                    cap.AddAdditionalCapability("appPackage", "areamovil.aviancataca");
                    cap.AddAdditionalCapability("appActivity", "md52dc9bbc4aa20d1fd38c90601ea9b891b.MainActivity");
                    cap.AddAdditionalCapability("automationName", "UiAutomator2");
                    cap.AddAdditionalCapability("app", Directory.GetCurrentDirectory() + "\\Auxiliar\\Resources\\APK\\Avianca-5.19.6.apk");                    
                    driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), cap);
                break;

            }
        }


        public void Click(AndroidElement boton)
        {
            try
            {
                boton.Click();
            }
            catch (ElementNotSelectableException e)
            {
                Finalizar();
                Assert.Fail("No fue posible realizar clic en el boton " + boton + e);
            }
            catch (Exception e)
            {
                Finalizar();
                Assert.Fail("Error no identificado al realizar clic en el boton " + boton + e);                
            }
        }

        public AndroidElement EsperaId(string id)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
                return (AndroidElement)wait.Until(x => driver.FindElementById(id));
            }

            catch (ElementNotVisibleException e)
            {
                Finalizar();
                Assert.Fail("No fue posible mapear el elemento " + id + e);
                return null;
            }
            catch (Exception e)
            {
                Finalizar();
                Assert.Fail("Error no identificado mapeando el elemento " + id + e);
                return null;
            }
        }

        public AndroidElement EsperaXpath(string xpath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
                return (AndroidElement)wait.Until(x => driver.FindElementByXPath(xpath));
            }

            catch (ElementNotVisibleException e)
            {
                Finalizar();
                Assert.Fail("No fue posible mapear el elemento " + xpath + e);
                return null;
            }
            catch (Exception e)
            {
                Finalizar();
                Assert.Fail("Error no identificado al mapear el elemento" + xpath + e);
                return null;
            }
        }

        public string ExtraerTexto(AndroidElement texto)
        {

            try
            {
                return texto.Text;
            }
            catch (ElementNotVisibleException e)
            {
                Finalizar();
                Assert.Fail("No fue posible extraer el texto " + texto + e);
                return null;
            }
            catch (Exception e)
            {
                Finalizar();
                Assert.Fail("Error no identificado al extraer el texto " + texto + e);
                return null;
            }

        }

        public void Finalizar()
        {     
            driver.Quit();
            driver.CloseApp();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}
