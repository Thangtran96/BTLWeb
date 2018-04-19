using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class UpdateDelBV : System.Web.UI.Page
    {
        XuLyAddBV Xuly = new XuLyAddBV();
        protected void Page_Load(object sender, EventArgs e)
        {
            //int idTV = int.Parse(Request["idTV"]);
            //Session["idTV"] = idTV;
            string sql = "SELECT * FROM dbo.tblBaiViet WHERE idBaiViet NOT IN (SELECT idBaiViet FROM view_BViet_Duyet)";
            rpChiTiet.DataSource = Xuly.GetTable(sql);
            rpChiTiet.DataBind();
        }
    }
}