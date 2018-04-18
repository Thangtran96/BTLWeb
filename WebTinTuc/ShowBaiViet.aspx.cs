using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class ShowBaiViet : System.Web.UI.Page
    {
        XuLyAddBV dt = new XuLyAddBV();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idBaiViet = int.Parse(Request["idBaiViet"]);
            rpTieuDe.DataSource = dt.GetBaiVietByID(idBaiViet);
            rpTieuDe.DataBind();
            rpChiTiet.DataSource = dt.GetBaiVietByID(idBaiViet);
            rpChiTiet.DataBind();
        }
    }
}