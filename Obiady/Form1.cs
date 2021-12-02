using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Obiady
{
    public partial class Form1 : Form
    {
        List<Danie> dania;
        List<Dodatek> dodatki;
        bool rosnaco;
        static double max = 0;
        public Form1()
        {
            InitializeComponent();
            dania = new List<Danie>();
            dodatki = new List<Dodatek>();
        }

        private void Koniec(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WczytajDania();
            WczytajDodatki();

            PokazDania();
            PokazDodatki();
            rosnaco = true;
            max = 0;
            //Danie d1 = new Danie("Kurczak z grilla", 1, 2);
            //Danie d2 = new Danie("Rosół z kury", 1, 3);
            //Danie d3 = new Danie("Zapiekanka z ryżu na wołowinie", 0, 2);
            //Danie d4 = new Danie("Zapiekanka z ryżu na filecie drobiowym", 0, 1);
            //Dodatek do1 = new Dodatek("ziemniaki", 1, 2);
            //Dodatek do2 = new Dodatek("kasza gryczana", 1, 2);
            //Dodatek do3 = new Dodatek("mizeria", 0, 2);
            //dania.Add(d1);
            //dania.Add(d2);
            //dania.Add(d3);
            //dania.Add(d4);
            //dodatki.Add(do1);
            //dodatki.Add(do2);
            //dodatki.Add(do3);
            PokazDania();
            PokazDodatki();
        }

        private void PokazDodatki()
        {
            max = 0;
            foreach (Danie d in dania)
            {
                ListViewItem it = new ListViewItem(d.nazwa);
                it.SubItems.Add(d.kategoria);
                it.SubItems.Add(d.ileRazy.ToString());
                it.SubItems.Add(d.priorytet.ToString());
                listaDan.Items.Add(it);
                if (d.ileRazy > max)
                    max = d.ileRazy;
            }
        }
        private void PokazDania()
        {
            max = 0;
            foreach (Dodatek d in dodatki)
            {
                ListViewItem it = new ListViewItem(d.nazwa);
                it.SubItems.Add(d.ileRazy.ToString());
                it.SubItems.Add(d.priorytet.ToString());
                listaDodatkow.Items.Add(it);
                listaDan.ListViewItemSorter = new ListViewItemComparer(-1, rosnaco);
                if (d.ileRazy > max)
                    max = d.ileRazy;
            }
        }

        private void WczytajDodatki()
        {
            FileStream fs = new FileStream("dodatki.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Dodatek>));
            dodatki = (List<Dodatek>)xs.Deserialize(fs);
            fs.Close();
        }

        private void WczytajDania()
        {
            FileStream fs = new FileStream("dania.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Danie>));
            dania = (List<Danie>)xs.Deserialize(fs);
            fs.Close();
        }

        private void ZwiekszIleRazy(object sender, EventArgs e)
        {
            if (listaDan.SelectedItems.Count == 0)
                return;
            string nazwa = listaDan.SelectedItems[0].Text;
            foreach (Danie danie in dania)
                if (danie.nazwa.Equals(nazwa))
                {
                    danie.ileRazy++;
                    ListViewItem it = listaDan.SelectedItems[0];
                    it.SubItems[2].Text = danie.ileRazy.ToString();
                }

        }

        private void Zapisz(object sender, EventArgs e)
        {
            ZapiszDania();
            ZapiszDodatki();
        }

        private void ZapiszDodatki()
        {
            FileStream fs = new FileStream("dodatki.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Dodatek>));
            xs.Serialize(fs, dodatki);
            fs.Close();
        }

        private void ZapiszDania()
        {
            FileStream fs = new FileStream("dania.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Danie>));
            xs.Serialize(fs, dania);
            fs.Close();
        }

        private void DodajDanie(object sender, EventArgs e)
        {
            NoweDanie nowe = new NoweDanie();
            nowe.Text = "Nowe danie";
            nowe.kategoria.Enabled = true;
            DialogResult res = nowe.ShowDialog();
            if (res == DialogResult.OK)
            {
                int prior = (int)nowe.priorytet.Value;
                Danie d = new Danie(nowe.nazwa.Text, 0, prior, nowe.kategoria.SelectedItem.ToString());
                dania.Add(d);
                ListViewItem it = new ListViewItem(nowe.nazwa.Text);
                it.SubItems.Add(nowe.kategoria.SelectedItem.ToString());
                it.SubItems.Add("0");
                it.SubItems.Add(prior.ToString());
                listaDan.Items.Add(it);
            }
        }

        private void DodajDodatek(object sender, EventArgs e)
        {
            NoweDanie nowe = new NoweDanie();
            nowe.Text = "Nowy dodatek";
            nowe.kategoria.Enabled = false;
            DialogResult res = nowe.ShowDialog();
            if (res == DialogResult.OK)
            {
                int prior = (int)nowe.priorytet.Value;
                Dodatek d = new Dodatek(nowe.nazwa.Text, 0, prior);
                dodatki.Add(d);
                ListViewItem it = new ListViewItem(nowe.nazwa.Text);
                it.SubItems.Add("0");
                it.SubItems.Add(prior.ToString());
                listaDodatkow.Items.Add(it);
            }
        }
        private void OnClickColumn(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {	//kliknięcie na nagłówek kolumny
            rosnaco = !rosnaco;
            //ListViewItemComparer jest metodą, która dostarcza porównania wskazanej kolumny
            listaDan.ListViewItemSorter = new ListViewItemComparer(e.Column, rosnaco);
        }
        // porównywacz dla listy dań
        class ListViewItemComparer : IComparer
        {	//klasa dostarczająca funkcję porównującą dwa elementy
            private int col;
            private bool ascending;
            public ListViewItemComparer() { col = 0; }
            public ListViewItemComparer(int column) { col = column; }
            public ListViewItemComparer(int column, bool ascending)
            {
                col = column;
                this.ascending = ascending;
            }
            public int Compare(object x, object y)
            {
                if (col == -1)
                {
                    int a1 = int.Parse(((ListViewItem)x).SubItems[2].Text) + 1; // ile razy
                    int a2 = int.Parse(((ListViewItem)y).SubItems[2].Text) + 1; // ile razy
                    int b1 = int.Parse(((ListViewItem)x).SubItems[3].Text); // priorytet
                    int b2 = int.Parse(((ListViewItem)y).SubItems[3].Text); // priorytet
                    double da1 = (max + 1 - a1) * (b1) - b1;
                    double da2 = (max + 1 - a2) * (b2) - b2;
                    if (da1 < da2)
                        return 1;
                    else
                        return -1;
                }
                if (col == 0 || col == 1)
                {
                    if (ascending)
                        return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    else
                        return -String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
                else
                {
                    int a1 = int.Parse(((ListViewItem)x).SubItems[col].Text);
                    int a2 = int.Parse(((ListViewItem)y).SubItems[col].Text);
                    if (ascending)
                    {
                        if (a1 >= a2)
                            return 1;
                        else
                            return 0;
                    }
                    else
                    {
                        if (a2 >= a1)
                            return 1;
                        else
                            return 0;
                    }
                }
            }
        }
        private void OnClickColumn2(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {	//kliknięcie na nagłówek kolumny
            rosnaco = !rosnaco;
            //ListViewItemComparer jest metodą, która dostarcza porównania wskazanej kolumny
            listaDodatkow.ListViewItemSorter = new ListViewItemComparer(e.Column, rosnaco);
        }
        // porównywacz dla listy dodatków
        class ListViewItemComparer2 : IComparer
        {	//klasa dostarczająca funkcję porównującą dwa elementy
            private int col;
            private bool ascending;
            public ListViewItemComparer2() { col = 0; }
            public ListViewItemComparer2(int column) { col = column; }
            public ListViewItemComparer2(int column, bool ascending)
            {
                col = column;
                this.ascending = ascending;
            }
            public int Compare(object x, object y)
            {
                if (col == -1)
                {
                    int a1 = int.Parse(((ListViewItem)x).SubItems[1].Text) + 1; // ile razy
                    int a2 = int.Parse(((ListViewItem)y).SubItems[1].Text) + 1; // ile razy
                    int b1 = int.Parse(((ListViewItem)x).SubItems[2].Text); // priorytet
                    int b2 = int.Parse(((ListViewItem)y).SubItems[2].Text); // priorytet
                    double da1 = (max + 1 - a1) * (b1) - b1;
                    double da2 = (max + 1 - a2) * (b2) - b2;
                    if (da1 < da2)
                        return 1;
                    else
                        return -1;
                }
                if (col == 0 || col == 1)
                {
                    if (ascending)
                        return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    else
                        return -String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
                else
                {
                    int a1 = int.Parse(((ListViewItem)x).SubItems[col].Text);
                    int a2 = int.Parse(((ListViewItem)y).SubItems[col].Text);
                    if (ascending)
                    {
                        if (a1 >= a2)
                            return 1;
                        else
                            return 0;
                    }
                    else
                    {
                        if (a2 >= a1)
                            return 1;
                        else
                            return 0;
                    }
                }
            }
        }

    }
}
