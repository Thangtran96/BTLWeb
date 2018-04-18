using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class AddBaiViet : System.Web.UI.Page
    {
        XuLyAddBV xlbv = new XuLyAddBV();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataDrBanTin();
            }
        }

        public void LoadDataDrBanTin()
        {
            drlChuDe.DataTextField = "sTenChuDe";
            drlChuDe.DataValueField = "idChuDe";
            drlChuDe.DataSource = xlbv.GetAllTableChuDe();
            drlChuDe.DataBind();            
        }

        

        protected void btInsert_Click(object sender, EventArgs e)
        {
            int idBV = int.Parse(xlbv.ExecuteScalar("SELECT COUNT(idBaiViet) FROM tblBaiViet")) + 1;
            Session["idBV"] = idBV;
            xlbv.InsertBaiViet(idBV, txtTieuDe.Text, txtNoidung.Text);
            Response.Redirect("AddTacGia.aspx");
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

    }
}