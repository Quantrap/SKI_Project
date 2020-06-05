namespace SKI_Project
{
    partial class FormMagazine
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
            this.listView_Magazine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonProfit = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Magazine
            // 
            this.listView_Magazine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Magazine.FullRowSelect = true;
            this.listView_Magazine.GridLines = true;
            this.listView_Magazine.Location = new System.Drawing.Point(199, 12);
            this.listView_Magazine.MultiSelect = false;
            this.listView_Magazine.Name = "listView_Magazine";
            this.listView_Magazine.Size = new System.Drawing.Size(589, 308);
            this.listView_Magazine.TabIndex = 15;
            this.listView_Magazine.UseCompatibleStateImageBehavior = false;
            this.listView_Magazine.View = System.Windows.Forms.View.Details;
            this.listView_Magazine.SelectedIndexChanged += new System.EventHandler(this.listView_Personal_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Заведующий";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Прибыль";
            this.columnHeader4.Width = 87;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 74);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 16;
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(12, 138);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManager.TabIndex = 17;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(630, 326);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(13, 55);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 13);
            this.labelCity.TabIndex = 20;
            this.labelCity.Text = "Адрес";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(13, 122);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(72, 13);
            this.labelManager.TabIndex = 21;
            this.labelManager.Text = "Заведующий";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(549, 326);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(720, 326);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonProfit
            // 
            this.buttonProfit.Location = new System.Drawing.Point(468, 327);
            this.buttonProfit.Name = "buttonProfit";
            this.buttonProfit.Size = new System.Drawing.Size(75, 40);
            this.buttonProfit.TabIndex = 24;
            this.buttonProfit.Text = "Рассчитать";
            this.buttonProfit.UseVisualStyleBackColor = true;
            this.buttonProfit.Click += new System.EventHandler(this.buttonProfit_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(12, 326);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 32;
            this.pictureLogo.TabStop = false;
            // 
            // FormMagazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonProfit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.listView_Magazine);
            this.Name = "FormMagazine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазины";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Magazine;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonProfit;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}