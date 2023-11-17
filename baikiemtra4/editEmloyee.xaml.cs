using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
namespace baikiemtra4
{
    /// <summary>
    /// Interaction logic for editEmloyee.xaml
    /// </summary>
    public partial class editEmloyee : Window
    {
      
        public editEmloyee()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // cập nhật sql
                string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Emloyee " +
                                     "SET Name = @Name, Sex = @Sex, Address = @Address, Telephone = @Telephone, DateofB = @DateofB " +
                                     "WHERE MNV = @MNV";
                    using (SqlCommand Command = new SqlCommand(updateQuery, connection))
                    {
                        Command.Parameters.AddWithValue("@MNV", txt_ID_EL_.Text);
                        Command.Parameters.AddWithValue("@Name", txt_Name_EL_.Text);
                        Command.Parameters.AddWithValue("@Address", txt_Adress_EL_.Text);
                        Command.Parameters.AddWithValue("@Telephone", txt_Tel_EL_.Text);
                        Command.Parameters.AddWithValue("@Sex", (rb_Male_.IsChecked == true) ? "Nam" : "Nữ");
                        Command.Parameters.AddWithValue("@DateofB", dp_DateobB_.Text);
                        Command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                // cập nhật listview
                //???
                
                MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!!!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
