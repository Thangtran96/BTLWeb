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
            int idChuDe = int.Parse(Request["idChuDe"]);
            drlChuDe.DataTextField = "sTenChuDe";
            drlChuDe.DataValueField = "idChuDe";
            DataTable dt = xlbv.GetAllTableChuDe();
            drlChuDe.DataSource = dt;
            drlChuDe.DataBind();
            int tableCount = dt.Rows.Count;
            for(int i=0; i < tableCount; ++i)
            {
                if (int.Parse(drlChuDe.Items[i].Value.ToString() ) == idChuDe )
                {
                    drlChuDe.SelectedIndex = i; break;
                }
            }
        }
    }
}