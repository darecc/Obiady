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
using static System.Windows.Forms.ListViewItem;

namespace Obiady
{
    public partial class Form1 : Form
    {
        List<Dish> dania;
        List<SideDish> dodatki;
        List<Ingredient> ingredients;
        bool rosnaco;
        static double maxDania = 0;
        static double maxDodatki = 0;
        public Form1()
        {
            InitializeComponent();
            dania = new List<Dish>();
            dodatki = new List<SideDish>();
        }

        private void Koniec(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + Application.ProductVersion + " (" + Application.CompanyName + ")";
            ReadDishes();
            ReadSideDishes();
            ReadIngredients();
            ShowDishes();
            ShowSideDishes();
            refreshStrip();

            rosnaco = false;
            maxDania = 0;
         }

        private void refreshStrip()
        {
            statusLabel.Text = "dania : " + dania.Count.ToString() + "  dodatki: " + dodatki.Count.ToString();
        }

        private void ShowDishes()
        {
            maxDodatki = 0;
            foreach (Dish d in dania)
            {
                AddDishToList(d);
                if (d.count > maxDania)
                    maxDania = d.count;
                listaDan.ListViewItemSorter = new ListViewItemComparer(-1, rosnaco);
            }
        }

        private void AddDishToList(Dish d)
        {
            ListViewItem it = new ListViewItem(d.name);
            it.SubItems.Add(d.category);
            it.SubItems.Add(d.count.ToString());
            it.SubItems.Add(d.priority.ToString());
            if (d.ingredients.Count > 0)
            {
                it.ForeColor = Color.Brown;
                it.BackColor = Color.Azure;
            }
            listaDan.Items.Add(it);
        }

        private void ShowSideDishes()
        {
            maxDodatki = 0;
            foreach (SideDish d in dodatki)
            {
                ListViewItem it = new ListViewItem(d.name);
                it.SubItems.Add(d.count.ToString());
                it.SubItems.Add(d.priority.ToString());
                listaDodatkow.Items.Add(it);
                if (d.count > maxDodatki)
                    maxDodatki = d.count;
                listaDodatkow.ListViewItemSorter = new ListViewItemComparer2(-1, rosnaco);
            }
        }

