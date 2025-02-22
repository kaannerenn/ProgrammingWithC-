using System.Transactions;

namespace Azon.WeatherLib
{
    /*
        Class Library'ler execute edilebilen assembly'lar değildir. Console uygulamalarının aksine.
        Diğer projelerin referans ederek kullanabileceği fonksiyonellikleri, türleri vs barındırırlar.

        Temperature sınıfındaki amaç hava sıcaklık değerini taşıyan bir veri yapısı sağlamaktır.
        Sahip olması gereken işlevler. Fahrenheit to Celcius vice varsa.

        Senaryo : Belli sıcaklık değerlerine göre bir state bildirimi (Ilık, Sıcak , Nemli , Serin)
     */
    public struct Temperature
    {
        public double Value { get; set; }

        public TemperatureType Type { get; set; }

        public Temperature(double value, TemperatureType type)
        {
            Value = value;
            Type = type;
        }
        public void ConvertToCelcius()
        {
            //Early return
            //Yani kod akışından erken dönülebilme olasılığı varsa uygulanır.
            if (Type == TemperatureType.Celcius)
                return;

            Type = TemperatureType.Celcius;
            Value = (Value - 32) * 5.0 / 9.0;
        }
        public void ConverToFahrenheit()
        {
            if (Type == TemperatureType.Celcius)
            {
                Type = TemperatureType.Fahrenheit;
                Value = (Value * 9.0 / 5.0) + 32;
            }
        }
        /* public double ConvertToCelcius()
         {
             //Early return
             //Yani kod akışından erken dönülebilme olasılığı varsa uygulanır.
             if (Type == TemperatureType.Fahrenheit)
                 return Value;

             Type = TemperatureType.Celcius;
             return (Value * 9.0 / 5.0) + 32;


         }*/
        /*public double ConverToFahrenheit()
        {
            if (Type == TemperatureType.Celcius)
            {
                Type = TemperatureType.Fahrenheit;
                return (Value - 32) * 5.0 / 9.0;
            }
            return Value;
        }*/
        public override string ToString()
        {

            return $"{Value}({Type})";
        }
        public enum TemperatureType
        {
            Celcius,
            Fahrenheit,
        }
    }
}
