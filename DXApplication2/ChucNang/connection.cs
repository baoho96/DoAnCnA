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
        
        public void connect()
        { // Copy Data Source vào chuỗi
            String cn = @"Data Source=HENDY;Initial Catalog=PhongKham;Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch (Exception ex)
            {
            }
        }
        public void disconnect()   // gọi hàm này sau khi đã dùng xong csdl 
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        public void insert(string query)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void delete(string query)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public void sql(string query)//update
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public void loadcomboBox(string query)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
        }
        public DataTable SQL(string query)
        {
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Close();
            return (dt);
        }
    }
}
