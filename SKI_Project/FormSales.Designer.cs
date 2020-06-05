namespace SKI_Project
{
    partial class FormSales
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
            this.comboBoxBakery = new System.Windows.Forms.ComboBox();
            this.comboBoxMagazine = new System.Windows.Forms.ComboBox();
            this.textBoxPieces = new System.Windows.Forms.TextBox();
            this.labelBakery = new System.Windows.Forms.Label();
            this.labelMagazine = new System.Windows.Forms.Label();
            this.labelPieces = new System.Windows.Forms.Label();
            this.listView_Sales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBakery
            // 
            this.comboBoxBakery.FormattingEnabled = true;
            this.comboBoxBakery.Location = new System.Drawing.Point(12, 79);
            this.comboBoxBakery.Name = "comboBoxBakery";
            this.comboBoxBakery.Size = new System.Drawing.Size(129, 21);
            this.comboBoxBakery.TabIndex = 0;
            // 
            // comboBoxMagazine
            // 
            this.comboBoxMagazine.FormattingEnabled = true;
            this.comboBoxMagazine.Location = new System.Drawing.Point(12, 133);
            this.comboBoxMagazine.Name = "comboBoxMagazine";
            this.comboBoxMagazine.Size = new System.Drawing.Size(129, 21);
            this.comboBoxMagazine.TabIndex = 1;
            // 
            // textBoxPieces
            // 
            this.textBoxPieces.Location = new System.Drawing.Point(12, 185);
            this.textBoxPieces.Name = "textBoxPieces";
            this.textBoxPieces.Size = new System.Drawing.Size(129, 20);
            this.textBoxPieces.TabIndex = 2;
            // 
            // labelBakery
            // 
            this.labelBakery.AutoSize = true;
            this.labelBakery.Location = new System.Drawing.Point(12, 60);
            this.labelBakery.Name = "labelBakery";
            this.labelBakery.Size = new System.Drawing.Size(51, 13);
            this.labelBakery.TabIndex = 3;
            this.labelBakery.Text = "Изделия";
            // 
            // labelMagazine
            // 
            this.labelMagazine.AutoSize = true;
            this.labelMagazine.Location = new System.Drawing.Point(12, 107);
            this.labelMagazine.Name = "labelMagazine";
            this.labelMagazine.Size = new System.Drawing.Size(51, 13);
            this.labelMagazine.TabIndex = 4;
            this.labelMagazine.Text = "Магазин";
            // 
            // labelPieces
            // 
            this.labelPieces.AutoSize = true;
            this.labelPieces.Location = new System.Drawing.Point(12, 161);
            this.labelPieces.Name = "labelPieces";
            this.labelPieces.Size = new System.Drawing.Size(123, 13);
            this.labelPieces.TabIndex = 5;
            this.labelPieces.Text = "Количество(шт. или кг)";
            // 
            // listView_Sales
            // 
            this.listView_Sales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Sales.FullRowSelect = true;
            this.listView_Sales.GridLines = true;
            this.listView_Sales.Location = new System.Drawing.Point(199, 12);
            this.listView_Sales.MultiSelect = false;
            this.listView_Sales.Name = "listView_Sales";
            this.listView_Sales.Size = new System.Drawing.Size(589, 308);
            this.listView_Sales.TabIndex = 18;
            this.listView_Sales.UseCompatibleStateImageBehavior = false;
            this.listView_Sales.View = System.Windows.Forms.View.Details;
            this.listView_Sales.SelectedIndexChanged += new System.EventHandler(this.listView_Sales_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Магазин";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Прибыль";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(713, 326);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 32;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(542, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 31;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(623, 326);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(12, 326);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 33;
            this.pictureLogo.TabStop = false;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listView_Sales);
            this.Controls.Add(this.labelPieces);
            this.Controls.Add(this.labelMagazine);
            this.Controls.Add(this.labelBakery);
            this.Controls.Add(this.textBoxPieces);
            this.Controls.Add(this.comboBoxMagazine);
            this.Controls.Add(this.comboBoxBakery);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBakery;
        private System.Windows.Forms.ComboBox comboBoxMagazine;
        private System.Windows.Forms.TextBox textBoxPieces;
        private System.Windows.Forms.Label labelBakery;
        private System.Windows.Forms.Label labelMagazine;
        private System.Windows.Forms.Label labelPieces;
        private System.Windows.Forms.ListView listView_Sales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}