using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MODELS
{
    public class game
    {
        //properties
        public string kullaniciadi { get; set; }
        public int inekSayisi { get; set; }
        public int sutSayisi { get; set; }
        public int skorPuani { get; set; }
        public bool Ekle()
        {
            kullaniciSQL _kullaniciSQL = new kullaniciSQL();
            Execute _execute = new Execute();
            string _hataMesaji = "";
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@kullaniciadi",kullaniciadi));
            _params.Add(new SqlParameter("@inekSayisi", inekSayisi));
            _params.Add(new SqlParameter("@sutSayisi", sutSayisi));
            _params.Add(new SqlParameter("@skorPuani", skorPuani));

            bool sonuc = _execute.execute(_kullaniciSQL.guncelle(), _params.ToArray(), false, ref _hataMesaji);
            return sonuc;
        }
        public async Task<int> bekleAsync()
        {
            int sure = 1000;
            await Task.Run(() => System.Threading.Thread.Sleep(sure));
            return (sure / 100);
        }
        public int bekleInek()
        {
            int sure = 1000;
            System.Threading.Thread.Sleep(sure);
            return (sure / 200);
        }
        public int bekleSut()
        {
            int sure = 1000;
            System.Threading.Thread.Sleep(sure);
            return (sure / 100);
        }

    }
}
