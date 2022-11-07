using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HyperPC
{
    /// <summary>
    /// Логика взаимодействия для ints.xaml
    /// </summary>
    public partial class ints : Page
    {
        public ints()
        {
            InitializeComponent();
        }

        private void screwdriver(object sender, RoutedEventArgs e)
        {
            Process.Start("https://kulikov205.github.io/screwdriver/");
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://drive.google.com/drive/u/3/folders/1o_unWil5tWqw1Qv2A2IAdtNCltDVLwt_");
        }
    }
}
