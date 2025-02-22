//Uygulama sınıfımızın adı program
using Chapter_01.Model;
/*
    Bir tipi başka bir tür içinde (program sınıfı gibi) kullanırken dahil olduğu namespace bilgisini eklemek gerekebilir.
 */

internal class Program
{
    /*Executable binary'lerin (Console App , Windows App) ilk giriş noktası Main metodudur.
      İsterse main fonksiyonu terminalden ya da başka bir input kaynağından parametre alabilir.(args değişkeni)
      args değişkeni n adet parametre alabilen bir string dizidir (Array).
      
    Main metodu genelde bir sonuç döndürmez ama istisnai durumlar vardır. Eğer program çıktısı veya OS  için önemliyse.

    Bir metod geriye bir şey döndürmeyecekse void olarak tanımlanır.

    Main methodu varsayılan olarak private erişim belirleyicisen sahiptir. Yani sadece program sınıfı içinde kullanılabilir.
    ve aynı zamanda statik bir metoddur(statik metodlar tanımlandıkları nesnenin örneğine ihtiyaç olmadan kullanilabilirler).
    
    Örneğin Console sınıfının Writeline metodu statik bir fonksiyondur.

    Sınıflar(program sınıfı gibi) metotlar(static , constructor, destructor vs...), alanlar(fields), özellikler(properties), 
    veya başka türleride içerebilir.
     */
    private static void Main(string[] args)
    {
        Console.Beep();
        Console.WriteLine("Hello, World!"); /*WriteLine ve Beep örneği , Console sınıfının statik metotlarıdır.
                                             Nesne örneğine ihtiyaç duymazlar*/
        string fullName = "Kaan Eren Yavuz";
        /* var keyword ile tanımlanan değişkenler, eşitliğin sağ tarafına bakıp uygun veri türünü alırlar. Mesela alttaki örnek
        otomatik olarak string */
        var blogAdress = "kaanerenyavuz.com";

        // Aynı scope { } içerisinde aynı isimde değişkenler tanımlanamaz. 
        var age = 47;
        //short age = 47; aslında yukarıdaki ifadeyle aynı şey sadece var ile tanımladığımızda kendi short diye atıyor.
        byte redValue = 210;
        bool isOnline = true;
        char flag = 'O';

        double pi = 3.14;
        decimal productPrice = 999.45M; // eğer sonuna M koymazsak sayıyı double olarak kullan uyarısı verebilir.
        float e = 2.22F;

        /* 
            .NET platformunda CTS (Common Type System) üzerinden gelen built-in türler dışında (yukarıdaki türler),
            kendi türlerimizide tasarlayabiliriz. Bunun için class, struct, enum gibi blokları kullanabiliriz.
        */
        Car toyota = new Car();
        toyota.Name = "Toyotam";
        toyota.Year = 2016;
        toyota.Model = "Toyota Corolla";
        //toyota.Color = "Black";
        toyota.Color = ProductColor.Black;

        /*
            Aşağıdaki IP adresini string olarak değilde daha kullanışlı olması için bir struct olarak tasarlayalım.
         */
       // string localIpAdress = "127.0.0.1";

        // IPAddress (Built-in gelen bu sınıf IP adresleri ile ilgilidir , inceleyebilirsin.) Bizim yaptığımız çok basit bir Ip structı.


        var printerAddress = new IpInfo
        {
            Part1 = 192,
            Part2 = 168,
            Part3 = 1,
            Part4 = 1,
        };
        Console.WriteLine("{0},{1},{2},{3}", printerAddress.Part1, printerAddress.Part2, printerAddress.Part3, printerAddress.Part4);
    }
}