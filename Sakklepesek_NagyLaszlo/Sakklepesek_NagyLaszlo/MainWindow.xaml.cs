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

namespace Sakklepesek_NagyLaszlo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int meret = 8;
        Rectangle[,] mezok;
        public MainWindow()
        {
            InitializeComponent();
            TablaLetrehozasa();

            babuComboBox.Items.Add("Fehér Gyalog");
            babuComboBox.Items.Add("Fekete Gyalog");
            babuComboBox.Items.Add("Ló");
            babuComboBox.Items.Add("Bástya");
            babuComboBox.Items.Add("Futó");
            babuComboBox.Items.Add("Király");
            babuComboBox.Items.Add("Királynő");
        }

        private void TablaLetrehozasa()
        {
            tabla.Children.Clear();
            mezok = new Rectangle[meret, meret];
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    Rectangle negyzet = new Rectangle();
                    negyzet.Width = tabla.Width / meret;
                    negyzet.Height = tabla.Height / meret;
                    negyzet.Margin = new Thickness(tabla.Width / meret * j, tabla.Height / meret * i, 0, 0);

                    tabla.Children.Add(negyzet);
                    mezok[i, j] = negyzet;
                }
            }
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    
                    if (j % 2 == 1 && i % 2 == 1)
                    {
                        mezok[i, j].Fill = Brushes.SaddleBrown;
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        mezok[i, j].Fill = Brushes.SaddleBrown;
                    }
                    else
                    {
                        mezok[i, j].Fill = Brushes.Wheat;
                    }
                }
            }
        }
    }
}
