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

namespace Wpf_IPZ_lab1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

       

        

        private void Search_button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 wnd2 = new Window2();
            wnd2.Show();
            this.Close();
            
        }

        private void Back_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 wnd2 = new Window2();
            wnd2.Show();
            this.Close();
        }
    }

}
