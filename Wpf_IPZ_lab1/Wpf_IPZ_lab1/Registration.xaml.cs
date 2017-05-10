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
using System.Windows.Shapes;

namespace Wpf_IPZ_lab1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Save_Button_Click_1(object sender, RoutedEventArgs e)
        {
        if (Priz.Text.Equals(""))
        {
            MessageBox.Show("Введіть ПІБ!");
        }
        else if (L1.Text.Equals(""))
        {
            MessageBox.Show("Введіть № залікової!");
        }
        else if (L2.Text.Equals(""))
        {
            MessageBox.Show("Введіть Пароль");
        }
        else
        {
            MessageBox.Show("Ви зареєстровані!");
        }}




        private void Back_Button_Click_1(object sender, RoutedEventArgs e)
        {




            if (Priz.Text.Equals("") || L2.Text.Equals("") || L1.Text.Equals("") )
            {
                MessageBox.Show("помилка вводу");
            }
            MainWindow wnd0 = new MainWindow();
            wnd0.Show();
            this.Close();
        }
        }
    class reg
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public reg(string login1, string parol1, string parol2, string  pib)
        {
            this.login1 = login1;
            this.parol1 = parol1;
            this.parol2 = parol2;
            this.pib = pib;
        }

        public string login1
        {
            get { return login1; }
            set
            {
                login1 = value;
                OnPropertyChanged("login1");
            }
        }

        public string parol1
        {
            get { return parol1; }
            set
            {
                parol1 = value;
                OnPropertyChanged("parol1");
            }
        }

        public string parol2
        {
            get { return parol2; }
            set
            {
                parol2 = value;
                OnPropertyChanged("parol2");
            }
        }


        public string pib
        {
            get { return pib; }
            set
            {
                pib = value;
                OnPropertyChanged("pib");
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
    

