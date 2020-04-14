using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace TeamProject
{
    public class XLDL
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\TeamProject\TeamProject\App_Data\WebPhuKien.mdf;Integrated Security=True");
        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public void docdlddl(string query)
        {
            open();
            SqlCommand command = new SqlCommand(query, connect);
            command.CommandType = CommandType.Text;
        }
        public int capNhatDuLieu(string query)        {
            open();            SqlCommand command = new SqlCommand(query, connect);            return command.ExecuteNonQuery();        }
        public int capNhatDuLieuStored(string query, string[] values, string[] paras)        {            open();            SqlCommand command = new SqlCommand(query, connect);
            command.CommandType = CommandType.StoredProcedure;
            if (paras != null)
                for (int i = 0; i < paras.Length; i++)
                {
                    command.Parameters.Add(new SqlParameter(paras[i], values[i]));
                }            return command.ExecuteNonQuery();        }
        public DataTable docDLDataTable(string query)
        {
            open();
            SqlCommand command = new SqlCommand(query, connect);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);
            return dt;
        }
        public DataTable docDLDataTableStored(string query, string[] values, string[] paras)
        {
            open();
            SqlCommand command = new SqlCommand(query, connect);
            command.CommandType = CommandType.StoredProcedure;
            if (paras != null)
                for (int i = 0; i < paras.Length; i++)
                {
                    command.Parameters.Add(new SqlParameter(paras[i], values[i]));
                }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);
            return dt;
        }

    }
}
