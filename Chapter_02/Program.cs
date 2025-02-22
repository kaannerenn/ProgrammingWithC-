using Azon.WeatherLib;
using Chapter_02.UI.View;

namespace Chapter_02
{
    
    internal class Program
     {
        static void Main()
         {
            /*
                Temperature veri yapısı Azon.WeatherLib kütüphanesi içinde yer almaktadır.
                Temperature sınıfı object instance formasyonunda kullanılır. Yani önce new ile bir örnek oluşturulur.
                Sonra bu örneğin erişilebilir olan üyeleri(metotlar gibi) kullanılır.
             */
            var currentWeatherValue = new Temperature(21,Temperature.TemperatureType.Celcius);
            Console.WriteLine(currentWeatherValue);
            currentWeatherValue.ConverToFahrenheit();
            Console.WriteLine(currentWeatherValue);

            Terminal.SplashScreen("Kaan Eren");
            Terminal.ShowMenu();
            Terminal.GetUserInput();
         }
    }
    
}
