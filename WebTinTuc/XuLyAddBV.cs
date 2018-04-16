﻿using System;
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
    }
}