
namespace Obiady
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaDan = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaDodatkow = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDodatekStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaDaniaStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaDodatkuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.cSideDishFilter = new System.Windows.Forms.ComboBox();
            this.cDishFilter = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDan
            // 
            this.listaDan.AllowColumnReorder = true;
            this.listaDan.BackColor = System.Drawing.Color.GhostWhite;
            this.listaDan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.listaDan.FullRowSelect = true;
            this.listaDan.HideSelection = false;
            this.listaDan.Location = new System.Drawing.Point(12, 66);
            this.listaDan.Name = "listaDan";
            this.listaDan.Size = new System.Drawing.Size(987, 365);
            this.listaDan.TabIndex = 0;
            this.listaDan.UseCompatibleStateImageBehavior = false;
            this.listaDan.View = System.Windows.Forms.View.Details;
            this.listaDan.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnClickColumn);
            this.listaDan.DoubleClick += new System.EventHandler(this.IncreaseCounts);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 600;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kategoria";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ile razy";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Priorytet";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obiad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dodatki";
            // 
            // listaDodatkow
            // 
            this.listaDodatkow.BackColor = System.Drawing.Color.FloralWhite;
            this.listaDodatkow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaDodatkow.HideSelection = false;
            this.listaDodatkow.Location = new System.Drawing.Point(12, 469);
            this.listaDodatkow.Name = "listaDodatkow";
            this.listaDodatkow.Size = new System.Drawing.Size(987, 219);
            this.listaDodatkow.TabIndex = 3;
            this.listaDodatkow.UseCompatibleStateImageBehavior = false;
            this.listaDodatkow.View = System.Windows.Forms.View.Details;
            this.listaDodatkow.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnClickColumn2);
            this.listaDodatkow.DoubleClick += new System.EventHandler(this.ZwiekszIleRazy2);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nazwa";
            this.columnHeader4.Width = 800;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ile razy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Priorytet";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.dodajDodatekStripMenuItem1,
            this.edycjaDaniaStripMenuItem1,
            this.edycjaDodatkuToolStripMenuItem1,
            this.ingredientsStripMenuItem1,
            this.koniecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.WriteAll);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.dodajToolStripMenuItem.Text = "Dodaj danie";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.AddDish);
            // 
            // dodajDodatekStripMenuItem1
            // 
            this.dodajDodatekStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dodajDodatekStripMenuItem1.Name = "dodajDodatekStripMenuItem1";
            this.dodajDodatekStripMenuItem1.Size = new System.Drawing.Size(107, 21);
            this.dodajDodatekStripMenuItem1.Text = "Dodaj dodatek";
            this.dodajDodatekStripMenuItem1.Click += new System.EventHandler(this.AddSideDish);
            // 
            // edycjaDaniaStripMenuItem1
            // 
            this.edycjaDaniaStripMenuItem1.Name = "edycjaDaniaStripMenuItem1";
            this.edycjaDaniaStripMenuItem1.Size = new System.Drawing.Size(91, 21);
            this.edycjaDaniaStripMenuItem1.Text = "Edytuj danie";
            this.edycjaDaniaStripMenuItem1.Click += new System.EventHandler(this.EditDish);
            // 
            // edycjaDodatkuToolStripMenuItem1
            // 
            this.edycjaDodatkuToolStripMenuItem1.Name = "edycjaDodatkuToolStripMenuItem1";
            this.edycjaDodatkuToolStripMenuItem1.Size = new System.Drawing.Size(107, 21);
            this.edycjaDodatkuToolStripMenuItem1.Text = "Edytuj dodatek";
            this.edycjaDodatkuToolStripMenuItem1.Click += new System.EventHandler(this.EditSideDish);
            // 
            // ingredientsStripMenuItem1
            // 
            this.ingredientsStripMenuItem1.Name = "ingredientsStripMenuItem1";
            this.ingredientsStripMenuItem1.Size = new System.Drawing.Size(108, 21);
            this.ingredientsStripMenuItem1.Text = "Edytuj składniki";
            this.ingredientsStripMenuItem1.Click += new System.EventHandler(this.EditIngredients);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.Koniec);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(131, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(702, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Do filtra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cSideDishFilter
            // 
            this.cSideDishFilter.FormattingEnabled = true;
            this.cSideDishFilter.Location = new System.Drawing.Point(777, 439);
            this.cSideDishFilter.Name = "cSideDishFilter";
            this.cSideDishFilter.Size = new System.Drawing.Size(150, 25);
            this.cSideDishFilter.TabIndex = 9;
            // 
            // cDishFilter
            // 
            this.cDishFilter.FormattingEnabled = true;
            this.cDishFilter.Location = new System.Drawing.Point(789, 32);
            this.cDishFilter.Name = "cDishFilter";
            this.cDishFilter.Size = new System.Drawing.Size(142, 25);
            this.cDishFilter.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(713, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Do filtra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Location = new System.Drawing.Point(934, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RemoveFromList);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(934, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 26);
            this.button4.TabIndex = 15;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Opis";
            this.columnHeader8.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 716);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cDishFilter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cSideDishFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listaDodatkow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zdrowe obiady";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaDan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listaDodatkow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem dodajDodatekStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem edycjaDaniaStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem ingredientsStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cSideDishFilter;
        private System.Windows.Forms.ToolStripMenuItem edycjaDodatkuToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cDishFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

