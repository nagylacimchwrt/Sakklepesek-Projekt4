﻿using System;
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
        Button[,] mezok;
        Babu currentBabu;
        Babu feherGyalog;
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

            
            //Fehér gyalog bábú
            List<int> kezdoHely = new List<int>();
            kezdoHely.Add(3);
            kezdoHely.Add(3);

            List<List<int>> lepesekLista = new List<List<int>>();
            List<int> lepes1 = new List<int>();

            List<int> lepes2 = new List<int>();
            lepes2.Add(-1);
            lepes2.Add(0);
            lepesekLista.Add(lepes2);

            feherGyalog = new Babu(mezok, kezdoHely, lepesekLista, "\u2659");
            currentBabu = feherGyalog;
            szinezGombokat(currentBabu.odaLep);
        }

        private void TablaLetrehozasa()
        {
            tabla.Children.Clear();
            mezok = new Button[meret, meret];
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    Button negyzet = new Button();
                    negyzet.Width = tabla.Width / meret;
                    negyzet.Height = tabla.Height / meret;
                    negyzet.Margin = new Thickness(tabla.Width / meret * j, tabla.Height / meret * i, 0, 0);
                    negyzet.Click += Mozgatas;
                    negyzet.Content = " ";

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
                        mezok[i, j].Background = Brushes.SaddleBrown;
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        mezok[i, j].Background = Brushes.SaddleBrown;
                    }
                    else
                    {
                        mezok[i, j].Background = Brushes.Wheat;
                    }
                }
            }
        }

        public void tablaUjraSzin()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    if (j % 2 == 1 && i % 2 == 1)
                    {
                        mezok[i, j].Background = Brushes.SaddleBrown;
                    }
                    else if (j % 2 == 0 && i % 2 == 0)
                    {
                        mezok[i, j].Background = Brushes.SaddleBrown;
                    }
                    else
                    {
                        mezok[i, j].Background = Brushes.Wheat;
                    }
                }
            }
        }

        public class Babu
        {
            public Button currentButton;
            public string UniCode;
            Button[,] mezok;
            public List<List<int>> lepesekLista;
            public List<List<int>> odaLep;


            public Babu(Button[,] mezok, List<int> kezdoHely, List<List<int>> lepesekLista, string UniCode)
            {
                this.mezok = mezok;
                this.lepesekLista = lepesekLista;
                currentButton = mezok[kezdoHely[0], kezdoHely[1]];
                this.UniCode = UniCode;
                currentButton.Content = UniCode;
                lepesLehetosegek(kezdoHely);
                
            }

            public void Mozgas(List<int> kovihely)
            {
                if (mezok[kovihely[0], kovihely[1]].Content.ToString() != " ") return;
                bool lephet = false;
                foreach (var helyzet in odaLep)
                {
                    if (helyzet[0] == kovihely[0] && helyzet[1] == kovihely[1])
                    {
                        lephet = true;
                    }
                }
                if (!lephet) return;
                
                currentButton.Content = " ";
                currentButton = mezok[kovihely[0], kovihely[1]];
                currentButton.Content = UniCode;
                lepesLehetosegek(kovihely);
            }

            public void lepesLehetosegek(List<int> kezdoHely)
            {
                odaLep = new List<List<int>>();

                for (int i = 0; i < lepesekLista.Count; i++)
                {
                    try
                    {
                        List<int> helyzetek = new List<int>();
                        helyzetek.Add(kezdoHely[0] + lepesekLista[i][0]);
                        helyzetek.Add(kezdoHely[1] + lepesekLista[i][1]);
                        if (mezok[helyzetek[0], helyzetek[1]].Content.ToString() == " ")
                        {
                            odaLep.Add(helyzetek);
                        }
                    }
                    catch(IndexOutOfRangeException)
                    {
                    }
                }
            }

        }

        public void szinezGombokat(List<List<int>> lepesekLista)
        {
            /*if (lepesekLista == null)
            {
                return;
            }*/
            foreach (var helyzet in lepesekLista)
            {
                try
                {
                    mezok[helyzet[0], helyzet[1]].Background = Brushes.Red;
                }
                catch (IndexOutOfRangeException)
                {

                }
            }
        }


        private void Mozgatas(object sender, RoutedEventArgs e)
        {
            /*if (currentBabu == null)
            {
                return;
            }*/
            currentBabu.Mozgas(Index((Button)sender));

            tablaUjraSzin();
            szinezGombokat(currentBabu.odaLep);
        }

        private List<int> Index(Button gomb)
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    if (mezok[i, j] == gomb)
                    {
                        List<int> indexek = new List<int>();
                        indexek.Add(i);
                        indexek.Add(j);

                        return indexek;
                    }
                }
            }
            return null;
        }
    }
}
