﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTinTuc
{
    public partial class index : System.Web.UI.Page
    {
        XuLyAddBV Xuly = new XuLyAddBV();
        protected void Page_Load(object sender, EventArgs e)
        {
            rpChiTiet.DataSource = Xuly.GetTableProc("spGetAllBVDaDuyet");
            rpChiTiet.DataBind();
        }
    }
}