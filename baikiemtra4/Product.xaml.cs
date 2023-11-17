using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class WinProduct : Window
    {
 
        public WinProduct()
        {
        
            InitializeComponent();
           
        }

        private void AddSP_Click(object sender, RoutedEventArgs e)
        {
            //thêm vào listview
            Product newproduct = new Product
            {
                ProductID = txt_id_SP_.Text,
                ProductName = txt_Name_SP_.Text,
                SumQuantity = int.Parse(txt_Price_SP_.Text),
                Price = int.Parse(txt_Price_SP_.Text) ,
                
                
            };
            string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //thêm vào sql
                string queryString = "INSERT INTO Product values (@MSP, @Name, @Quantity, @Price)";
                using (SqlCommand Command = new SqlCommand(queryString, connection))
                {
                    Command.Parameters.AddWithValue("@MSP", txt_id_SP_.Text);
                    Command.Parameters.AddWithValue("@Name", txt_Name_SP_.Text);
                    Command.Parameters.AddWithValue("@Quantity", txt_sumQuantity_SP_.Text);
                    Command.Parameters.AddWithValue("@Price", txt_Price_SP_.Text);

                    int rowsAffected = Command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Insert successful
                        lv_SP_.Items.Add(newproduct);
                        MessageBox.Show("Thêm sản phẩm thành công!!!.");
                    }
                    else
                    {
                        // Insert failed
                        MessageBox.Show("Thêm sản phẩm thất bại!!!.");
                    }
                }
                connection.Close();
            }


        }
        private void lv_Product__MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lv_SP_.SelectedItem != null)
            {
                Product selectedProduct = (Product)lv_SP_.SelectedItem;

                // Hiển thị thông tin nhân viên trên  TextBox
                txt_id_SP_.Text = selectedProduct.ProductID;
                txt_Name_SP_.Text = selectedProduct.ProductName;
                txt_sumQuantity_SP_.Text = selectedProduct.SumQuantity.ToString();
                txt_Price_SP_.Text = selectedProduct.Price.ToString();
            }
        }
        private void EditSP_Click(object sender, RoutedEventArgs e)
        {
            if (lv_SP_.SelectedItem != null)
            {
                Product selectedProduct = (Product)lv_SP_.SelectedItem;
                try
                {
                    // cập nhật sql
                    string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Product " +
                                         "SET Name = @Name, Quantity = @quantity, Price = @Price " +
                                         "WHERE MSP = @MSP";
                        using (SqlCommand Command = new SqlCommand(updateQuery, connection))
                        {
                            Command.Parameters.AddWithValue("@MSP", txt_id_SP_.Text);
                            Command.Parameters.AddWithValue("@Name", txt_Name_SP_.Text);
                            Command.Parameters.AddWithValue("@Quantity", txt_sumQuantity_SP_.Text);
                            Command.Parameters.AddWithValue("@Price", txt_Price_SP_.Text);
                            Command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    // cập nhật listview
                    selectedProduct.ProductID = txt_id_SP_.Text;
                    selectedProduct.ProductName = txt_Name_SP_.Text;
                    selectedProduct.SumQuantity = int.Parse(txt_sumQuantity_SP_.Text);
                    selectedProduct.Price = int.Parse(txt_Price_SP_.Text);
              
                    lv_SP_.Items.Refresh();

                    MessageBox.Show("Chỉnh sửa thông tin sản phẩm thành công!!!.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần chỉnh sửa!!!.");
            }
        }

        private void RemoveSP_Click(object sender, RoutedEventArgs e)
        {
            if (lv_SP_.SelectedItem != null)
            {
                Product selectedProduct = (Product)lv_SP_.SelectedItem;

                string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string queryString = "DELETE FROM Product WHERE MSP = @MSP";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        // Sử dụng ID trực tiếp từ đối tượng được chọn
                        command.Parameters.AddWithValue("@MSP", selectedProduct.ProductID);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công sản phẩm");

                        // Xóa đối tượng được chọn từ ListView
                        lv_SP_.Items.Remove(selectedProduct);
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }
    }
}
