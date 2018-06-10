using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyPhongKham
{
    class connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public SqlDataAdapter da;

        public void connect()// Copy Data Source vào chuỗi
        {

            string cn = ConfigurationManager.ConnectionStrings["QuanLyPhongKham.Properties.Settings.PhongKhamConnectionString"].ConnectionString;
            try
            {
                con = new SqlConnection(cn);
                if (con.State == ConnectionState.Open)
                { }
                else
                {                    
                    con.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void disconnect()   // gọi hàm này sau khi đã dùng xong csdl 
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                //con = null;
            }
            else { }
        }
        public void insert(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                connect();
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void delete(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                connect();
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public void sql(string query)//update
        {
            if (con.State == ConnectionState.Closed)
            {
                connect();
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public void loadcomboBox(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                connect();
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
        }
        public DataTable SQL(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                connect();
            }            
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }
    }
}
