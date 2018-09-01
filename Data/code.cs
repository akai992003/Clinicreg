using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;


namespace Clinicreg.Data {
    public class code {
        // 代碼檔
        public int counter { get; set; }
        public string codename { get; set; } //代碼名稱
        public int ccode { get; set; } //代碼
        public string codeconrent { get; set; } //代碼內容



        //  取得科別代碼與代碼內容
        //  取得班別代碼與代碼內容
        //  取得診別代碼與代碼內容
        public static List<code> getcin (string codename) {
            string str = string.Format ("exec SP_code '{0}'", codename);
            // var _connectionStr = "server=61.216.24.135,1401;Database=country;user id=sa;password=;MultipleActiveResultSets=True;Application Name=Clinicreg";
            using (var cn = new SqlConnection (tool.conn)) {
                var q = cn.Query<code> (str).AsList ();
                return q;
            }

        }

        //  與醫師關聯，若有醫師才顯示科別名稱
        public static List<code> getdoctorcin () {
            string str = string.Format ("exec SP_Doctorcode");
            // var _connectionStr = "server=61.216.24.135,1401;Database=country;user id=sa;password=;MultipleActiveResultSets=True;Application Name=Clinicreg";
            using (var cn = new SqlConnection (tool.conn)) {
                var q = cn.Query<code> (str).AsList ();
                return q;
            }

        }
    }
}