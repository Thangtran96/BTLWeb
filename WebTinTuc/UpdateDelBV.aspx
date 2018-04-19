<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="UpdateDelBV.aspx.cs" Inherits="WebTinTuc.UpdateDelBV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sua va xoa bai viet</h1>
    <div id="noidungContent">
        <asp:Repeater ID="rpChiTiet" runat="server">
            <ItemTemplate>
                <ul>
                    <li>
                        <a href="UpdateBaiViet.aspx?idBaiViet=<%# Eval("idBaiViet") %>" >  <%#Eval("sTieude") %> </a>
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
