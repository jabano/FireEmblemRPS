using System.Windows;

namespace FireEmblemRPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RPS rps = new RPS();
       
        //RandomNumberGenerator pcResponse = new RandomNumberGenerator();
    
        public MainWindow()
        {
            InitializeComponent();
            rpsGrid.DataContext = rps;
        }

        private void btnLance_Click(object sender, RoutedEventArgs e)
        {
            PlayerBox.Text = RPS.playerLanceAttack;
            rps.PCResponse();
            rps.LanceButton();            
        }

        private void btnAxe_Click(object sender, RoutedEventArgs e)
        {
            PlayerBox.Text = RPS.playerAxeAttack;
            rps.PCResponse();
            rps.AxeButton();        
        }

        private void btnSword_Click(object sender, RoutedEventArgs e)
        {
            PlayerBox.Text = RPS.playerSwordAttack;
            rps.PCResponse();
            rps.SwordButton();
        }
    }
}
