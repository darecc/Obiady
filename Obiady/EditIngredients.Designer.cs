
namespace Obiady
{
    partial class EditIngredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ingredientsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(411, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(503, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Koniec";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ingredientsList
            // 
            this.ingredientsList.BackColor = System.Drawing.Color.AliceBlue;
            this.ingredientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ingredientsList.FullRowSelect = true;
            this.ingredientsList.HideSelection = false;
            this.ingredientsList.Location = new System.Drawing.Point(12, 23);
            this.ingredientsList.Name = "ingredientsList";
            this.ingredientsList.Size = new System.Drawing.Size(566, 361);
            this.ingredientsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ingredientsList.TabIndex = 2;
            this.ingredientsList.UseCompatibleStateImageBehavior = false;
            this.ingredientsList.View = System.Windows.Forms.View.Details;
            this.ingredientsList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnClickColumn);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategoria";
            this.columnHeader2.Width = 160;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(13, 399);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(218, 25);
            this.nazwa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa";
            // 
            // kategoria
            // 
            this.kategoria.Location = new System.Drawing.Point(252, 399);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(151, 25);
            this.kategoria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategoria";
            // 
            // EditIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ingredientsList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditIngredients";
            this.Text = "Edycja składników dań";
            this.Load += new System.EventHandler(this.EditIngredients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView ingredientsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategoria;
        private System.Windows.Forms.Label label2;
    }
}