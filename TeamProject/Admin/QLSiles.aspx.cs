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
    public partial class QLSiles : System.Web.UI.Page
    {
        XLDL xl = new XLDL();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadQ();
        }
        public void loadQ()
        {
            GridAllStore.DataSource = xl.docDLDataTable("SELECT * FROM SLIDES");
            GridAllStore.DataBind();
        }
        protected void btn_Them_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
                {
                    txtTen.Text,
                    txtLink.Text
                };
            string[] pars = new string[]
             {
                     "@HinhAnh",
                     "@Link"
             };

            try
            {
                xl.capNhatDuLieuStored("insertSl", vals, pars);
                lblThongBao.Text = "Thêm mới thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadQ();
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
            txtLink.Text = null;
        }
        protected void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = null;
            txtLink.Text = null;
        }

        protected void bnt_Sua_Click(object sender, EventArgs e)
        {
            string[] vals = new string[]
            {
                hdfID.Value,
                txtTen.Text,
                txtLink.Text
             };
            string[] pars = new string[]
            {
                    "@ID",
                     "@HinhAnh",
                     "@Link"
            };
            try
            {

                if (xl.capNhatDuLieuStored("updateSl", vals, pars) > 0)
                {
                    lblThongBao.Text = "Update thành công";
                    lblThongBao.ForeColor = System.Drawing.Color.Blue;
                    loadQ();
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
            DataTable dt = xl.docDLDataTableStored("selecttSl", vals, pars);
            if (dt.Rows.Count > 0)
            {
                hdfID.Value = dt.Rows[0]["ID_SLIDE"] + "";
                txtTen.Text = dt.Rows[0]["HINH_ANH"] + "";
                txtLink.Text = dt.Rows[0]["LINK"] + "";
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
                xl.capNhatDuLieuStored("deleteSl", vals, pars);
                lblThongBao.Text = "Xóa thành công";
                lblThongBao.ForeColor = System.Drawing.Color.Blue;
                loadQ();
            }
            catch (SqlException)
            {
                lblThongBao.Text = "Xóa thất bại";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}