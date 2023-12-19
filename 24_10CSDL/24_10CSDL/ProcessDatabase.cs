using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _24_10CSDL
{
    internal class ProcessDatabase
    {
        string stringcon;
        SqlConnection con;
        public void KetNoi()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\LapTrinhTrucQuan\24_10CSDL\24_10CSDL\Database.mdf; Integrated Security = True");
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            
        }
        public void DongKetNoi() {
            if(con.State != ConnectionState.Closed) {
                con.Close();
            }
            con.Dispose();
        }

        public DataTable DocBang(string sql)
        {
            DataTable dt = new DataTable();
            KetNoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con) ;
            adap.Fill(dt);
            DongKetNoi();
            return dt;
        }

        public void CapNhat(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            KetNoi();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
