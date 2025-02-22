namespace Chapter_01.Model
{
    /*
        struct ve class arasındaki en temel fark bellekte tutulma biçimidir.
        Structlar değer türü (value type) formatında , kaplayacakları alanlar belli olan türlerdir ve bellekte stack bölgesinde dururlar
        Classlar ise refereans türü (reference type) formatında olup kaplayacakları alan genelde runtime'da belli olan, değişebilen
        ve bu sebeplerden belleğin Heap bölgesinde duran enstrumanlardır.

        Buna göre birbirleri arasındaki atamalar farklılık gösterebilir.

        Kendi tasarlayacağımız türler class olmak zorunda değildir. Veri içeriğine göre bunları struct olarakta ele alabiliriz.

        Ip adresleri 0-255 arasında değer aldıkları için class türünde açıp heapte fazladan yer kaplatmaya gerek yoktur.
        Zaten kapladıkları alan belli olduğu için struct olarak alabiliriz.
     */
    internal struct IpInfo
    {
        public byte Part1;
        public byte Part2;
        public byte Part3;
        public byte Part4;
    }
}
