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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFClock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            RunUpdate();
        }

        private async void RunUpdate()
        {
            while (true)
            {
                await Dispatcher.InvokeAsync(() =>
                {
                    var now = DateTime.Now;
                    lblTime.Content = $"{now.ToLongDateString()} {now.ToLongTimeString()}";
                });
                await Task.Delay(100);
            }
        }
    }
}
