using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class UpdateBaiViet : System.Web.UI.Page
    {
        XuLyAddBV xlbv = new XuLyAddBV();
        protected void Page_Load(object sender, EventArgs e)
        {
            //hien chu de
            DataTable dt = new DataTable();
            //int idChuDe = int.Parse(Request["idChuDe"]);
            //drlChuDe.DataTextField = "sTenChuDe";
            //drlChuDe.DataValueField = "idChuDe";
            //dt = xlbv.GetAllTableChuDe();
            //drlChuDe.DataSource = dt;
            //drlChuDe.DataBind();
            //int tableCount = dt.Rows.Count;
            //for(int i=0; i < tableCount; ++i)
            //{
            //    if (int.Parse(drlChuDe.Items[i].Value.ToString() ) == idChuDe )
            //    {
            //        drlChuDe.SelectedIndex = i; break;
            //    }
            //}
            //hien tieu de noi dung
            dt = new DataTable();
            int idBV = int.Parse(Request["idBaiViet"]);
            dt = xlbv.GetBaiVietByID(idBV);
            rpChiTiet.DataSource = dt;
            rpChiTiet.DataBind();

            //nut duyet
            string sql = "SELECT COUNT(dbo.tblBaiDang.idBaiViet) FROM dbo.tblBaiDang WHERE idBaiViet = " + idBV;
            int res = int.Parse( xlbv.ExecuteScalar(sql) );
            if (res == 0)
            {
                btDuyet.Enabled = true;
            }
            else btDuyet.Enabled = false;
        }

        protected void btDuyetBV_Click(object sender, EventArgs e)
        {
            int idBV = int.Parse(Request["idBaiViet"]);
            int idTV = (int)Session["idTV"];
            xlbv.DuyetBV(idBV, idTV);
            Response.Redirect("index.aspx");
        }

        protected void btXoaBV_Click(object sender, EventArgs e)
        {
            int idBV = int.Parse(Request["idBaiViet"]);
            xlbv.DelBaiViet(idBV);
            Response.Redirect("UpdateDelBV.aspx");
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateDelBV.aspx");
        }
    }
}