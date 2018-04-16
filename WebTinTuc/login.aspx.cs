using BTLWebTinTuc_Nhom3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = XuLy.getTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);
            int kq = dt.Rows.Count;
            if (kq > 0){
                Session["admin"] = true;
                Response.Redirect("index.aspx");
            }
            else {
                lblThongBao.Text = "Đăng nhập thất bại";
            }
        }
    }
}