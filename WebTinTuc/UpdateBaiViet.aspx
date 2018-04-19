<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="UpdateBaiViet.aspx.cs" Inherits="WebTinTuc.UpdateBaiViet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Duyet bản tin cho Website</h1>
    <div id="noidungContent">
        <asp:Repeater ID="rpChiTiet" runat="server">
            <ItemTemplate>
                <h3 style="color:red"><%#Eval("sTieude") %></h3>
                <p style="text-align:right;">
                    Cap nhat : <%# Eval("dNgayViet") %>
                </p>
                <%# Eval("sNoiDung") %>
            </ItemTemplate>
        </asp:Repeater>
        <br /><br /> 
        <asp:Button ID="btDuyet" runat="server" Text="Dang bai" OnClick="btDuyetBV_Click" />
        <asp:Button ID="btDel" runat="server" Text="Xoa bai Viet" OnClick="btXoaBV_Click" />
        <asp:Button ID="btHuy" runat="server" Text="Huy" OnClick="btCancel_Click" />
    </div>
</asp:Content>
