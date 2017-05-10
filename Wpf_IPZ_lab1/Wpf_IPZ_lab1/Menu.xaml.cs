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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Search_Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Window1 wnd1 = new Window1();
            wnd1.Show();
            this.Close();
        }

        private void RL_Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Massege.Text = "list";
        }

        private void NewInfo_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 wnd3 = new Window3();
            wnd3.Show();
            this.Close();
        }

        private void Exit_Button_Click_1(object sender, RoutedEventArgs e)
        {
          MainWindow wnd0 = new MainWindow();
            wnd0.Show();
            this.Close();
        }

        
    }
    class book
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public book(string avtor, string nazva, string vydav, string rik)
        {
            this.avtor = avtor;
            this.nazva = nazva;
            this.vydav = vydav;
            this.rik = rik;
        }

        public string avtor
        {
            get { return avtor; }
            set
            {
                avtor = value;
                OnPropertyChanged("avtor1");
            }
        }

        public string nazva
        {
            get { return nazva; }
            set
            {
                nazva = value;
                OnPropertyChanged("nazva");
            }
        }

        public string vydav
        {
            get { return vydav; }
            set
            {
                vydav = value;
                OnPropertyChanged("vydav");
            }
        }


        public string rik
        {
            get { return rik; }
            set
            {
                rik = value;
                OnPropertyChanged("rik");
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
