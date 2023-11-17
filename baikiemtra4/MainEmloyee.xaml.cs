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
using System.Windows.Shapes;

namespace baikiemtra4
{
    /// <summary>
    /// Interaction logic for MainEmloyee.xaml
    /// </summary>
    public partial class MainEmloyee : Window
    {
        public MainEmloyee()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            editEmloyee editEmloyee = new editEmloyee();
             if (lv_Emloyee_.SelectedItem != null)
            {
                Emloyee selectedEmloyee = (Emloyee)lv_Emloyee_.SelectedItem;

                // Hiển thị thông tin nhân viên trên  TextBox
                editEmloyee.txt_ID_EL_.Text = selectedEmloyee.Id;
                editEmloyee.txt_Name_EL_.Text = selectedEmloyee.EmloyName;
                editEmloyee.txt_Adress_EL_.Text = selectedEmloyee.EmloyAddress;
                editEmloyee.txt_Tel_EL_.Text = selectedEmloyee.EmloyTel;
                if (selectedEmloyee.EmloySex == "Nam")
                {
                    editEmloyee.rb_Male_.IsChecked = true;
                }
                else if (selectedEmloyee.EmloySex == "Nữ")
                {
                    editEmloyee.rb_Female_.IsChecked = true;
                }
                editEmloyee.dp_DateobB_.Text = selectedEmloyee.EmloyDateofB.ToString("yyyy-MM-dd");
            }
            editEmloyee.Show();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn hay không
            if (lv_Emloyee_.SelectedItem != null)
            {
                Emloyee selectedEmloyee = (Emloyee)lv_Emloyee_.SelectedItem;

                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    string connectionString = "Data Source=192.168.1.239,1433;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123456aA@;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string queryString = "DELETE FROM Emloyee WHERE MNV = @MNV";
                        using (SqlCommand command = new SqlCommand(queryString, connection))
                        {
                            // Sử dụng ID trực tiếp từ đối tượng được chọn
                            command.Parameters.AddWithValue("@MNV", selectedEmloyee.Id);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Xóa thành công nhân viên!!");

                            // Xóa đối tượng được chọn từ ListView
                            lv_Emloyee_.Items.Remove(selectedEmloyee);
                        }
                        connection.Close();
                    }
                }
                else if (result == MessageBoxResult.No)
                {
                    // Người dùng chọn không, không thực hiện thao tác xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.!!");
            }
        }
        
        public void AddEmloyeeToListView(Emloyee newEmloyee)
        {
            lv_Emloyee_.Items.Add(newEmloyee);
        }

        

        private void btn_addEmloyee__Click(object sender, RoutedEventArgs e)
        {
            WinEmloyee newwinemloyee = new WinEmloyee();
            newwinemloyee.Show();
        }
    }
}
