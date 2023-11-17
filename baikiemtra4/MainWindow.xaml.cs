using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace baikiemtra4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        //hiển thị trang chính quản lý nhân viên 
        private void WindowEmployee(object sender, RoutedEventArgs e)
        {
            MainEmloyee window = new MainEmloyee();
            //nhanvien
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM Emloyee";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Emloyee newemloyee = new Emloyee();
                            newemloyee.Id = reader["MNV"].ToString();
                            newemloyee.EmloyName = reader["Name"].ToString();
                            newemloyee.EmloyAddress = reader["Address"].ToString();
                            newemloyee.EmloyTel = reader["Telephone"].ToString();
                            newemloyee.EmloySex = reader["Sex"].ToString();
                            newemloyee.EmloyDateofB = Convert.ToDateTime(reader["DateofB"]);
                            window.lv_Emloyee_.Items.Add(newemloyee);
                        }
                    }
                }
                connection.Close();
                window.Show();
            }
        }

        private void WindowWetson(object sender, RoutedEventArgs e)
        {
            //hoadon
        
        }

        private void WindowProduct(object sender, RoutedEventArgs e)
        {
            //sanpham
            WinProduct window = new WinProduct();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT * FROM Product";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product newproduct = new Product();
                            newproduct.ProductID = reader["MSP"].ToString();
                            newproduct.ProductName = reader["Name"].ToString();
                            newproduct.SumQuantity = Convert.ToInt32(reader["Quantity"]);
                            newproduct.Price = Convert.ToInt32(reader["Price"]);

                            window.lv_SP_.Items.Add(newproduct);
                        }
                    }
                }
                connection.Close();
                window.Show();
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Addwetson_Click(object sender, RoutedEventArgs e)
        {
            WinWetson newwinwetson = new WinWetson();
            newwinwetson.Show();
        }

     
    }
}
