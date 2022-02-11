using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class kullaniciSQL
    {
        public string GirisYap()
        {
            return "select count (*) as Sayi from kullanici where kullaniciadi=@kullaniciadi and sifre=@sifre";
        }
        public string ekle()
        {
            return "insert into skor(inekSayisi, sutSayisi, skorPuani, kullaniciadi) values(@inekSayisi,@sutSayisi,@skorPuani,@kullaniciadi)";
        }
        public string guncelle()
        {
            return "update skor set inekSayisi=@inekSayisi, sutSayisi=@sutSayisi, skorPuani=@skorPuani where kullaniciadi=@kullaniciadi";
        }
    }
}
