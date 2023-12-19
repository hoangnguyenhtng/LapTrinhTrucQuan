using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseDemo
{
    internal class ProcessDatabase
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LapTrinhTrucQuan\\DatabaseDemo\\DatabaseDemo\\QLHangHoa.mdf;Integrated Security=True");
        public void ketnoi()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void dongketnoi()
        {
            if(con.State != ConnectionState.Closed)
            {
                con.Close();
                con.Dispose();
            }
        }
        
        public DataTable DocBang(string sql)
        {
            ketnoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(tb);
            dongketnoi();
            return tb;
        }

        public void capnhat(string sql) { 
            SqlCommand cmd = new SqlCommand(sql);
            ketnoi();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dongketnoi();
        }
    }
    
}
