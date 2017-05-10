using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Wpf_IPZ_lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }


        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Equals(""))
            {
                MessageBox.Show("Введіть логін!");
            }
            else if (parol.Password.Equals(""))
            {
                MessageBox.Show("Введіть пароль!");
            }
            else
            {

                Window2 wnd2 = new Window2();
                wnd2.Show();
                this.Close();
            }
        }
        public double Fontsize { get; set; }
        private void registration_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 wnd4 = new Window4();
            wnd4.Show();
            this.Close();

        }
        class ID
        {


            public event PropertyChangedEventHandler PropertyChanged;

            public ID(string login, string parol)
            {
                this.login = login;
                this.parol = parol;

            }

            public string login
            {
                get { return login; }
                set
                {
                    login = value;
                    OnPropertyChanged("login");
                }
            }

            public string parol
            {
                get { return parol; }
                set
                {
                    parol = value;
                    OnPropertyChanged("parol");
                }
            }

            protected void OnPropertyChanged(string name)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(name));
                }
            }




        }
    }
}
