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
    public partial class QLTheLoai : System.Web.UI.Page
    {
        XLDL xl = new XLDL();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadTL();
        }
        public void loadTL()
        {
            GridAllStore.DataSource = xl.docDLDataTableStored("selectTheLoai", null, null);
            GridAllStore.DataBind();
        }
        protected void btn_Them_Click(object sender, EventArgs e)
        {
            
                string[] vals = new string[]
                {
                   txtID.Text,
                    txtTen.Text
                };
                string[] pars = new string[]
                 {
                     "ID",
                     "@Ten"
                 };
               
            try
            {
                xl.capNhatDuLieuStored("insertTL", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadTL();
                Reset();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Thêm mới thất bại";
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
            DataTable dt = xl.docDLDataTableStored("selecttTL", vals, pars);
            if (dt.Rows.Count > 0)
            {
                hdfID.Value = dt.Rows[0]["ID_THE_LOAI"] + "";
                txtID.Text = dt.Rows[0]["ID_THE_LOAI"] + "";
                txtTen.Text = dt.Rows[0]["TEN_THE_LOAI"] + "";
                
               
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
                "@ID_THE_LOAI"
            };
            try
            {
                xl.capNhatDuLieuStored("deleteTL", vals, pars);
                lblThongBao.Text = "Xóa thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadTL();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Xóa thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void bnt_Sua_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
           {
               hdfID.Value,
               txtTen.Text
           };
            string[] pars = new string[]
            {
                "@ID",
                "@TEN_TL"
                
            };
            try
            {

                if (xl.capNhatDuLieuStored("updateTL", vals, pars) > 0)
                {
                    lblThongBao.Text = "Update thành công";
                    lblThongBao.ForeColor = System.Drawing.Color.Blue;
                    loadTL();
                    Reset();
                }

            }
            catch (SqlException)
            {
                lblThongBao.Text = "Update thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void Reset()
        {
            txtID.Text = null;
            txtTen.Text = null; 
        }

        protected void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtTen.Text = null;
        }
    }
}