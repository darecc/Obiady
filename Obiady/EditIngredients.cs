using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obiady
{
    public partial class EditIngredients : Form
    {
        bool rosnaco;
        public List<Ingredient> ingredients;
        public EditIngredients()
        {
            InitializeComponent();
        }

        private void EditIngredients_Load(object sender, EventArgs e)
        {
            foreach(Ingredient ing in ingredients)
            {
                ListViewItem it = new ListViewItem(ing.name);
                it.SubItems.Add(ing.category);
                ingredientsList.Items.Add(it);
            }
            rosnaco = false;
            this.AcceptButton = button3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingredient i1 = new Ingredient(nazwa.Text, kategoria.Text);
            ingredients.Add(i1);
            ListViewItem it = new ListViewItem(nazwa.Text);
            it.SubItems.Add(kategoria.Text);
            ingredientsList.Items.Add(it);
            nazwa.Text = "";
            nazwa.Focus();
        }
        private void OnClickColumn(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {	//kliknięcie na nagłówek kolumny
            rosnaco = !rosnaco;
            //ListViewItemComparer jest metodą, która dostarcza porównania wskazanej kolumny
            ingredientsList.ListViewItemSorter = new ListViewItemComparer(e.Column, rosnaco);
        }

        // porównywacz dla listy składników
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
                    if (ascending)
                        return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    else
                        return -String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}
