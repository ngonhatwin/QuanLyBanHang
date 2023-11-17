using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace baikiemtra4
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class WinWetson : Window
    {
        
        
        public WinWetson()
        {
            
            InitializeComponent();
            LoadProductNames();
            LoadEmloyeeNames();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_SP__Click(object sender, RoutedEventArgs e)
        {
           //
        }

        private void LoadProductNames()
        {
            try
            {
                string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Truy vấn SQL SELECT để lấy tên sản phẩm
                    string queryString = "SELECT Name FROM Product";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Xóa các mục hiện có trong ComboBox
                            cb_Product_W_.Items.Clear();

                            // Đọc dữ liệu từ SqlDataReader và thêm vào ComboBox
                            while (reader.Read())
                            {
                                cb_Product_W_.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadEmloyeeNames()
        {
            try
            {
                string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Truy vấn SQL SELECT để lấy tên sản phẩm
                    string queryString = "SELECT Name FROM Emloyee";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Xóa các mục hiện có trong ComboBox
                            cb_Emloyee_.Items.Clear();

                            // Đọc dữ liệu từ SqlDataReader và thêm vào ComboBox
                            while (reader.Read())
                            {
                                cb_Emloyee_.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
