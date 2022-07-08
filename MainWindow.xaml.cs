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

namespace Laboratoire5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuItems Menu;
        public MainWindow()
        {
            InitializeComponent();
            InitialiseMenu();
            InitialiseGrille();
        }

        private void InitialiseMenu()
        {
            this.Menu = new MenuItems();

            Item i1 = new Item(1, "Canne de sauce", 32.75, "images/i1.jpg");
            Item i2 = new Item(2, "Soupe de tofu", 45.67, "images/i2.jpg");
            Item i3 = new Item(3, "Poulet", 1.54, "images/i3.jpg");
            Item i4 = new Item(4, "Patates", 176.32, "images/i4.jpg");
            Item i5 = new Item(5, "Spaghetti", 23.23, "images/i5.jpg");
            Item i6 = new Item(6, "Borgor", 76.32, "images/i6.jpg");

            this.Menu.AjouterItem(i1);
            this.Menu.AjouterItem(i2);
            this.Menu.AjouterItem(i3);
            this.Menu.AjouterItem(i4);
            this.Menu.AjouterItem(i5);
            this.Menu.AjouterItem(i6);
        }

        private void InitialiseGrille()
        {
            Button b1 = new Button();
            Image i1 = new Image();

            i1.Source = new BitmapImage(new Uri("C:\\Users\\pdess\\source\\repos\\Laboratoire5\\images\\i6.jpeg", UriKind.Absolute));

            b1.Content = i1;

            Grid.SetColumn(b1, 2);
            Grid.SetRow(b1, 1);

            GrilleMenu.Children.Add(b1);
        }
    }
}
