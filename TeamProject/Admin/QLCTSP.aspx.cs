using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace TeamProject.Admin
{
    public partial class QLCTSP : System.Web.UI.Page
    {
        XLDL xl = new XLDL();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadCTSP();
        }
        public void loadCTSP()
        {
            GridAllStore.DataSource = xl.docDLDataTable("SELECT * FROM CT_SANPHAM");
            GridAllStore.DataBind();
        }
        protected void btn_Them_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
                {                
                    txtTen.Text,
                    txtMoTa.Text,
                    txtHinhAnh.Text
                };
            string[] pars = new string[]
             {
                     "@Ten",
                     "@MoTa",
                     "@HinhAnh"
             };

            try
            {
                xl.capNhatDuLieuStored("insertCTSP", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";               
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadCTSP();
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
            txtTen.Text = null;
            txtMoTa.Text = null;
            txtHinhAnh.Text = null;
        }
        protected void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = null;
            txtMoTa.Text = null;
            txtHinhAnh.Text = null;
        }

        protected void bnt_Sua_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
            {
                hdfID.Value,
               txtTen.Text,
               txtMoTa.Text,
               txtHinhAnh.Text
             };
            string[] pars = new string[]
            {
                    "ID",
                     "@Ten",
                     "@MoTa",
                     "@HinhAnh"
            };
            try
            {

                if (xl.capNhatDuLieuStored("updateCTSP", vals, pars) > 0)
                {
                    lblThongBao.Text = "Update thành công";
                    lblThongBao.ForeColor = System.Drawing.Color.Blue;
                    loadCTSP();
                    Reset();
                }

            }
            catch (SqlException)
            {
                lblThongBao.Text = "Update thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
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
            DataTable dt = xl.docDLDataTableStored("selecttCTSP", vals, pars);
            if (dt.Rows.Count > 0)
            {
                hdfID.Value = dt.Rows[0]["ID_CT_SP"] + "";
                txtTen.Text = dt.Rows[0]["TEN_CT_SP"] + "";
                txtMoTa.Text = dt.Rows[0]["MO_TA"] + "";
                txtHinhAnh.Text = dt.Rows[0]["HINH_ANH"] + "";

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
                "@ID_CT_SP"
            };
            try
            {
                xl.capNhatDuLieuStored("deleteCTSP", vals, pars);
                lblThongBao.Text = "Xóa thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadCTSP();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Xóa thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}