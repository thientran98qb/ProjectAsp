<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TeamProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <img alt="" src="Photos/Default.jpg" style="width: 100%; height: 720px" />
    </div>

    <div class="content">

        <table class="nav-justified">
            <tr>
                <td style="width: 50%">
                    <a href="/Customer/Kawasaki.aspx">
                        <asp:Image ID="Image1" runat="server" ImageUrl="Photos/ContentKawasaki.jpg" Height="100%" Width="600px" />
                    </a>
                </td>
                <td>
                    <a href="/Customer/Parts.aspx">
                        <asp:Image ID="Image2" runat="server" ImageUrl="Photos/ContentParts.jpg" Height="100%" Width="575px" />
                    </a>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">
                    <a href="/Customer/Kawasaki.aspx">
                        <h1 class="text-center">Kawasaki</h1>
                    </a>
                </td>
                <td>
                    <a href="/Customer/Parts.aspx">
                        <h1 class="text-center">Parts</h1>
                    </a>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
