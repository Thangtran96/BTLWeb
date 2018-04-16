<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebTinTuc.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Đăng nhập quản trị</h1>
        <div id="noidungContent">
            <h4>Tên đăng nhập: </h4>
            <asp:TextBox ID="txtTenDangNhap" Width="300" Height="20" runat="server"></asp:TextBox>
            <h4>Mật khẩu: </h4>
            <asp:TextBox ID="txtMatKhau" Width="300" Height="20" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
            <br />
            <br />
            <h4>
                <asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label>
            </h4>
        </div>
</asp:Content>
