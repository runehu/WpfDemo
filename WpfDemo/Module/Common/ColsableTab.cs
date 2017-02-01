using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfDemo.Module.Common
{
    public class ColsableTab : TabItem
    {
        public ColsableTab()
        {
            Module.UserCtrl.UC_CloseableHeader ColsableTabHeader = new Module.UserCtrl.UC_CloseableHeader();
            this.Header = ColsableTabHeader;
            ColsableTabHeader.button_close.MouseEnter += new MouseEventHandler(button_close_MouseEnter);
            ColsableTabHeader.button_close.MouseLeave += new MouseEventHandler(button_close_MouseLeave);
            ColsableTabHeader.button_close.Click += new RoutedEventHandler(button_close_Click);
            ColsableTabHeader.label_TabTitle.SizeChanged += new SizeChangedEventHandler(label_TabTitle_SizeChanged);
        }
        public string Title
        {
            set
            {
                ((Module.UserCtrl.UC_CloseableHeader)this.Header).label_TabTitle.Content = value;
            }
            get
            {
                return ((Module.UserCtrl.UC_CloseableHeader)this.Header).label_TabTitle.Content.ToString().Trim();
            }
        }
        public void button_close_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Foreground = Brushes.Red;
        }
        public void button_close_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Foreground = Brushes.Black;
        }
        public void button_close_Click(object sender, RoutedEventArgs e)
        {
            ((TabControl)this.Parent).Items.Remove(this);
        }
        public void label_TabTitle_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Margin = new Thickness(((Module.UserCtrl.UC_CloseableHeader)this.Header).label_TabTitle.ActualWidth + 5, 3, 4, 0);
        }
        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Visibility = Visibility.Visible;
        }
        protected override void OnUnselected(RoutedEventArgs e)
        {
            base.OnUnselected(e);
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Visibility = Visibility.Hidden;
        }
        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Visibility = Visibility.Visible;
        }
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            if (!this.IsSelected)
            {
                ((Module.UserCtrl.UC_CloseableHeader)this.Header).button_close.Visibility = Visibility.Hidden;
            }
        }
    }
}
