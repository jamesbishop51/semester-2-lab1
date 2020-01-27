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
using System.Collections.ObjectModel;

namespace lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
        

    public partial class MainWindow : Window
    {
        static Random r = new Random();
        public ObservableCollection<Band> AllBands;
        public ObservableCollection<Band> SelectedBand;


        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RockBand r1 = new RockBand("Guns N'Roses", 1985, "Axl Rose, Duff McKagan, Slash, Dizzy Reed.");
            RockBand r2 = new RockBand("the beatles", 1960, "John Lennon, Paul McCartney, George Harrison, Pete Best. ");

            IndieBand i1 = new IndieBand("Arctic Monkeys",2002, "Alex Turner, Matt Helders, Jamie Cook, Nick O'Malley, Andy Nicholson, Glyn Jones.");
            IndieBand i2 = new IndieBand("The Killers",2001, "Brandon Flowers, Dave Keuning, Mark Stoermer.");

            PopBand p1 = new PopBand("Green Day",1986, "Billie Joe Armstrong, Tré Cool, Mike Dirnt, Jason White, Raj Punjabi, John Kiffmeyer, Sean Hughes.");
            PopBand p2 = new PopBand("Maroon 5",2001, "Adam Levine, James Valentine, PJ Morton, Mickey Madden, Jesse Carmichael, Matt Flynn, Sam Farrar, Ryan Dusick");

        }
    }
}
