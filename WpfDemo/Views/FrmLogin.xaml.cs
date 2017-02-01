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
using System.Windows.Shapes;

namespace WpfDemo.Views
{
    /// <summary>
    /// FrmLogin.xaml 的互動邏輯
    /// </summary>
    public partial class FrmLogin : UserControl
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void MENU_Click(object sender, RoutedEventArgs e)
        {
            #region 目錄的獲取
            MenuItem lo_MenuItem = new MenuItem();
            string ls_MenuName = lo_MenuItem.Header.ToString();
            string ls_URL = lo_MenuItem.CommandParameter.ToString();
            #endregion
            #region 是否開啓
            for (int i = 0; i < TabCtrl_MainPage.Items.Count; i++)
            {
                string ls_ItemHeader = ((Module.Common.ColsableTab)this.TabCtrl_MainPage.Items[i]).Title.ToString();
                if (ls_ItemHeader == ls_MenuName)
                {
                    ((TabItem)this.TabCtrl_MainPage.Items[i]).IsSelected = true;
                }
            }
            #endregion

            var p = (UserControl)System.Windows.Application.LoadComponent(
                new Uri(@"WpfDemo;component/Program/" + ls_URL, System.UriKind.RelativeOrAbsolute));

            Module.Common.ColsableTab theTabItem = new Module.Common.ColsableTab();
            theTabItem.Title = ls_MenuName;
            theTabItem.Content = p;
            TabCtrl_MainPage.Items.Add(theTabItem);
            theTabItem.Focus();
        }


    }
}
