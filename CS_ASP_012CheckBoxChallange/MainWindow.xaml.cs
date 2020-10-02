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

namespace CS_ASP_012CheckBoxChallange
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pencil.IsChecked == true)
            {
                Label.Content = "Pencil, old school!";
                Pencilimg.Opacity = 100;
                Penimg.Opacity = 0;
                Phoneimg.Opacity = 0;
                Tabletimg.Opacity = 0;
            }
            if (Pen.IsChecked == true)
            {
                Label.Content = "Pen, smooth!";
                Penimg.Opacity = 100;
                Pencilimg.Opacity = 0;
                Phoneimg.Opacity = 0;
                Tabletimg.Opacity = 0;
            }
            if (Phone.IsChecked == true)
            {
                Label.Content = "Phone, touch screen!";
                Phoneimg.Opacity = 100;
                Pencilimg.Opacity = 0;
                Penimg.Opacity = 0;
                Tabletimg.Opacity = 0;
            }
            if (Tablet.IsChecked == true)
            {
                Label.Content = "Tablet, thats pretty big!";
                Tabletimg.Opacity = 100;
                Pencilimg.Opacity = 0;
                Penimg.Opacity = 0;
                Phoneimg.Opacity = 0;
            }


        }
    }
}
