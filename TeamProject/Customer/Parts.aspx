<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Parts.aspx.cs" Inherits="TeamProject.Customer.Parts" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
        <img alt="" src="../Photos/Parts.png" style="width: 100%; height: 720px" />
    </div>

    <h1><strong>DANH SÁCH SẢN PHẨM</strong></h1>

    <div class="content">

        <asp:DataList ID="DataList1" runat="server" CellPadding="50" CellSpacing="50" RepeatColumns="3">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" Height="277px" Width="372px" />
                <br />
                <div style="background-color: #FFECFF">
                    <asp:Label ID="lbl_TenSanPham" runat="server" Style="font-size: x-large"></asp:Label>
                    <br />
                    Giá sản phẩm:
                <asp:Label ID="lbl_GiaSanPham" runat="server" Style="font-size: medium"></asp:Label>
                    &nbsp;đồng
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
