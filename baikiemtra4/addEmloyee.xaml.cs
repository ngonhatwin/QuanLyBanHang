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
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace baikiemtra4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WinEmloyee : Window
    {
        
        public WinEmloyee()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Emloyee newEmloyee = new Emloyee
            {
                Id = txt_ID_EL_.Text,
                EmloyName = txt_Name_EL_.Text,
                EmloyAddress = txt_Adress_EL_.Text,
                EmloyTel = txt_Tel_EL_.Text,
                EmloySex = (rb_Male_.IsChecked == true) ? "Nam" : "Nữ",
                EmloyDateofB = DateTime.Parse(dp_DateobB_.Text)  // Chuyển đổi ngày thành DateTime
            };
            string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "INSERT INTO Emloyee values (@MNV, @Name, @Sex, @Address, @Telephone, @DateofB)";
                using (SqlCommand Command = new SqlCommand(queryString, connection))
                {
                    Command.Parameters.AddWithValue("@MNV", txt_ID_EL_.Text);
                    Command.Parameters.AddWithValue("@Name", txt_Name_EL_.Text);
                    Command.Parameters.AddWithValue("@Address", txt_Adress_EL_.Text);
                    Command.Parameters.AddWithValue("@Telephone", txt_Tel_EL_.Text);
                    Command.Parameters.AddWithValue("@Sex", (rb_Male_.IsChecked == true) ? "Nam" : "Nữ");
                    Command.Parameters.AddWithValue("@DateofB", dp_DateobB_.Text);

                    int rowsAffected = Command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MainEmloyee mainEmloyee = Application.Current.Windows.OfType<MainEmloyee>().FirstOrDefault();

                        if (mainEmloyee != null)
                        {
                            // Sử dụng thể hiện hiện tại để thêm Emloyee vào ListView
                            mainEmloyee.AddEmloyeeToListView(newEmloyee);
                        }

                        MessageBox.Show("Thêm nhân viên thành công!!!.");
                    }
                    else
                    {
                        // Insert failed
                        MessageBox.Show("Thêm nhân viên thất bại!!!.");
                    }
                   
                }
                connection.Close();
            }
        }
        //private void lv_Emloyee__MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    if (lv_Emloyee_.SelectedItem != null)
        //    {
        //        Emloyee selectedEmloyee = (Emloyee)lv_Emloyee_.SelectedItem;

        //        // Hiển thị thông tin nhân viên trên  TextBox
        //        txt_ID_EL_.Text = selectedEmloyee.Id;
        //        txt_Name_EL_.Text = selectedEmloyee.EmloyName;
        //        txt_Adress_EL_.Text = selectedEmloyee.EmloyAddress;
        //        txt_Tel_EL_.Text = selectedEmloyee.EmloyTel;
        //        if (selectedEmloyee.EmloySex == "Nam")
        //        {
        //            rb_Male_.IsChecked = true;
        //        }
        //        else if (selectedEmloyee.EmloySex == "Nữ")
        //        {
        //            rb_Female_.IsChecked = true;
        //        }
        //        dp_DateobB_.Text = selectedEmloyee.EmloyDateofB.ToString("yyyy-MM-dd");
        //    }
        //}

        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{

        //    if (lv_Emloyee_.SelectedItem != null)
        //    {
        //        Emloyee selectedEmloyee = (Emloyee)lv_Emloyee_.SelectedItem;
        //        try
        //        {
        //            // cập nhật sql
        //            string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
        //            using (SqlConnection connection = new SqlConnection(connectionString))
        //            {
        //                connection.Open();
        //                string updateQuery = "UPDATE Emloyee " +
        //                                 "SET Name = @Name, Sex = @Sex, Address = @Address, Telephone = @Telephone, DateofB = @DateofB " +
        //                                 "WHERE MNV = @MNV";
        //                using (SqlCommand Command = new SqlCommand(updateQuery, connection))
        //                {
        //                    Command.Parameters.AddWithValue("@MNV", txt_ID_EL_.Text);
        //                    Command.Parameters.AddWithValue("@Name", txt_Name_EL_.Text);
        //                    Command.Parameters.AddWithValue("@Address", txt_Adress_EL_.Text);
        //                    Command.Parameters.AddWithValue("@Telephone", txt_Tel_EL_.Text);
        //                    Command.Parameters.AddWithValue("@Sex", (rb_Male_.IsChecked == true) ? "Nam" : "Nữ");
        //                    Command.Parameters.AddWithValue("@DateofB", dp_DateobB_.Text);
        //                    Command.ExecuteNonQuery();
        //                }
        //                connection.Close();
        //            }
        //            // cập nhật listview
        //            selectedEmloyee.Id = txt_ID_EL_.Text;
        //            selectedEmloyee.EmloyName = txt_Name_EL_.Text;
        //            selectedEmloyee.EmloyAddress = txt_Adress_EL_.Text;
        //            selectedEmloyee.EmloyTel = txt_Tel_EL_.Text;
        //            selectedEmloyee.EmloySex = (rb_Male_.IsChecked == true) ? "Nam" : "Nữ";
        //            selectedEmloyee.EmloyDateofB = DateTime.Parse(dp_DateobB_.Text);
        //            lv_Emloyee_.Items.Refresh();

        //            MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!!!.");
               
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa!!!.");
        //    }    
        //}

        //private void Remove_Click(object sender, RoutedEventArgs e)
        //{
        //    // Kiểm tra xem có mục nào được chọn hay không
        //    if (lv_Emloyee_.SelectedItem != null)
        //    {
        //        Emloyee selectedEmloyee = (Emloyee)lv_Emloyee_.SelectedItem;

        //        string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string queryString = "DELETE FROM Emloyee WHERE MNV = @MNV";
        //            using (SqlCommand command = new SqlCommand(queryString, connection))
        //            {
        //                // Sử dụng ID trực tiếp từ đối tượng được chọn
        //                command.Parameters.AddWithValue("@MNV", selectedEmloyee.Id);
        //                command.ExecuteNonQuery();

        //                MessageBox.Show("Xóa thành công nhân viên");

        //                // Xóa đối tượng được chọn từ ListView
        //                lv_Emloyee_.Items.Remove(selectedEmloyee);
        //            }
        //            connection.Close();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
        //    }
        //}

    }
}
