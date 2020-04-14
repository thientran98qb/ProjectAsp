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
    public partial class QLTaiKhoan : System.Web.UI.Page
    {
        XLDL xl = new XLDL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDDL();
                loadQLTK();
            }
        }
        public void loadDDL()
        {
            ddlQuyen.DataSource = xl.docDLDataTable("SELECT * FROM QUYEN_TK");
            ddlQuyen.DataBind();
        }
        public void loadQLTK(){
            GridAllStore.DataSource = xl.docDLDataTable("SELECT * FROM TAI_KHOAN");
            GridAllStore.DataBind();
        }
        protected void btn_Them_Click(object sender, EventArgs e)
        {
            bool kq;
            if (CheckBox1.Checked)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            string[] vals = new string[]
            {
                txtTenDN.Text,
                txtMK.Text,
                txtHoTen.Text,
                kq.ToString(),
                ddlQuyen.SelectedValue
            };
            string[] pars = new string[]
            {
                "@TenDn",
                "@MK",
                "@Ten",
                "@Khoa",
                "@IDQuyen"
            };
            try
            {
                xl.capNhatDuLieuStored("insertQTK", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadQLTK();
                Reset();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Thêm mới thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void Reset()
        {
            txtTenDN.Text = null;
            txtMK.Text = null;
            txtHoTen.Text = null;
            CheckBox1.Checked = false;

        }
        protected void bnt_Sua_Click(object sender, EventArgs e)
        {
            bool kq;
            if (CheckBox1.Checked)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            string[] vals = new string[]
           {
               hdfID.Value,
                txtTenDN.Text,
                txtMK.Text,
                txtHoTen.Text,
                kq.ToString(),
                ddlQuyen.SelectedValue
           };
            string[] pars = new string[]
            {
                "ID",
                "@TenDn",
                "@MK",
                "@Ten",
                "@Khoa",
                "@IDQuyen"
            };
            try
            {
                xl.capNhatDuLieuStored("updateTK", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadQLTK();
                Reset();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Thêm mới thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = null;
            txtMK.Text = null;
            txtHoTen.Text = null;
            CheckBox1.Checked = false;
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
                "@ID"
            };
            DataTable dt = xl.docDLDataTableStored("selecttTK", vals, pars);
            if (dt.Rows.Count > 0)
            {                               
                hdfID.Value = dt.Rows[0]["ID_TAI_KHOAN"] + "";
                txtTenDN.Text = dt.Rows[0]["TEN_DANG_NHAP"] + "";
                txtMK.Text = dt.Rows[0]["MAT_KHAU"] + "";              
                txtHoTen.Text = dt.Rows[0]["HO_TEN"] + "";
                if ((bool)dt.Rows[0]["KHOA_TK"] == true)
                {
                    CheckBox1.Checked = true;
                }
                else
                {
                    CheckBox1.Checked = false;
                }
                ddlQuyen.SelectedValue = dt.Rows[0]["ID_QUYEN"] + "";             
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
                "@ID"
            };
            try
            {
                xl.capNhatDuLieuStored("deleteTK", vals, pars);
                lblThongBao.Text = "Xóa thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadQLTK();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Xóa thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}