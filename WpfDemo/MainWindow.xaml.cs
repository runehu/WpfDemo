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
//using System.Data.SqlClient;
using System.Data.OracleClient;
//using System.Data.OleDb;
using System.IO;
using WpfDemo.Views;
//using System.Windows.Navigation;

namespace WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //private void btn_Close_Click(object sender, RoutedEventArgs e)//关闭
        //{
        //    var ret = MessageBox.Show("Are you sure to exit aud it?", "Alert", MessageBoxButton.YesNo);
        //    if (ret == MessageBoxResult.Yes)
        //    {

        //        DataProvider.Instance.LoginOut();
        //        //终止所有线程
        //        Environment.Exit(Environment.ExitCode);
        //    }
        //}
        private void btn_Min_Click(object sender, RoutedEventArgs e) //最小化
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
        private void Max_btn_Click(object sender, RoutedEventArgs e) //最大化
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }
        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
            NavigationWindow Window = new NavigationWindow();
            Window.Source = new Uri(@"/WpfDemo;component/Views/FrmLogin.xaml", UriKind.Relative);
            Window.Show();
            this.Close();
           
        }




    }
}
