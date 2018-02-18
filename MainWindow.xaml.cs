using System;
using System.Windows;


namespace FireEmblemRPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

         Random randomNumber = new Random();
        //RandomNumberGenerator pcResponse = new RandomNumberGenerator();

        public const int lanceID = 1;
        public const int axeID = 2;
        public const int swordID = 3;
    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLance_Click(object sender, RoutedEventArgs e)
        {
           PlayerBox.Text = "You lunge towards your opponent with the Gae Bolg!";
            int pcResponse = randomNumber.Next(1, 4);

            if (pcResponse == lanceID)
            {
                PcBox.Text = "Your enemy lunges at you with the Gungnir!"; 
                ResultBox.Text = "Draw!";
            }

            if (pcResponse == axeID)
            {
                PcBox.Text = "Your enemy swings the Brave Axe!";
                ResultBox.Text = "Defeated!";

            }

            if (pcResponse == swordID)
            {
                PcBox.Text = "Your enemy slashes you with the Binding Blade!";
                ResultBox.Text = "Winner, winner, chicken dinner!";
            }

        }

        private void btnAxe_Click(object sender, RoutedEventArgs e)
        {
            PlayerBox.Text = "You swing the mighty Vengeance!";
            int pcResponse = randomNumber.Next(1, 4);

            if (pcResponse == lanceID)
            {
                PcBox.Text = "Your enemy lunges at you with the Gungnir! ";
                ResultBox.Text = "Winner, winner, chicken dinner!";

            }

           if (pcResponse == axeID)
           {
                PcBox.Text = "Your enemy swings the Brave Axe! ";
                ResultBox.Text = "Draw!";
           }

           if (pcResponse == swordID)
            {
                PcBox.Text = "Your enemy slashes you with the Binding Blade!";
                ResultBox.Text = "Defeated!";
            }


        }

        private void btnSword_Click(object sender, RoutedEventArgs e)
        {
            PlayerBox.Text = "You slash your opponent with the Falchion!";
            int pcResponse = randomNumber.Next(1, 4);

            if (pcResponse == lanceID)
            {
                PcBox.Text = "Your enemy lunges at you with the Gungnir! ";
                ResultBox.Text = "Defeated!";
            }

            if (pcResponse == axeID)
            {
                PcBox.Text = "Your enemy swings the Brave Axe!";
                ResultBox.Text = "Winner, winner, chicken dinner!";
            }

            if (pcResponse == swordID)
            {
                PcBox.Text = "Your enemy slashes you with the Binding Blade!";
                ResultBox.Text = "Draw!";
            }

        }



    }
}
