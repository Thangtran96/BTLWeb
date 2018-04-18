<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ShowBaiViet.aspx.cs" Inherits="WebTinTuc.ShowBaiViet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rpTieuDe" runat="server">
        <ItemTemplate>
            <h1><%# Eval("sTieuDe") %></h1>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
