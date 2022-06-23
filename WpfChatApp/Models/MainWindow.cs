using System;
using System.Windows;
namespace WpfChatApp
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

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.username.Text);
        }
        private void regiLink_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.username.Text);
            Uri uri = new Uri("Register.xaml", UriKind.Relative);
            //this.NavigationService.Navigate(uri);
        }
    }
}
