using BTLWebTinTuc_Nhom3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            // khong phai load lai trang
            if (!IsPostBack) {
                //string stringSql = string.Format(@"Select * From tblChuDe");
                //DataTable dt = XuLy.Xuly_Select(stringSql);
                DataTable dt = XuLy.getDL("spChuDe_get");
                rpChuDe.DataSource = dt;
                rpChuDe.DataBind();
            }


        }
    }
}