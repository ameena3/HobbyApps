using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplicationTraining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            textBox.Text = "";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
           // textBox.Text = "The button is disabled waiting for 2 secs";
            var task = Task.Run(() => {
                Thread.Sleep(2000);
                return "Login Successfull !!";
            });

            task.ConfigureAwait(true).GetAwaiter().OnCompleted(() => { button.IsEnabled = true;
                button.Content = task.Result;
            });
        }
    }
}
