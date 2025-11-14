using System.Text;
using System;   
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAndMVVM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void UpdateLabel_Click(object sender, RoutedEventArgs e)
        {
            mvm.MyLabelText = DateTime.Now.ToString();  // når du klikker på knappen ”Update Label” i GUI’en, så ændres MyLabelText i din MainViewModel til teksten for den lokale dato og tidspunkt lige nu (DateTime.Now
        }

    }
}