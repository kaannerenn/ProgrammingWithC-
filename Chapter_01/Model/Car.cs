/*
    Bütün tip tanımları (class, struct, interface , delegate, enum vs) bir namespace içinde yer alır.
    Namespace, aynı amaca hizmet eden enstrümanların toplandığı yerdir(Farklı dillerde package , module gibi görebilriz)
    Namaspace, kavramsal bir anlam bütünlüğü sağlar. 
 */
namespace Chapter_01.Model
{
    internal class Car
    {
        public string Name;
        //Color field'ının string yerine kendi tasarladığımız ProductColor enum sabitiyle de kullanabiliriz.
        // public string Color;
        public ProductColor Color; // Color alanı(field) sadece ProductColor enum sabiti türünden bir değer alabilir.
        public string Model;
        public short Year;
    }   
}
