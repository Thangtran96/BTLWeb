<%@ Page Title="" Language="C#" UnobtrusiveValidationMode ="None" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="WebTinTuc.dangky" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Đăng ký thành viên</h1>
        <div id="noidungContent">
            <h4>Tên đăng nhập: </h4>
            <asp:TextBox ID="txtTenDangNhap" Width="300" Height="20" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenDangNhap" ErrorMessage="Cần nhập tên đăng nhập" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <h4>Mật khẩu: </h4>
            <asp:TextBox ID="txtMatKhau" Width="300" Height="20" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Cần nhập mật khẩu" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <h4>Nhập lại mật khẩu: </h4>
            <asp:TextBox ID="txtNhapLaiMatKhau" Width="300" Height="20" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNhapLaiMatKhau" ErrorMessage="Cần nhập lại mật khẩu" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="abc" runat="server" ControlToCompare="txtMatKhau" ErrorMessage="Không trùng với mật khẩu đã nhập" ForeColor="Red" ControlToValidate="txtNhapLaiMatKhau" Display="Dynamic"></asp:CompareValidator>
            <h4>Họ và tên: </h4>
            <asp:TextBox ID="txtHovaTen" Width="300" Height="20" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtHovaTen" ErrorMessage="Cần nhập Họ và tên" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <h4>Email: </h4>
            <asp:TextBox ID="txtEmail" Width="300" Height="20" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtEmail" ErrorMessage="Cần nhập Email" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="az" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
            <h4>Số điện thoại: </h4>
            <asp:TextBox ID="txtSDT" Width="300" Height="20" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtSDT" ErrorMessage="Cần nhập Số điện thoại" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" OnClick="btnDangKy_Click"/>
            <br />
            <br />
            <h4>
                <asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label>
            </h4>
        </div>
</asp:Content>
