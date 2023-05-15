using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaparolaOyunu
{
    static class SoruManager
    {
        public static List<Soru> Sorular { get; set; } = new List<Soru>();

        static SoruManager()
        {
            Soru s1 = new Soru("Ülkemizin güney kısmındaki kıyı bölgesi?", new List<string> { "akdeniz" });
            Soru s2 = new Soru("Yeşilliği ile ünlü marmara ilimiz?", new List<string> { "bursa" });
            Soru s3 = new Soru("Müslümanların kutsal günü?", new List<string> { "cuma" });
            Soru s4 = new Soru("Karpuzuyla ünlü ilimiz?", new List<string> { "diyarbakır" });
            Soru s5 = new Soru("Yeni kelimesinin zıt anlamlısı?", new List<string> { "eski" });
            Soru s6 = new Soru("Padişahın emirlerinin yazılı hali?", new List<string> { "ferman" });
            Soru s7 = new Soru("Dünyanın ısı kaynağı?", new List<string> { "güneş" });
            Soru s8 = new Soru("Öğrencilerin kötü karne getirdiğinde bakıştığı nesne?", new List<string> { "halı" });
            Soru s9 = new Soru("Gülüyle ünlü ilimiz?", new List<string> { "ısparta" });
            Soru s10 = new Soru("Mersinin diğer ismi?", new List<string> { "içel" });
            Soru s11 = new Soru("Askeri bir topluluk?", new List<string> { "jandarma" });
            Soru s12 = new Soru("Malatyanın meşhur meyvesi?", new List<string> { "kayısı" });
            Soru s13 = new Soru("Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?", new List<string> { "lale", "lale festivali" });
            Soru s14 = new Soru("Yılın 3. ayı?", new List<string> { "mart" });
            Soru s15 = new Soru("Üflemeli bir müzük aleti?", new List<string> { "ney" });
            Soru s16 = new Soru("Halk şairi?", new List<string> { "ozan" });
            Soru s17 = new Soru("Çocukların çok sevmediği pirinç havuç gibi sebzelerle yapılan yemek?", new List<string> { "pilav" });
            Soru s18 = new Soru("11 ayın sultanı?", new List<string> { "ramazan" });
            Soru s19 = new Soru("İngilizce de yılan?", new List<string> { "snake" });
            Soru s20 = new Soru("Türkiye'nin megastarı?", new List<string> { "tarkan" });
            Soru s21 = new Soru("Ümit kelimesinin eş anlamlısı?", new List<string> { "umut" });
            Soru s22 = new Soru("Kahvaltısı ile ünlü bir ilimiz?", new List<string> { "van" });
            Soru s23 = new Soru("Şimşek kelimesinin eş anlamlısı?", new List<string> { "yıldırım" });
            Soru s24 = new Soru("Ege bölgesinin en çok ağacı bulunan yağda yapılan bir kahvaltı besini?", new List<string> { "zeytin" });

            Sorular.Add(s1);
            Sorular.Add(s2);
            Sorular.Add(s3);
            Sorular.Add(s4);
            Sorular.Add(s5);
            Sorular.Add(s6);
            Sorular.Add(s7);
            Sorular.Add(s8);
            Sorular.Add(s9);
            Sorular.Add(s10);
            Sorular.Add(s11);
            Sorular.Add(s12);
            Sorular.Add(s13);
            Sorular.Add(s14);
            Sorular.Add(s15);
            Sorular.Add(s16);
            Sorular.Add(s17);
            Sorular.Add(s18);
            Sorular.Add(s19);
            Sorular.Add(s20);
            Sorular.Add(s21);
            Sorular.Add(s22);
            Sorular.Add(s23);
            Sorular.Add(s24);

        }
    }
}
