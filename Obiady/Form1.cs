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
        static double maxDania = 0;
        static double maxDodatki = 0;
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
            maxDania = 0;
        }

        private void PokazDania()
        {
            maxDodatki = 0;
            foreach (Danie d in dania)
            {
                ListViewItem it = new ListViewItem(d.nazwa);
                it.SubItems.Add(d.kategoria);
                it.SubItems.Add(d.ileRazy.ToString());
                it.SubItems.Add(d.priorytet.ToString());
                listaDan.Items.Add(it);
                if (d.ileRazy > maxDania)
                    maxDania = d.ileRazy;
                listaDan.ListViewItemSorter = new ListViewItemComparer(-1, rosnaco);
            }
        }
        private void PokazDodatki()
        {
            maxDodatki = 0;
            foreach (Dodatek d in dodatki)
            {
                ListViewItem it = new ListViewItem(d.nazwa);
                it.SubItems.Add(d.ileRazy.ToString());
                it.SubItems.Add(d.priorytet.ToString());
                listaDodatkow.Items.Add(it);
                if (d.ileRazy > maxDodatki)
                    maxDodatki = d.ileRazy;
                listaDodatkow.ListViewItemSorter = new ListViewItemComparer2(-1, rosnaco);
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
                    double da1 = (a1 - maxDodatki) - b1 * (a1 + 0.3) / 3;
                    double da2 = (a2 - maxDodatki) - b2 * (a2 + 0.3) / 3;
                    if (da1 >= da2)
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
                        if (a1 < a2)
                            return 1;
                        else
                            return 0;
                    }
                    else
                    {
                        if (a2 >= a1)
                            return 1;
                        else
                            return -1;
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
                    double da1 = (a1 - maxDodatki) - b1 * (a1 + 0.3)/3;
                    double da2 = (a2 - maxDodatki) - b2 * (a2 + 0.3)/3;
                    if (da1 >= da2)
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

        private void EdycjaDania(object sender, EventArgs e)
        {
            if (listaDan.SelectedItems.Count == 0)
                return;
            string nazwa = listaDan.SelectedItems[0].Text;
            NoweDanie edycja = new NoweDanie();
            edycja.Text = "Edycja dania";
            edycja.kategoria.Enabled = true;
            edycja.nazwa.Text = nazwa;
            string kategoria = listaDan.SelectedItems[0].SubItems[1].Text;
            int prior = int.Parse(listaDan.SelectedItems[0].SubItems[3].Text);
            edycja.priorytet.Value = prior;
            for(int i = 0; i < edycja.kategoria.Items.Count; i++)
                if (edycja.kategoria.Items[i].ToString().Equals(kategoria))
                {
                    edycja.kategoria.SelectedIndex = i;
                    break;
                }
            DialogResult res = edycja.ShowDialog();
            if (res == DialogResult.OK)
            {
                listaDan.SelectedItems[0].Text = edycja.nazwa.Text;
                if (edycja.kategoria.SelectedItem != null)
                    listaDan.SelectedItems[0].SubItems[1].Text = edycja.kategoria.SelectedItem.ToString();
                listaDan.SelectedItems[0].SubItems[3].Text = edycja.priorytet.Value.ToString();
                for(int i = 0; i < dania.Count; i++)
                    if (dania[i].nazwa.Equals(nazwa))
                    {
                        dania[i].nazwa = listaDan.SelectedItems[0].Text;
                        dania[i].priorytet = (int)edycja.priorytet.Value;
                        if (edycja.kategoria.SelectedItem != null)
                            dania[i].kategoria = edycja.kategoria.SelectedItem.ToString();
                    }
            }
        }

        private void ZwiekszIleRazy2(object sender, EventArgs e)
        {
            if (listaDodatkow.SelectedItems.Count == 0)
                return;
            string nazwa = listaDodatkow.SelectedItems[0].Text;
            foreach (Dodatek dodatek in dodatki)
                if (dodatek.nazwa.Equals(nazwa))
                {
                    dodatek.ileRazy++;
                    ListViewItem it = listaDodatkow.SelectedItems[0];
                    it.SubItems[1].Text = dodatek.ileRazy.ToString();
                }
        }
    }
}
