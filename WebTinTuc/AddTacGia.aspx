<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddTacGia.aspx.cs" Inherits="WebTinTuc.AddTacGia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="noidungContent">
        <h4>Tác giả bài viết</h4>
        <asp:DropDownList ID="ddlTacGia" runat="server"></asp:DropDownList>
        <asp:Button ID="btAddTG" runat="server" OnClick="btAddTG_Click" Text="Thêm" />
        <asp:Button ID="btDelTG" runat="server" Text="Xóa" OnClick="btDelTG_Click" />
        <br />
        <asp:GridView ID="gvTacGia" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField AccessibleHeaderText="idTV" DataField="idTV" ReadOnly="True" Visible="False" />
                <asp:BoundField AccessibleHeaderText="sTenTV" DataField="sTenTV" HeaderText="Tên Tác giả" />
            </Columns>
        </asp:GridView>
        <br /><br />
        <asp:Button ID="btDone" runat="server" Text="Hoan Thanh" Enabled="False" OnClick="btDone_Click" />
    </div>

</asp:Content>
