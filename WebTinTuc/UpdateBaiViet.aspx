<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="UpdateBaiViet.aspx.cs" Inherits="WebTinTuc.UpdateBaiViet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sua bản tin cho Website</h1>
    <div id="noidungContent">
        <h4>Chọn chủ đề</h4>
        <asp:DropDownList ID="drlChuDe" runat="server" Width="100px"></asp:DropDownList>
        <h4>Tiêu đề bản tin</h4>
        <asp:TextBox ID="txtTieuDe" runat="server" Width="600px"></asp:TextBox>
        <h4>Nội dung bản tin</h4>
        <CKEditor:CKEditorControl ID="txtNoidung" runat="server" Width="620px"></CKEditor:CKEditorControl>
 
        <br /><br />
        <asp:Button ID="btInsert" runat="server" Text="Cập Nhật" Height="30px" Width="150px" OnClick="btInsert_Click" /> <br /><br />
        <asp:Button ID="btCancel" runat="server" Text="Hủy" OnClick="btCancel_Click"  />
    </div>
</asp:Content>
