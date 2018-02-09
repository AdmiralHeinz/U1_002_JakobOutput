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

namespace U1_002_JakobOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
        }

        private void Sldr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double age_d = Sldr.Value;
            int age_i = (int)age_d;
            if (LblOutput != null)
            {
                LblOutput.Content = age_i.ToString();
            }
           
           
        }
    }
}