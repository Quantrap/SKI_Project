namespace SKI_Project
{
    partial class FormSupply
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
            this.listView_Supply = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.labelMagazine = new System.Windows.Forms.Label();
            this.comboBoxMagazine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPieces = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPieces = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Supply
            // 
            this.listView_Supply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Supply.FullRowSelect = true;
            this.listView_Supply.GridLines = true;
            this.listView_Supply.Location = new System.Drawing.Point(207, 12);
            this.listView_Supply.MultiSelect = false;
            this.listView_Supply.Name = "listView_Supply";
            this.listView_Supply.Size = new System.Drawing.Size(589, 281);
            this.listView_Supply.TabIndex = 15;
            this.listView_Supply.UseCompatibleStateImageBehavior = false;
            this.listView_Supply.View = System.Windows.Forms.View.Details;
            this.listView_Supply.SelectedIndexChanged += new System.EventHandler(this.listView_Supply_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Поставщик";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Магазин";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Название сырья";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Количество";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(12, 28);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(65, 13);
            this.labelProvider.TabIndex = 17;
            this.labelProvider.Text = "Поставщик";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(12, 44);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(144, 21);
            this.comboBoxProvider.TabIndex = 16;
            // 
            // labelMagazine
            // 
            this.labelMagazine.AutoSize = true;
            this.labelMagazine.Location = new System.Drawing.Point(12, 70);
            this.labelMagazine.Name = "labelMagazine";
            this.labelMagazine.Size = new System.Drawing.Size(101, 13);
            this.labelMagazine.TabIndex = 19;
            this.labelMagazine.Text = "Магазин-заказчик";
            // 
            // comboBoxMagazine
            // 
            this.comboBoxMagazine.FormattingEnabled = true;
            this.comboBoxMagazine.Location = new System.Drawing.Point(12, 86);
            this.comboBoxMagazine.Name = "comboBoxMagazine";
            this.comboBoxMagazine.Size = new System.Drawing.Size(144, 21);
            this.comboBoxMagazine.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название сырья";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 131);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 21;
            // 
            // textBoxPieces
            // 
            this.textBoxPieces.Location = new System.Drawing.Point(12, 170);
            this.textBoxPieces.Name = "textBoxPieces";
            this.textBoxPieces.Size = new System.Drawing.Size(144, 20);
            this.textBoxPieces.TabIndex = 22;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 209);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(144, 20);
            this.textBoxPrice.TabIndex = 23;
            // 
            // labelPieces
            // 
            this.labelPieces.AutoSize = true;
            this.labelPieces.Location = new System.Drawing.Point(12, 154);
            this.labelPieces.Name = "labelPieces";
            this.labelPieces.Size = new System.Drawing.Size(123, 13);
            this.labelPieces.TabIndex = 24;
            this.labelPieces.Text = "Количество (кг или шт)";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 193);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(144, 13);
            this.labelPrice.TabIndex = 25;
            this.labelPrice.Text = "Цена (вместе с доставкой)";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(722, 300);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(632, 299);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(551, 299);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(29, 299);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 32;
            this.pictureLogo.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 455);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPieces);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxPieces);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMagazine);
            this.Controls.Add(this.comboBoxMagazine);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.listView_Supply);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Supply;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelMagazine;
        private System.Windows.Forms.ComboBox comboBoxMagazine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPieces;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPieces;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}