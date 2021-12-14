using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obiady
{
    public partial class Okienko : Form
    {
        public Okienko()
        {
            InitializeComponent();
        }

        public Okienko(string tytuł, string linia1, string linia2)
        {
            InitializeComponent();
            this.Text = tytuł;
            this.Linia1.Text = linia1;
            this.Linia2.Text = linia2;
            Application.DoEvents();

        }

        private void Okienko_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(Metoda));
            thread.Start();
        }
        public void Metoda()
        {
            int ile = 0;
            double x;
            Thread.Sleep(800);
            Etykieta:
            x = this.Opacity;
            Thread.Sleep(100 - ile);
            if (x >= 0.03)
                this.Opacity = x - 0.02;
            else
            {
                this.Dispose();
            }
            ile++;
            goto Etykieta;
        }
    }
}

