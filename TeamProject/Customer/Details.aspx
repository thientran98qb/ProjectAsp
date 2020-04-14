<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="TeamProject.Customer.Details" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
        <asp:Image ID="Image1" runat="server" Width="100%" Height="720px" />
    </div>

    <div class="text-left">
        <asp:DetailsView ID="DetailsView1" runat="server" Height="100%" Width="100%">
            <FooterTemplate>
                <asp:DataList ID="DataList1" runat="server" CellPadding="50" CellSpacing="50" RepeatColumns="3">
                    <ItemTemplate>
                        <asp:Image ID="Image2" runat="server" Height="317px" Width="360px" />
                    </ItemTemplate>
                </asp:DataList>
                <h1>
                    <asp:Label ID="lbl_TenSanPham" runat="server"></asp:Label>
                </h1>
                <h2>
                    <asp:Label ID="lbl_GiaBan" runat="server"></asp:Label>
                    &nbsp;đồng</h2>
                <p>
                    <asp:Label ID="lbl_ThongSo" runat="server" style="font-size: large"></asp:Label>
                </p>
            </FooterTemplate>
        </asp:DetailsView>
    </div>
</asp:Content>
