<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="QLTaiKhoan.aspx.cs" Inherits="TeamProject.Admin.QLTaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  method="post" runat="server" enctype="multipart/form-data" class="align-content-sm-between">     
            <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
            <asp:HiddenField ID="hdfID" runat="server" />
            <div class="row">
                <div class="col-9">                                               
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title"></h3>
                        </div>                        
                        <div class="card-body">                            
                            <div class="form-group">
                                <label>TÊN ĐĂNG NHẬP</label>
                                <asp:TextBox ID="txtTenDN" class="form-control" runat="server"></asp:TextBox>
                            </div>       
                            <div class="form-group">
                                <label>MẬT KHẨU</label>
                                <asp:TextBox ID="txtMK" class="form-control" runat="server"></asp:TextBox>
                            </div>   
                            <div class="form-group">
                                <label>HỌ TÊN</label>
                                <asp:TextBox ID="txtHoTen" Multiline="true" class="form-control" runat="server"></asp:TextBox>
                            </div> 
                             <div class="form-group">
                                <label>KHÓA TK</label>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </div>   
                            <div class="form-group">
                                <label>ID QUYỀN</label>
                                <asp:DropDownList ID="ddlQuyen" runat="server" DataTextField="TEN_QUYEN" DataValueField="ID_QUYEN"></asp:DropDownList>
                            </div>                                                        
                        </div>
                        <!-- /.card-body -->
                    </div>
                </div>            
            </div>
            <div class="form-group">
                <asp:Button ID="btn_Them" CssClass="btn btn-primary" runat="server" Text="Thêm" OnClick="btn_Them_Click" />                
                <asp:Button ID="bnt_Sua" CssClass="btn btn-success" runat="server" Text="Sửa" OnClick="bnt_Sua_Click" />        
                <asp:Button ID="btn_NhapLai" CssClass="btn btn-secondary" runat="server" Text="Nhập Lại" OnClick="btn_NhapLai_Click" />            
            </div>
            <div class="form-group">
                <asp:GridView ID="GridAllStore"  runat="server" AutoGenerateColumns="False" Width="80%"  ViewStateMode="Enabled" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Chọn Sửa" >
                            <ItemTemplate>                              
                                    <asp:LinkButton ID="btnSelect" CssClass="btn btn-primary" runat="server" OnClick="btnSelect_Click" Text="Chọn Sửa"  CommandName='<% # Eval("ID_TAI_KHOAN") %>' />                        
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="TEN_DANG_NHAP" HeaderText="TÊN ĐĂNG NHẬP" />
                        <asp:BoundField DataField="MAT_KHAU" HeaderText="MẬT KHẨU" />
                        <asp:BoundField DataField="HO_TEN" HeaderText="HỌ TÊN" />
                        <asp:BoundField DataField="KHOA_TK" HeaderText="KHÓA TK" />
                        <asp:BoundField DataField="ID_QUYEN" HeaderText="ID QUYỀN" />
                      
                        <asp:TemplateField HeaderText="Xóa">
                             <ItemTemplate>                                
                              <asp:Button ID="btnDelete" CssClass="btn btn-danger"  runat="server"   OnClick="btnDelete_Click" Text="Xóa" CommandName='<% # Eval("ID_TAI_KHOAN") %>' />                  
                            </ItemTemplate>
                             <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                    
                </asp:GridView>
                </div>
       </form>   
</asp:Content>
