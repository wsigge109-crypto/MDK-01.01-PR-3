using System.Windows;
using practicheskay_3_Poluda_E.pr_24._101.Pages;

namespace practicheskay_3_Poluda_E.pr_24._101
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Autho());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.GoBack();
        }

        private void FrmMain_ContentRendered(object sender, System.EventArgs e)
        {
            if (FrmMain.CanGoBack)
                btnBack.Visibility = Visibility.Visible;
            else
                btnBack.Visibility = Visibility.Hidden;
        }
    }
}
