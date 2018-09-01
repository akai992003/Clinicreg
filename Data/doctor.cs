using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Clinicreg.Data {
    public class doctor {
        public int counter { get; set; }
        public string name { get; set; } //醫師姓名
        public int cincode { get; set; } //科別代碼
        // 人事資料檔裡的醫生
        // todo 取得醫師資料
        public static List<doctor> getdoctor () {
            string str = string.Format ("exec SP_doctor");
            // var _connectionStr = "server=61.216.24.135,1401;Database=country;user id=sa;password=;MultipleActiveResultSets=True;Application Name=Clinicreg";
            using (var cn = new SqlConnection (tool.conn)) {
                var q = cn.Query<doctor> (str).AsList ();
                return q;
            }

        }
    }
}