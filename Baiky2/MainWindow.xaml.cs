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

namespace Baiky2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] mang = { 7, 5, 6, 9, 3 };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbnTong_Click(object sender, RoutedEventArgs e)
        {
            int tong = 0;
            foreach (int i in mang)
                tong += i;

            ketqua.Text = "Tong = " + tong.ToString();
        }

        private void TbnTongLe_Click(object sender, RoutedEventArgs e)
        {
            int tong = 0;
            foreach (int i in mang)
                if (i % 2 != 0)
                    tong += i;

            ketqua.Text = "Tong le = " + tong.ToString();
        }
    }
}
