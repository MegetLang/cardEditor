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
using System.Windows.Shapes;

namespace Card_Editor
{
    /// <summary>
    /// Interaction logic for CardBrowser.xaml
    /// </summary>
    public partial class CardBrowser : Window
    {
        public CardBrowser()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            if (dc.DatabaseExists())
            {
                cardGrid.ItemsSource = dc.Cards;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
