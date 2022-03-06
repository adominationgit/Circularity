using System.Windows;

namespace Circularity
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
        private void GetStartedClick(object sender, RoutedEventArgs e)
        {
            Window1 TaskList = new Window1();
            TaskList.Show();
            this.Close();
        }
    }
}
