using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace Dental_Clinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string password;
        
        BL.Cls_Login Log = new BL.Cls_Login();

        
        public MainWindow()
        {
            InitializeComponent();
            
            Com_Id.ItemsSource = Log.AllUser().DefaultView;
            Com_Id.DisplayMemberPath = "Name";
            Com_Id.SelectedValuePath = "Id";
           
           
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TxtPwd.Visibility == Visibility.Visible)
            {
                password = TxtPwd.Password;
            }
            else
            {
                password = txtVisiblePasswordbox.Text;
            }

            DataTable dt = Log.Login(Com_Id.Text, password);
            

            if (string.IsNullOrEmpty(Com_Id.Text) || (string.IsNullOrEmpty(txtVisiblePasswordbox .Text) && string.IsNullOrEmpty(TxtPwd.Password)))
            {
                MessageBox.Show("لا يمكن ترك البيانات فارغة ", "تحذير", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                return;
            }

           
            if (dt.Rows.Count > 0)
            {

                Img_TrueUp.Visibility = Visibility.Visible;

            Img_TrueDown.Visibility = Visibility.Visible;

            MessageBox.Show("تم تسجيل الدخول بنجاح ", "تسجيل الدخول", MessageBoxButton.OK, MessageBoxImage.Information);

              

                PL.MainScreen Form = new PL.MainScreen();

                    var user_type = dt.Rows[0][3];

                    if (user_type.ToString()=="مدير")
                     {
                         Form.المستخدمينToolStripMenuItem.Enabled = true;
                     }
                     else
                     {
                         Form.المستخدمينToolStripMenuItem.Enabled = false;
                     }
                //
             this.Hide();
                Form.ShowDialog();

            }


            else
            {
              
                MessageBox.Show("الرجاء التحقق من  المعلومات ","خطأ" , MessageBoxButton.OKCancel,MessageBoxImage.Error);
  

                Img_FalseDown.Visibility = Visibility.Visible;
            }
        }

        private void BtnEye_ShowPassword(object sender, RoutedEventArgs e)
        {
            txtVisiblePasswordbox.Visibility = Visibility.Visible;
            TxtPwd.Visibility = Visibility.Hidden;

            txtVisiblePasswordbox.Text = TxtPwd.Password;
            txtVisiblePasswordbox.Focus();

            BtnEye_Hide.Visibility = Visibility.Visible;
        }

        private void BtnEye_HidePassword(object sender, RoutedEventArgs e)
        {
            TxtPwd.Visibility = Visibility.Visible;
            txtVisiblePasswordbox.Visibility = Visibility.Hidden;


           TxtPwd.Password = txtVisiblePasswordbox.Text;
           TxtPwd.Focus();

           BtnEye_Hide.Visibility = Visibility.Hidden;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {   
                Button_Click(sender, e);
            }
        }

        private void Comid_GotFocus(object sender, RoutedEventArgs e)
        {
            Com_Id.IsDropDownOpen = true;
           
        }

        private void Comid_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
          
            Com_Id.Focusable = false;
         
        }
       
    }
}
