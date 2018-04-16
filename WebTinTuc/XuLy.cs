using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BTLWebTinTuc_Nhom3
{
    public class XuLy
    {
        //static string connectionString = ConfigurationManager.ConnectionStrings["WebTinTuc"].ConnectionString;

        public XuLy()
        {
        }

        public static string connectTG()
        {
            return WebConfigurationManager.ConnectionStrings["WebTinTuc"].ConnectionString;
        }

        public static DataTable Xuly_Select(string sql)
        {
            string connect = connectTG();
            SqlConnection con = new SqlConnection(connect);
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public static bool XuLyTruyVan(string sql)
        {
            try
            {
                string connect = connectTG();
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable getDL(string _storedprocedure)
        {
            string connect = connectTG();
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand(_storedprocedure, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }//da
                }//cmd
            }//cnn
        }


        public static DataTable getTaiKhoan(string tk, string mk)
        {
            string connect = connectTG();
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("spTaiKhoan_get", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }//da
                }//cmd
            }//cnn
        }

        /*
        static public void getTaiKhoan(string tk, string mk)
        {
            string connect = connectTG();
            using (SqlConnection cnn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("spTaiKhoan_get", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tk", tk);
                    cmd.Parameters.AddWithValue("@mk", mk);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }//cmd
            }//cnn
        }
        */






    }


}