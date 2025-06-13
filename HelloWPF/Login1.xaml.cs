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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for Login1.xaml
    /// </summary>
    public partial class Login1 : Window
    {
        private object txtUserName;
        private object txtPassword;

        public Login1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            //Ta giả đò làm đăng nhập
            //Nếu thành công thì vào MainWindow
            //Nếu thất bại thì thông báo Failed
            if (txtUserName.Text == "obama" && 
                txtPassword.Password=="123")
            {
                //mở màn hình window:
                MainWindow mw=new MainWindow();
                mw.Show();
                //đóng màn hình đăng nhập"
                Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại rồi thím!");
            }
        }
    }
}
