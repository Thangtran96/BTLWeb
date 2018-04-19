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
    public partial class dangky : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            XuLy.dangkyTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, txtHovaTen.Text, txtEmail.Text, txtSDT.Text);
            Response.Redirect("index.aspx");
        }
    }
}