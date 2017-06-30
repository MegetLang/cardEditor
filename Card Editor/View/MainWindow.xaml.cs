using System.Windows;
//using Card_Editor.ViewModel;
using Card_Editor.Model;

namespace Card_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void artworkSelect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveCard_Click(object sender, RoutedEventArgs e)
        {
            int s;
            int d;
            int m;
            if (CardName.Text.Trim() == "")
            {
                MessageBox.Show("Your card needs a name");
            }

            else if(!int.TryParse(StrengthBox.Text, out s) || s < 0 || s > 10 || !int.TryParse(DefenseBox.Text, out d) || d < 0 || d > 10 || !int.TryParse(ManaBox.Text, out m) || m < 0 || m > 10)
            {
                MessageBox.Show("Strength, defense and mana must be a number between 0 and 10");
            }
            else
            {
                Cards card = new Cards();
                card.Name = CardName.Text.Trim();
                //card.Type = 
                card.Strength = s;
                card.Defense = s;
                card.Mana_Cost = m;
                Card.Save(card);
                MessageBox.Show("Saved");
            }
        }

        private void loadCard_Click(object sender, RoutedEventArgs e)
        {
            CardBrowser window = new CardBrowser();
            window.Show();
        }
    }
}