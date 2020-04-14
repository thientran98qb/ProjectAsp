<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" EnableEventValidation="false"  AutoEventWireup="true" CodeBehind="QLTheLoai.aspx.cs" Inherits="TeamProject.Admin.QLTheLoai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form  method="post" runat="server" enctype="multipart/form-data" class="align-content-sm-between">     
            <asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label>
            <asp:HiddenField ID="hdfID" runat="server" />
            <div class="row">
                <div class="col-9">                                               
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title"></h3>
                        </div>
                        
                        <div class="card-body">
                            
                            <div class="form-group">
                                <label>ID THỂ LOẠI</label>
                                <asp:TextBox ID="txtID" class="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>TÊN THỂ LOẠI</label>
                                <asp:TextBox ID="txtTen" class="form-control" runat="server"></asp:TextBox>
                            </div>

                            
                        </div>
                        <!-- /.card-body -->
                    </div>
                </div>
            
            </div>

            <div class="form-group">
                <asp:Button ID="btn_Them" CssClass="btn btn-primary" runat="server" Text="Thêm Thể Loại" OnClick="btn_Them_Click" />
                
                <asp:Button ID="bnt_Sua" CssClass="btn btn-secondary" runat="server" Text="Sửa Thể Loại" OnClick="bnt_Sua_Click" />
            
            
                
            
                <asp:Button ID="btn_NhapLai" CssClass="btn btn-primary" runat="server" Text="Nhập Lại" OnClick="btn_NhapLai_Click" />
            
            </div>
            <div class="form-group">
                <asp:GridView ID="GridAllStore"  runat="server" AutoGenerateColumns="False" Width="80%"  ViewStateMode="Enabled" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Chọn Sửa" >
                            <ItemTemplate>                              
                                    <asp:LinkButton ID="btnSelect" CssClass="btn btn-primary" runat="server" OnClick="btnSelect_Click" Text="Chọn Sửa"  CommandName='<% # Eval("ID_THE_LOAI") %>' />                        
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="ID Thể loại" DataField="ID_THE_LOAI" >
                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Tên Thể Loại" DataField="TEN_THE_LOAI" >
                        <ItemStyle VerticalAlign="Middle" CssClass="text-center" HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Xóa">
                             <ItemTemplate>                                
                              <asp:Button ID="btnDelete" CssClass="btn btn-danger"  runat="server"   OnClick="btnDelete_Click" Text="Xóa" CommandName='<% # Eval("ID_THE_LOAI") %>' />                  
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
                <</div>
       </form>
    
</asp:Content>
