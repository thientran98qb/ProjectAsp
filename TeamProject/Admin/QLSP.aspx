<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="QLSP.aspx.cs" Inherits="TeamProject.Admin.QLSP" %>
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
                                <label>TÊN SẢN PHẨM</label>
                                <asp:TextBox ID="txtTenSP" class="form-control" runat="server"></asp:TextBox>
                            </div>       
                            <div class="form-group">
                                <label>GIÁ BÁN</label>
                                <asp:TextBox ID="txtGiaBan" class="form-control" runat="server"></asp:TextBox>
                            </div>   
                            <div class="form-group">
                                <label>GHI CHÚ</label>
                                <asp:TextBox ID="txtGhiChu" Multiline="true" class="form-control" runat="server"></asp:TextBox>
                            </div> 
                            <div class="form-group">
                                <label>TÊN THỂ LOẠI</label>
                                <asp:DropDownList ID="ddl" runat="server" DataTextField="TEN_THE_LOAI" DataValueField="ID_THE_LOAI"></asp:DropDownList>
                            </div>   
                            <div class="form-group">
                                <label>GIÁ SELL</label>
                                <asp:TextBox ID="txtGiaSell" class="form-control" runat="server"></asp:TextBox>
                            </div>   
                            <div class="form-group">
                                <label>HÌNH ẢNH</label>
                                <asp:TextBox ID="txtHinhAnh" class="form-control" runat="server"></asp:TextBox>
                            </div>   
                              <div class="form-group">
                                <label>Tên Chi Tiết Sản Phẩm</label>
                                <asp:DropDownList ID="ddlIDCTSP" runat="server" DataTextField="TEN_CT_SP" DataValueField="ID_CT_SP"></asp:DropDownList>
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
                                    <asp:LinkButton ID="btnSelect" CssClass="btn btn-primary" runat="server" OnClick="btnSelect_Click" Text="Chọn Sửa"  CommandName='<% # Eval("ID_SAN_PHAM") %>' />                        
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="TEN_SAN_PHAM" HeaderText="TÊN SẢN PHẨM" />
                        <asp:BoundField DataField="GIA_BAN" HeaderText="GIÁ BÁN" />
                        <asp:BoundField DataField="ID_THE_LOAI" HeaderText="THỂ LOẠI" />
                        <asp:BoundField DataField="GIA_SELL" HeaderText="GIÁ SELL" />
                        <asp:BoundField DataField="HINH_ANH" HeaderText="HÌNH ẢNH" />
                        <asp:BoundField DataField="GHI_CHU" HeaderText="GHI CHÚ" />
                        <asp:BoundField DataField="ID_CT_SP" HeaderText="ID_CT_SP" />
                        <asp:TemplateField HeaderText="Xóa">
                             <ItemTemplate>                                
                              <asp:Button ID="btnDelete" CssClass="btn btn-danger"  runat="server"   OnClick="btnDelete_Click" Text="Xóa" CommandName='<% # Eval("ID_SAN_PHAM") %>' />                  
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
