using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace TeamProject.Admin
{
    public partial class QLSP : System.Web.UI.Page
    {
        XLDL xl = new XLDL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadddl();
                loadSP();
            }        
        }
        public void loadddl()
        {
            ddl.DataSource = xl.docDLDataTable("SELECT * FROM THE_LOAI");
            ddl.DataBind();
            ddlIDCTSP.DataSource = xl.docDLDataTable("SELECT * FROM CT_SANPHAM");
            ddlIDCTSP.DataBind();
        }
        public void loadSP()
        {
            GridAllStore.DataSource = xl.docDLDataTable("SELECT * FROM SAN_PHAM");
            GridAllStore.DataBind();
        }
        protected void btn_Them_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
                {
                    txtTenSP.Text,
                    txtGiaBan.Text,
                    txtGhiChu.Text,
                    ddl.SelectedValue,
                    txtGiaSell.Text,
                    txtHinhAnh.Text,
                    ddlIDCTSP.SelectedValue
                };
            string[] pars = new string[]
             {
                     "@TenSP",
                     "@GiaBan",
                     "@GhiChu",
                     "@ID_TL",
                     "@GiaSell",
                     "@HinhAnh",
                     "@ID_CT_SP"
             };
            try
            {
                xl.capNhatDuLieuStored("insertSP", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadSP();
                Reset();


            }
            catch (SqlException)
            {
                lblThongBao.Text = "Thêm mới thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void bnt_Sua_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
          {
               hdfID.Value,
               txtTenSP.Text,
               txtGiaBan.Text,
               txtGhiChu.Text,
               ddl.SelectedValue,
               txtGiaSell.Text,
               txtHinhAnh.Text,
                ddlIDCTSP.SelectedValue
          };
            string[] pars = new string[]
            {
                "@ID",
                 "@TenSP",
                 "@GiaBan",
                 "@GhiChu",
                  "@ID_TL",
                  "@GiaSell",
                  "@HinhAnh",
                  "@ID_CT_SP"

            };
            try
            {

                if (xl.capNhatDuLieuStored("updateSP", vals, pars) > 0)
                {
                    lblThongBao.Text = "Update thành công";
                    lblThongBao.ForeColor = System.Drawing.Color.Blue;
                    loadSP();
                    Reset();
                }

            }
            catch (SqlException)
            {
                lblThongBao.Text = "Update thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtHinhAnh.Text = null;
            txtTenSP.Text = null;
            txtGiaSell.Text = null;
            txtGiaBan.Text = null;
            txtGhiChu.Text = null;
        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            string[] vals = new string[]
            {
                bt.CommandName
            };
            string[] pars = new string[]
            {
                "@ID_SAN_PHAM"
            };
            DataTable dt = xl.docDLDataTableStored("selecttSP", vals, pars);
            if (dt.Rows.Count > 0)
            {
                hdfID.Value = dt.Rows[0]["ID_SAN_PHAM"] + "";
                txtTenSP.Text = dt.Rows[0]["TEN_SAN_PHAM"] + "";
                txtGiaBan.Text = dt.Rows[0]["GIA_BAN"] + "";
                ddl.SelectedValue = dt.Rows[0]["ID_THE_LOAI"] + "";
                txtGhiChu.Text = dt.Rows[0]["GHI_CHU"] + "";
                txtGiaSell.Text = dt.Rows[0]["GIA_SELL"] + "";
                txtHinhAnh.Text = dt.Rows[0]["HINH_ANH"] + "";
                ddlIDCTSP.SelectedValue = dt.Rows[0]["ID_CT_SP"] + "";
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string[] vals = new string[]
            {
                bt.CommandName
            };
            string[] pars = new string[]
            {
                "@ID_SAN_PHAM"
            };
            try
            {
                xl.capNhatDuLieuStored("deleteSP", vals, pars);
                lblThongBao.Text = "Xóa thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadSP();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Xóa thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void Reset()
        {
            txtHinhAnh.Text = null;
            txtTenSP.Text = null;
            txtGiaSell.Text = null;
            txtGiaBan.Text = null;
            txtGhiChu.Text = null;

        }
    }
}