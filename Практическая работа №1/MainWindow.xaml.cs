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
using Lib_6;

namespace Практическая_работа__1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }       

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Копенкин Егор ИСП-31");
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_DoSomethingplz(object sender, RoutedEventArgs e)
        {
            string values ="", results="";

            Work1.Function1(ref values, ref results);

            tbResult.Text = results;
            tbValue.Text = values;
        }
    }
}
