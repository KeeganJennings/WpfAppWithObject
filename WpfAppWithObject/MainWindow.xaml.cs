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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppWithObject;


namespace WpfAppWithObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dragon d;
        public MainWindow()
        {
            InitializeComponent();
            d = new Dragon();
            hordeTB.Text = "Horde: " + d.horde;
            staminaTB.Text = "Stamina: " + d.stamina;
        }

        private void RaidBTN_Click(object sender, RoutedEventArgs e)
        {
            d.Raid();
            UpdateTextBoxes();
        }

        private void RestBTN_Click(object sender, RoutedEventArgs e)
        {
            d.Rest();
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            hordeTB.Text = "Horde: " + d.horde;
            staminaTB.Text = "Stamina: " + d.stamina;
        }
    }
}
