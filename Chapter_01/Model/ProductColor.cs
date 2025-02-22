namespace Chapter_01.Model
    /*
        Kendi tasarlayabilceğimiz türlerden biride enum sabitleridir.
        Genellikle sayısal ifadeleri daha okunabilir anlamlı ifadelere eşleştirmek için kullanılır.

        enum türleri struct veya class gibi iş yapan fonksiyonları veya metotları içermez.
     */
{
    internal enum ProductColor
    {
        Black = 1,
        White = 2,
        Green = 3,  // İstersek biz bu sayısal değerleri atayabiliriz ya da otomatik olarak kendi atar 0'dan başlayarak.
        Blue = 4,
        Yellow = 5,
    }
    /*
        Renk gibi bir kavram dahi kullanılacağı yere göre farklı veri türleri şeklinde inşa edilebilir.
        Bir grafik programda RGB ayarında kullanılması gerekirken, belki bir e-ticaret business anlamda
        kullanılan sabit renkleri ifade eden bir enum da olablir.
        
        ObjectColor structıda ProductColor.cs gibi ayrı bir dosyaya alınsa iyi olur. SOLID ilkeleri gereği ve bulması daha kolay olur.
     */
    internal struct ObjectColor
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte TransperencyRate;
           
        
        
    }
}
