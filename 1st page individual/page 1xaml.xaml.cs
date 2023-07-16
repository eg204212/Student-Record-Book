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

namespace _1st_page_individual
{
    /// <summary>
    /// Interaction logic for page_1xaml.xaml
    /// </summary>
    public partial class page_1xaml : Window
    {
        public page_1xaml()
        {
            InitializeComponent();
        }

       
        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
