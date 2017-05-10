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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Ozinka.Text = "3";
        }

        private void Back_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 wnd2 = new Window2();
            wnd2.Show();
            this.Close();
        }

        private void Save_Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нові дані введено!");
            Window2 wnd2 = new Window2();
            wnd2.Show();
            this.Close();
        }

        private void Plus_Click_1(object sender, RoutedEventArgs e)
        {
            int a = 0;
            a = int.Parse(Ozinka.Text);
            a = a + 1;
            Ozinka.Text = a.ToString();
        }

        private void Minus_Click_1(object sender, RoutedEventArgs e)
        {
            int a1 = 0;
            a1 = int.Parse(Ozinka.Text);
            a1 = a1 - 1;
            Ozinka.Text = a1.ToString();
        }
        private void List_Loaded1(object sender, RoutedEventArgs e)
        {

            //List<string> data = new List<string>();
            //ListBox1.SelectedIndex = 0;
            //data.Add(" ");
            D_list.Items.Add("");
            D_list.Items.Add("Фізика");
            D_list.Items.Add("Алгебра");
            D_list.Items.Add("Українська Мова");
            D_list.Items.Add("Геометрія");
            D_list.Items.Add("Англійська мова");
           

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
}
