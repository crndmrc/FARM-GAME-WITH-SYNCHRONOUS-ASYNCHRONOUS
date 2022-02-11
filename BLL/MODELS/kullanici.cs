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
    public class kullanici
    {
        //properties 
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        //actions 
        public string GirisYap()
        {
            kullaniciSQL _kullaniciSQL = new kullaniciSQL();
            Execute _execute = new Execute();
            string _hataMesaji = "";
            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@kullaniciadi", kullaniciadi));
            _params.Add(new SqlParameter("@sifre",sifre));

            DataTable sonuc = _execute.executeDT(_kullaniciSQL.GirisYap(),_params.ToArray(),false,ref _hataMesaji);       
            return sonuc.Rows[0]["Sayi"].ToString();
        }
    }
}
