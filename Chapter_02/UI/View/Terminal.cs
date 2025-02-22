namespace Chapter_02.UI.View
    /*
        Terminal aslında kullanıcı ile etkileşimde olunan bir ortam. Genel olarak View olarak ifade edilir.
        Bu uygulamanın UI(User Interface) ile ilgili işlerinin toplandığı, View alanı altında konuşlandırılmıştır.

        Burada en zoru hangi türü hangi namespace altına alacağımıza karar vermektir. Bu anlamda genel yazılım
        prensipleri ve pratikleri var. Örneğin MVC(Model View Controller) veya MVVM (Model View View Model)

        Terminal sınıfının fonksiyonları sadece Console ile çalışır halde. Genel olarak Terminal ile Console sınıfı arasında sıkı
        bağlı bir ilişki olduğunu söyleyebiliriz (Tightly Coupled) OOP tarafında mümkün mertebe nesneler arası bağımlılıkları
        azaltmaya çalışırız. Buda Losely Coupled olarak geçer. Yani amaç Terminal sınıfının sadece Console ile çalışması değil
        örneğin bir IoT terminali ile de çalışması olabilir.
        
        Terminal sınıfının tüm üyeleri static olarak tanımlandığından kendisninde static olması önerilir.(Ama şart değildir.)
     */
{
    internal static class Terminal
    {
        /*
            SplasScreen herhangi bir parametre almayan ve değer döndürmeyen (void) bir metottur.
            Main metodu static tanımlanmış bir metot olduğundan , Program sınıf içindeki SplasScreen metodunun
            çağrılabilmesi için onun da static tanımlanması gerekir.

            Bir metodu, parametre yapısını farklılaştırarak çoğaltabilir ve aynı isimle kullanabiliriz.(Overloading)
            Console.Writeline metoduda bir overloaded metottur. Üstüne geldiğinde 18 çeşidi olduğunu görebiliriz.
            Örneğin burada SplashScreen metodunun üstüne geldiğimizde de 2 sayısını görebiliriz. Eğer bir string
            girersek 2. yazdığımız metod eğer bir şey girmezsek ilk yazdığımız metod çalışacak. Kullandığımız metodlardan
            çalışan biraz daha açık renkli, kullanılmayan daha soluk renkli gözükecek.

            Overloading işleminde kural parametre sayısı ve türleri ile alakalıdır. (Method Signature)

            Eğer aksini belirtmezsek , sınıf üyeleri private erişim belirleyicisine sahiptir.(Access Modifiers)
            private, public, internal, protected ve protected internal şeklinde 5 temel Access Modifier vardır.

            internal Access Modifier sadece tanımlı olduğu proje için kullanımı serbest bırakır.
            public ise her yerden erişilebilir anlamındadır.

            Benzer amaca hizmet eden tipleri ( class , struct, enum , interface , delegate) aynı namespace çatısı altında toplamak
            veya aynı/benzer amaca hizmet eden üyeleri/members (field , property, method, event, constructor....) aynı tip altında
            toplamak, domain anlamında bütünsellik sağlamak için önemlidir.
            Örneğin, terminal ekranı ile ilgili yapılacak işleri Terminal isimli bir sınıf altında topladığımız gibi.
         */
        internal static void SplashScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************");
            Console.WriteLine("**Welcome Stranger**");
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal static void SplashScreen(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine(new String('*',18));
            Console.Write(GetSmartText('*', 18)); //Console.Write komutu yan yana yazar.
            Console.WriteLine("Welcome {0}", playerName);
            Console.WriteLine(new string('*', 18));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
        internal static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Başlat(B)");
            Console.WriteLine("Puan Tablosu(P)");
            Console.WriteLine("Ayarlar(A)");
            Console.Write(GetSmartText('-', 24));
            Console.WriteLine("Çıkış(C)");
            Console.WriteLine("Bir seçim yapın.");
        }
        internal static void GetUserInput()
        {
            /*
                Terminal ekranından girdi almanın bir yolu ReadLine methodunu kullanmaktır.
                ReadLine metodu kullanıcıdan girdileri string olarak alır.
             */
            var input = Console.ReadLine();
            var userInput = input.ToUpper();
            /*switch (userInput)
            {
                case "B":
                    Console.WriteLine("Oyun Başlıyor...");
                    break;
                case "P":
                    Console.WriteLine("Puan Tablosu");
                    break;
                case "A":
                    Console.WriteLine("Ayarlar");
                    break;
                case "C":
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;
                default:
                    Console.WriteLine("Bilinmeyen bir komut.");
                    break;
            }*/ // if-else yerine switch case de kullanabilirdik.
            if (userInput == "B")
            {
                Console.WriteLine("Oyun Başlıyor...");
            }
            else if (userInput == "P")
            {
                Console.WriteLine("Puan Tablosu");
            }
            else if (userInput == "A")
            {
                Console.WriteLine("Ayarlar");
            }
            else if (userInput == "C")
            {
                Console.WriteLine("Çıkış Yapılıyor");
            }
            else
            {
                Console.WriteLine("Bilinmeyen bir komut.");
            }
        }
        /*
            GetSmartText metodu parametrelere göre bir string üretip döndürür.
         */
        static string GetSmartText(char c, int count)
        {
            string result = string.Empty; // Geriye bir string döneceği için başlangıçta tanımladık.
            //count sayısı kadar ileri hareket edecek bir döngü başlattık.
            //TODO@Kaan for döngüsü yerine while, do while döngüleri ile aynı işi yap.
            for (int i = 0; i < count; i++)
            {
                result += c;  // String'e += ile c argümanını ekledik.
            }
            result += "\n"; /* Newline karakteride ekledik. new line, tab gibi karakterler Escape Character olarak ifade edilir. 
                               \ ile yazılır.*/

            return result;

        }
        /*static string GetSmartText(char c, int count)
        {
            string result = string.Empty;
            int i = 0;
            while (i < count)
            {
                i++;
                result += c;
            }
            result += "\n";

            return result;
        }*/ //TODO kısmının ilk örneği while ile.

        /*static string GetSmartText(char c, int count)
        {
            string result = string.Empty;
            int i = 0;
            if(count>0) // count 0'dan küçükse döngüye girmemeli.
            {
                do
                {
                    result += c;
                    i++;
                } while (i < count);
            }
            result += "\n";
            return result;  
        }*/ // burada da do while ile yapılmış hali mevcut.
    }
}
    

