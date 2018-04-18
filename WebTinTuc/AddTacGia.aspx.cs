using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class AddTacGia : System.Web.UI.Page
    {
        XuLyAddBV xlbv = new XuLyAddBV();
        //private DataTable dtTacgia = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            //dtTacgia.Columns.Add("idTV", typeof(int));
            //dtTacgia.Columns.Add("sTenTV", typeof(string));
            if (!IsPostBack)
            {
                ddlTacGia.DataTextField = "sTenTV";
                ddlTacGia.DataValueField = "idTV";
                ddlTacGia.DataSource = xlbv.GetTableProc("spGetAllTacGia");
                ddlTacGia.DataBind();
            }
        }

        public void dgrvTacGiaLoad(DataTable dtTacgia)
        {
            gvTacGia.DataSource = dtTacgia;
            gvTacGia.DataBind();

            int idBV = (int)Session["idBV"];
            string sql = "SELECT COUNT(dbo.tblTacGiaBaiViet.idTacGia) FROM dbo.tblTacGiaBaiViet WHERE idBaiViet = " + idBV;
            int countTG = int.Parse(xlbv.ExecuteScalar(sql));
            if (countTG > 0)
            {
                btDone.Enabled = true;
            }
            else
            {
                btDone.Enabled = false;
            }
        }


        protected void btAddTG_Click(object sender, EventArgs e)
        {
            int idBV = (int)Session["idBV"];
            int idTV = int.Parse(ddlTacGia.SelectedValue.ToString());
            string sql = "SELECT COUNT(dbo.tblTacGiaBaiViet.idTacGia) FROM dbo.tblTacGiaBaiViet WHERE idBaiViet = " + idBV + " AND idTacGia = " + idTV;
            int countTG = int.Parse(xlbv.ExecuteScalar(sql));
            if (countTG == 0)
            {
                string sqlInset = "INSERT INTO dbo.tblTacGiaBaiViet(idBaiViet, idTacGia) VALUES(" + idBV + "," + idTV + ")";
                xlbv.ExeCuteNonquery(sqlInset);
                DataTable dt = xlbv.GetTacGiaOfBV(idBV);
                dgrvTacGiaLoad(dt);
            }                    
            //DataTable temp = xlbv.GetTableProc("spGetAllTacGia");
            //string expression = "idTV = " + idTV;
            //DataRow[] results;
            //results = temp.Select(expression);
            //for (int i = 0; i < results.Length; ++i)
            //{
            //    DataRow drAddgv = dtTacgia.NewRow();
            //    drAddgv["idTV"] = results[i][0];
            //    drAddgv["sTenTV"] = results[i][1];
            //    dtTacgia.Rows.Add(drAddgv);
            //}
            //dgrvTacGiaLoad(dtTacgia);
        }

        protected void btDelTG_Click(object sender, EventArgs e)
        {
            int idBV = (int)Session["idBV"];
            int idTV = int.Parse(ddlTacGia.SelectedValue.ToString());
            string sql = "SELECT COUNT(dbo.tblTacGiaBaiViet.idTacGia) FROM dbo.tblTacGiaBaiViet WHERE idBaiViet = " + idBV + " AND idTacGia = " + idTV;
            int countTG = int.Parse(xlbv.ExecuteScalar(sql));
            if (countTG == 1)
            {
                string sqlDel = "DELETE FROM dbo.tblTacGiaBaiViet WHERE idBaiViet = " + idBV + " AND idTacGia = " + idTV;
                xlbv.ExeCuteNonquery(sqlDel);
                DataTable dt = xlbv.GetTacGiaOfBV(idBV);
                dgrvTacGiaLoad(dt);
            }            
        }

        protected void btDone_Click(object sender, EventArgs e)
        {
            Session["idBV"] = 0;
            Response.Redirect("index.aspx");
        }
    }
}