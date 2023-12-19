using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlSinhVien
{
    internal class ProcessDatabase
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\QlSinhVien\\QlSinhVien.mdf;Integrated Security=True");

        public void Ketnoi()
        {
            if (con.State != ConnectionState.Open) con.Open();
        }

        public void Dongketnoi()
        {
            if (con.State != ConnectionState.Closed) con.Close();
            con.Dispose();
        }

        public DataTable Docbang(string sql)
        {
            Ketnoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(tb);
            Dongketnoi();
            return tb;
        }

        public void Capnhat(string sql)
        {
            SqlCommand cm = new SqlCommand();
            Ketnoi();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            Dongketnoi();
        }
    }
}