        private void ReadSideDishes()
        {
            FileStream fs = new FileStream("dodatki.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<SideDish>));
            dodatki = (List<SideDish>)xs.Deserialize(fs);
            fs.Close();
        }

        private void ReadDishes()
        {
            FileStream fs = new FileStream("dania.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Dish>));
            dania = (List<Dish>)xs.Deserialize(fs);
            fs.Close();
        }

        private void ReadIngredients()
        {
            FileStream fs = new FileStream("ingredients.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Ingredient>));
            ingredients = (List<Ingredient>)xs.Deserialize(fs);
            fs.Close();
        }

        private void IncreaseCounts(object sender, EventArgs e)
        {
            if (listaDan.SelectedItems.Count == 0)
                return;
            string nazwa = listaDan.SelectedItems[0].Text;
            foreach (Dish danie in dania)
                if (danie.name.Equals(nazwa))
                {
                    danie.count++;
                    ListViewItem it = listaDan.SelectedItems[0];
                    it.SubItems[2].Text = danie.count.ToString();
                }
        }

        private void WriteAll(object sender, EventArgs e)
        {
            WriteDishes();
            WriteSideDishes();
            WriteIngredients();
        }

        private void WriteSideDishes()
        {
            FileStream fs = new FileStream("dodatki.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<SideDish>));
            xs.Serialize(fs, dodatki);
            fs.Close();
        }

        private void WriteIngredients()
        {
            FileStream fs = new FileStream("ingredients.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Ingredient>));
            xs.Serialize(fs, ingredients);
            fs.Close();
        }

        private void WriteDishes()
        {
            FileStream fs = new FileStream("dania.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Dish>));
            xs.Serialize(fs, dania);
            fs.Close();
        }

        private void AddDish(object sender, EventArgs e)
        {
            NoweDanie nowe = new NoweDanie();
            nowe.Text = "Nowe danie";
            nowe.kategoria.Enabled = true;
            nowe.skladniki.Enabled = true;
            nowe.przyciskDodawania.Enabled = false;
            DialogResult res = nowe.ShowDialog();
            if (res == DialogResult.OK)
            {
                int prior = (int)nowe.priorytet.Value;
                Dish d = new Dish(nowe.nazwa.Text, 0, prior, nowe.kategoria.SelectedItem.ToString());
                string skladniki = nowe.skladniki.Text;
                d.ingredients = new List<string>();
                string[] linie = skladniki.Split(System.Environment.NewLine);
                d.ingredients = new List<string>();
                foreach (string s in linie)
                    d.ingredients.Add(s);
                dania.Add(d);
                ListViewItem it = new ListViewItem(nowe.nazwa.Text);
                it.SubItems.Add(nowe.kategoria.SelectedItem.ToString());
                it.SubItems.Add("0");
                it.SubItems.Add(prior.ToString());
                if (linie.Length > 0)
                {
                    it.ForeColor = Color.Brown;
                    it.BackColor = Color.Coral;
                }
                listaDan.Items.Add(it);
                refreshStrip();
            }
        }

        private void AddSideDish(object sender, EventArgs e)
        {
            NoweDanie nowe = new NoweDanie();
            nowe.Text = "Nowy dodatek";
            nowe.kategoria.Enabled = false;
            nowe.skladniki.Enabled = true;
            nowe.przyciskDodawania.Enabled = true;
            DialogResult res = nowe.ShowDialog();
            if (res == DialogResult.OK)
            {
                int prior = (int)nowe.priorytet.Value;
                SideDish d = new SideDish(nowe.nazwa.Text, 0, prior);
                dodatki.Add(d);
                ListViewItem it = new ListViewItem(nowe.nazwa.Text);
                //TODO: napisać redagowanie składników
                it.SubItems.Add("0");
                it.SubItems.Add(prior.ToString());
                listaDodatkow.Items.Add(it);
                refreshStrip();
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

        private void EditDish(object sender, EventArgs e)
        {
            if (listaDan.SelectedItems.Count == 0)
                return;
            string nazwa = listaDan.SelectedItems[0].Text;
            NoweDanie edycja = new NoweDanie();
            edycja.Text = "Edycja dania";
            edycja.kategoria.Enabled = true;
            edycja.skladniki.Enabled = true;
            edycja.nazwa.Text = nazwa;
            Dish danie = null;
            foreach (Dish d in dania)
                if (d.name.Equals(nazwa))
                    danie = d;
            foreach (string s in danie.ingredients)
                edycja.skladniki.Text = edycja.skladniki.Text + s + System.Environment.NewLine;
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
                    if (dania[i].name.Equals(nazwa))
                    {
                        dania[i].name = listaDan.SelectedItems[0].Text;
                        dania[i].priority = (int)edycja.priorytet.Value;
                        if (edycja.kategoria.SelectedItem != null)
                            dania[i].category = edycja.kategoria.SelectedItem.ToString();
                        string skladniki = edycja.skladniki.Text;
                        string[] linie = skladniki.Split(System.Environment.NewLine);
                        if (linie.Length > 0)
                            listaDan.SelectedItems[0].BackColor = Color.Coral;
                        dania[i].ingredients = new List<string>();
                        foreach (string s in linie)
                            dania[i].ingredients.Add(s);
                    }
            }
        }

        private void ZwiekszIleRazy2(object sender, EventArgs e)
        {
            if (listaDodatkow.SelectedItems.Count == 0)
                return;
            string nazwa = listaDodatkow.SelectedItems[0].Text;
            foreach (SideDish dodatek in dodatki)
                if (dodatek.name.Equals(nazwa))
                {
                    dodatek.count++;
                    ListViewItem it = listaDodatkow.SelectedItems[0];
                    it.SubItems[1].Text = dodatek.count.ToString();
                }
        }

        private void EdytujSkladniki(object sender, EventArgs e)
        {
            EditIngredients edycja = new EditIngredients();
            edycja.ingredients = ingredients;
            DialogResult res = edycja.ShowDialog();
            if (res == DialogResult.OK)
            {
                ingredients = edycja.ingredients;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string napis = cSideDishfilter.Text;
            if (napis.Length < 3)
            {
                return;
            }
            else
            {
                cSideDishfilter.Items.Add(napis);
                OdfiltrujDodatki();
            }
        }

        private void OdfiltrujDodatki()
        {
            listaDodatkow.Items.Clear();
            foreach(SideDish s in dodatki)
            {
                bool tak = true;
                //TODO: odfiltrowanie dodatków w pętli for do tych, które posiadają składniki z cSideDishFilter
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string napis = cDishFilter.Text;
            if (napis.Length < 3)
            {
                return;
            }
            else
            {
                if (cDishFilter.Items.Contains(napis) == false)
                {
                    cDishFilter.Items.Add(napis);
                    OdfiltrujDania();
                }
            }
            cDishFilter.Text = "";
        }

        private void OdfiltrujDania()
        {
            listaDan.Items.Clear();
            foreach (Dish s in dania)
            {
                bool tak = true;
                foreach (string skladnik in cDishFilter.Items)
                    if (s.ingredients.Contains(skladnik) == false)
                        tak = false;
                if (tak == true) 
                {
                    AddDishToList(s);  
                }
            }
        }

        private void RemoveFromList(object sender, EventArgs e)
        {
            int index = cDishFilter.SelectedIndex;
            if (index != -1)
            {
                cDishFilter.Items.RemoveAt(index);
                OdfiltrujDania();
            }
        }

        private void EditSideDish(object sender, EventArgs e)
        {
            //TODO: napisać edycję Dodatku z możliwością redagowania składników
        }
    }
}
