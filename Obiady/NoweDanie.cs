using System;
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
    public partial class NoweDanie : Form
    {
        public NoweDanie()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK(object sender, EventArgs e)
        {
            if (kategoria.SelectedIndex != -1)
                this.Close();   
        }

        private void NoweDanie_Load(object sender, EventArgs e)
        {
            nazwa.Focus();
            if (kategoria.Enabled == false)
                przyciskDodawania.Enabled = true;
        }

        private void SelectionChange(object sender, EventArgs e)
        {
            przyciskDodawania.Enabled = true;
        }
    }
}
