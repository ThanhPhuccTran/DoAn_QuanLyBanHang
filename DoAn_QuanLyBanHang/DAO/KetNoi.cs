using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyBanHang.DAO
{
    public class KetNoi
    {
        //B1 khai báo chuỗi kết nối
       public string ConnectionString = "Data Source =DESKTOP-10KQE7D\\THANHPHUC;Initial Catalog = QL_BanHang_DienTu;User ID = sa ; Password = 123";
        public SqlConnection sqlConn = null;     
       public void MoKetNoi()
        {
            sqlConn = new SqlConnection(ConnectionString);
            if(sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }

        }

       public DataTable ReadData (string sqlSelect)
        {
            DataTable dt = new DataTable();
            MoKetNoi();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dt);
            DongKetNoi();
            sqlData.Dispose();
            return dt;
        }

        public void ChangeData(string sql)
        {
            MoKetNoi();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            DongKetNoi();
            sqlComm.Dispose();
        }


        public void DongKetNoi()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }


    }
}
