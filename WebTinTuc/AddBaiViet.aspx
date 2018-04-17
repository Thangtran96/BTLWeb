<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddBaiViet.aspx.cs" Inherits="WebTinTuc.AddBaiViet" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thêm bản tin mới cho Website</h1>
    <div id="noidungContent">
        <h4>Chọn chủ đề</h4>
        <asp:DropDownList ID="drlChuDe" runat="server" Width="100px"></asp:DropDownList>
        <h4>Tiêu đề bản tin</h4>
        <asp:TextBox ID="txtTieuDe" runat="server" Width="600px"></asp:TextBox>
        <h4>Nội dung bản tin</h4>
        <CKEditor:CKEditorControl ID="txtNoidung" runat="server" Width="620px"></CKEditor:CKEditorControl>
       <%-- <textarea name="editor1" id="editor1" rows="10" cols="80">
                This is my textarea to be replaced with CKEditor.
        </textarea>
        <script>
            // Replace the <textarea id="editor1"> with a CKEditor
            // instance, using default configuration.
            CKEDITOR.replace('editor1');
        </script> 
        --%>
        <br /><br />
        <asp:Button ID="btInsert" runat="server" Text="Cập Nhật" Height="30px" Width="150px" OnClick="btInsert_Click" /> <br /><br />
        <asp:Button ID="btCancel" runat="server" Text="Hủy" OnClick="btCancel_Click"  />
    </div>
</asp:Content>
