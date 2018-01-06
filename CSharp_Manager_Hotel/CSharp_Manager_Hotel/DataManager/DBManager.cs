using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel.DataManager
{
    class DBManager
    {
        private bool isConfirm; // Kiểm tra xem các hàm thực hiện có thực hiện được không
        private string myConnection;
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public DBManager()
        {
            conn = DBUtils.GetDBConnection();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }      

        public DataTable queryDataToMySql(string querySelect) // Lấy dữ liệu
        {
            conn.Open();
            cmd.CommandText = querySelect;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            mySqlDataAdapter.Fill(data);
            conn.Close();
            return data;
        }
        public void insertDataToMySql(string queryInsert) // Thêm dữ liệu
        {
            conn.Open();
            cmd.CommandText = queryInsert;
            MySqlDataReader myReader = cmd.ExecuteReader();
            conn.Close();
        }

        public void deleteDataToMySql(string queryDelete) // Xóa dữ liệu
        {
            try
            {
                conn.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateDataToMySql(string queryUpdate) // Cập nhật dữ liệu
        {
            try
            {
                conn.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}