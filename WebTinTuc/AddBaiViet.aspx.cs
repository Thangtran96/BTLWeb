using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class AddBaiViet : System.Web.UI.Page
    {
        XuLyAddBV dt = new XuLyAddBV();
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
            drlChuDe.DataSource = dt.GetAllTableChuDe();
            drlChuDe.DataBind();
        }

        protected void btInsert_Click(object sender, EventArgs e)
        {
            dt.InsertBaiViet(txtTieuDe.Text, txtNoidung.Text);
            Response.Redirect("index.aspx");
        }
    }
}