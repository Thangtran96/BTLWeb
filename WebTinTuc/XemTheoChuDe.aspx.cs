using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class XemTheoChuDe : System.Web.UI.Page
    {
        XuLyAddBV xl = new XuLyAddBV();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idChuDe = int.Parse(Request["idChuDe"]); ;
            rpChiTiet.DataSource = xl.GetBaiVietTheoChuDe(idChuDe);
            rpChiTiet.DataBind();
        }
    }
}