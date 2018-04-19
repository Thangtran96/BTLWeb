using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebTinTuc
{
    public class XuLyAddBV
    {
        private string ConnectString = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
        public SqlConnection GetConnect()
        {
            return new SqlConnection(ConnectString);
        }
        //hàm trả về 1 datatable
        public DataTable GetTable(string sql)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        //hàm thực thi lệnh executenonquery
        public void ExeCuteNonquery(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        //Hàm thực thi lệnh store proc
        //Hàm thực thi lệnh ExecuteScalar để trả về 1 giá trị
        public string ExecuteScalar(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            string kq = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataTable GetAllTableChuDe()
        {
            using (SqlConnection con = GetConnect() )
            {
                SqlCommand cmd = new SqlCommand("spChuDe_get", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void InsertBaiViet(int idBV,string sTieude, string sNoiDung)
        {
            using(SqlConnection con = GetConnect())
            {
                using (SqlCommand cmd = new SqlCommand("spInsertBaiViet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@idBV";
                    parameter.Value = idBV;
                    cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@sTieude", sTieude);
                    cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter("@sNoiDung", sNoiDung);
                    cmd.Parameters.Add(parameter);

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetTacGiaOfBV(int idBV)
        {
            using (SqlConnection con = GetConnect())
            {
                SqlCommand cmd = new SqlCommand("spGetTacGiaOfBV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBV", idBV);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
                return dt;
            }
        }

        //using proc
        public DataTable GetTableProc(string proc)
        {
            using (SqlConnection con = GetConnect())
            {
                SqlCommand cmd = new SqlCommand(proc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
                return dt;
            }
        }

       
        public DataTable GetBaiVietByID(int idBV)
        {
            using (SqlConnection con = GetConnect())
            {
                SqlCommand cmd = new SqlCommand("spGetNoiDungByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBV", idBV);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable GetBaiVietTheoChuDe(int idChuDe)
        {
            using (SqlConnection con = GetConnect())
            {
                SqlCommand cmd = new SqlCommand("spGetBVTheoChuDe", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idChuDe", idChuDe);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void DelBaiViet(int idBV)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand("spDelBV", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idBV", idBV);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        public void DuyetBV(int idBV, int idTV)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand("spBaiDuyet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idBV", idBV);
            cmd.Parameters.AddWithValue("@idTV", idTV);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

    }
}