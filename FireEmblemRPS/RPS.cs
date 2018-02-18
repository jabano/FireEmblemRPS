using System;
using System.ComponentModel;


namespace FireEmblemRPS
{
    public class RPS : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int pcResponse;
        private string pcText;
        private string resultText;

        public int PcResponse { get { return pcResponse; } set { pcResponse = value; } }
        public string PcText { get { return pcText; } set { pcText = value; OnPropertyChanged("PcText"); } }
        public string ResultText { get { return resultText; } set { resultText = value; OnPropertyChanged("ResultText"); } }

        public const int lanceID = 1;
        public const int axeID = 2;
        public const int swordID = 3;

        public const string playerLanceAttack = "You lunge towards your opponent with the Gae Bolg!";
        public const string playerAxeAttack = "You swing the mighty Vengeance!";
        public const string playerSwordAttack = "You slash your opponent with the Falchion!";

        public const string pcLanceAttack = "Your enemy lunges at you with the Gungnir!";
        public const string pcAxeAttack = "Your enemy swings the Brave Axe!";
        public const string pcSwordAttack = "Your enemy slashes you with the Binding Blade!";

        public const string win = "Winner, winner, chicken dinner!";
        public const string lose = "Defeat!";  
        public const string draw = "Draw!";


        public void PCResponse()
        {
            Random randomNumber = new Random();
            this.PcResponse = randomNumber.Next(1, 4);      
        }

        public void LanceButton()
        {
                               
            if (PcResponse == lanceID)
            {
                this.PcText = pcLanceAttack;
                this.ResultText = draw;
                    
            }

            else if (PcResponse == axeID)
            {
                this.PcText = pcAxeAttack;
                this.ResultText = lose;

            }

            else if (PcResponse == swordID)
            {
                this.PcText = pcSwordAttack;
                this.ResultText = win;
            }
        }

        public void AxeButton()
        {
            if (pcResponse == lanceID)
            {
                this.PcText = pcLanceAttack;
                this.ResultText = win;
            }

            else if (pcResponse == axeID)
            {
                this.PcText = pcAxeAttack;
                this.ResultText = draw;
            }

            else if (pcResponse == swordID)
            {
                this.PcText = pcSwordAttack;
                this.ResultText = lose;
            }
        }

        public void SwordButton()
        {
            if (pcResponse == lanceID)
            {
                this.PcText = pcLanceAttack;
                this.ResultText = lose;
            }

            else if (pcResponse == axeID)
            {
                this.PcText = pcAxeAttack;
                this.ResultText = win;
            }

            else if (pcResponse == swordID)
            {
                this.PcText = pcSwordAttack;
                this.ResultText = draw;
            }
        }

        //OnPropertyChanged Method to raise event
        //

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
