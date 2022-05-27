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
        Button[,] mezok;
        Babu currentBabu;
        Babu feherGyalog;
        Babu feketeGyalog;
        Babu lo;
        Babu Bastya;
        Babu Futo;
        Babu Kiraly;
        Babu kiralyNo;

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

            
            //---Fehér gyalog bábú---
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
            //<------------------------------------->


            //---Fekete gyalog bábú---
            List<int> feketeGyalogHelye = new List<int>();
            feketeGyalogHelye.Add(4);
            feketeGyalogHelye.Add(5);

            List<List<int>> feketeGyalogLista = new List<List<int>>();
            List<int> feketeLepes = new List<int>();
            feketeLepes.Add(-1);
            feketeLepes.Add(0);
            feketeGyalogLista.Add(feketeLepes);

            feketeGyalog = new Babu(mezok, feketeGyalogHelye, feketeGyalogLista, "\u265F");
            //<------------------------------------->


            //---Ló bábú---
            List<int> loHelye = new List<int>();
            loHelye.Add(5);
            loHelye.Add(5);

            List<List<int>> loLepes = new List<List<int>>();
            List<int> lepes3 = new List<int>();
            lepes3.Add(2);
            lepes3.Add(-1);
            loLepes.Add(lepes3);
            List<int> lepes4 = new List<int>();
            lepes4.Add(2);
            lepes4.Add(1);
            loLepes.Add(lepes4);

            List<int> lepes5 = new List<int>();
            lepes5.Add(-2);
            lepes5.Add(-1);
            loLepes.Add(lepes5);
            List<int> lepes6 = new List<int>();
            lepes6.Add(-2);
            lepes6.Add(1);
            loLepes.Add(lepes6);

            List<int> lepes7 = new List<int>();
            lepes7.Add(1);
            lepes7.Add(-2);
            loLepes.Add(lepes7);
            List<int> lepes8 = new List<int>();
            lepes8.Add(1);
            lepes8.Add(2);
            loLepes.Add(lepes8);
            List<int> lepes9 = new List<int>();
            lepes9.Add(-1);
            lepes9.Add(-2);
            loLepes.Add(lepes9);
            List<int> lepes10 = new List<int>();
            lepes10.Add(-1);
            lepes10.Add(2);
            loLepes.Add(lepes10);

            lo = new Babu(mezok, loHelye, loLepes, "\u265E");
            //<------------------------------------->


            //---Bástya bábú---
            List<int> bastyaHelye = new List<int>();
            bastyaHelye.Add(4);
            bastyaHelye.Add(2);

            List<List<int>> bastyaLepesLista = new List<List<int>>();
            for (int i = 1; i <= 8; i++)
            {
                List<int> bastyaLepes = new List<int>();
                bastyaLepes.Add(i);
                bastyaLepes.Add(0);
                bastyaLepesLista.Add(bastyaLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> bastyaLepes = new List<int>();
                bastyaLepes.Add(-i);
                bastyaLepes.Add(0);
                bastyaLepesLista.Add(bastyaLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> bastyaLepes = new List<int>();
                bastyaLepes.Add(0);
                bastyaLepes.Add(i);
                bastyaLepesLista.Add(bastyaLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> bastyaLepes = new List<int>();
                bastyaLepes.Add(0);
                bastyaLepes.Add(-i);
                bastyaLepesLista.Add(bastyaLepes);
            }

            Bastya = new Babu(mezok, bastyaHelye, bastyaLepesLista, "\u265C");
            //<------------------------------------->



            //---Futó bábú---
            List<int> futoHelye = new List<int>();
            futoHelye.Add(7);
            futoHelye.Add(3);

            List<List<int>> futoLepesLista = new List<List<int>>();
            for (int i = 1; i <= 8; i++)
            {
                List<int> futoLepes = new List<int>();
                futoLepes.Add(i);
                futoLepes.Add(i);
                futoLepesLista.Add(futoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> futoLepes = new List<int>();
                futoLepes.Add(-i);
                futoLepes.Add(-i);
                futoLepesLista.Add(futoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> futoLepes = new List<int>();
                futoLepes.Add(i);
                futoLepes.Add(-i);
                futoLepesLista.Add(futoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> futoLepes = new List<int>();
                futoLepes.Add(-i);
                futoLepes.Add(i);
                futoLepesLista.Add(futoLepes);
            }
            Futo = new Babu(mezok, futoHelye, futoLepesLista, "\u265D");
            //<------------------------------------->


            //---Király bábú---
            List<int> kiralyHelye = new List<int>();
            kiralyHelye.Add(4);
            kiralyHelye.Add(3);

            List<List<int>> kiralyLepesLista = new List<List<int>>();
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(i);
                kiralyLepes.Add(0);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(-i);
                kiralyLepes.Add(0);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(0);
                kiralyLepes.Add(i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(0);
                kiralyLepes.Add(-i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(i);
                kiralyLepes.Add(i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(-i);
                kiralyLepes.Add(-i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(i);
                kiralyLepes.Add(-i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            for (int i = 1; i <= 1; i++)
            {
                List<int> kiralyLepes = new List<int>();
                kiralyLepes.Add(-i);
                kiralyLepes.Add(i);
                kiralyLepesLista.Add(kiralyLepes);
            }
            Kiraly = new Babu(mezok, kiralyHelye, kiralyLepesLista, "\u265A");
            //<------------------------------------->


            //---Királynő bábú---
            List<int> kiralyNoHelye = new List<int>();
            kiralyNoHelye.Add(2);
            kiralyNoHelye.Add(7);

            List<List<int>> kiralyNoLepesLista = new List<List<int>>();
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(i);
                kiralyNoLepes.Add(0);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(-i);
                kiralyNoLepes.Add(0);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(0);
                kiralyNoLepes.Add(i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(0);
                kiralyNoLepes.Add(-i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }

            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(i);
                kiralyNoLepes.Add(i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(-i);
                kiralyNoLepes.Add(-i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(i);
                kiralyNoLepes.Add(-i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            for (int i = 1; i <= 8; i++)
            {
                List<int> kiralyNoLepes = new List<int>();
                kiralyNoLepes.Add(-i);
                kiralyNoLepes.Add(i);
                kiralyNoLepesLista.Add(kiralyNoLepes);
            }
            kiralyNo = new Babu(mezok, kiralyNoHelye, kiralyNoLepesLista, "\u265B");
            //<------------------------------------->

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

        private void babuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (babuComboBox.SelectedItem.ToString() == "Fehér Gyalog")
            {
                currentBabu = feherGyalog;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Fekete Gyalog")
            {
                currentBabu = feketeGyalog;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Ló")
            {
                currentBabu = lo;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Bástya")
            {
                currentBabu = Bastya;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Futó")
            {
                currentBabu = Futo;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Király")
            {
                currentBabu = Kiraly;
            }
            else if (babuComboBox.SelectedItem.ToString() == "Királynő")
            {
                currentBabu = kiralyNo;
            }
            currentBabu.lepesLehetosegek(Index(currentBabu.currentButton));
            tablaUjraSzin();
            szinezGombokat(currentBabu.odaLep);
        }
    }
}
