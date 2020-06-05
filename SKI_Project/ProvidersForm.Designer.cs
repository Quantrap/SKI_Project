namespace SKI_Project
{
    partial class ProvidersForm
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
            this.listView_Providers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Providers
            // 
            this.listView_Providers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Providers.FullRowSelect = true;
            this.listView_Providers.GridLines = true;
            this.listView_Providers.Location = new System.Drawing.Point(199, 12);
            this.listView_Providers.MultiSelect = false;
            this.listView_Providers.Name = "listView_Providers";
            this.listView_Providers.Size = new System.Drawing.Size(589, 308);
            this.listView_Providers.TabIndex = 17;
            this.listView_Providers.UseCompatibleStateImageBehavior = false;
            this.listView_Providers.View = System.Windows.Forms.View.Details;
            this.listView_Providers.SelectedIndexChanged += new System.EventHandler(this.listView_Providers_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Телефон";
            this.columnHeader3.Width = 90;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(713, 326);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 29;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(542, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(623, 326);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(13, 128);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(130, 20);
            this.textBoxPhone.TabIndex = 30;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(130, 20);
            this.textBoxName.TabIndex = 31;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Название";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(10, 112);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 33;
            this.labelPhone.Text = "Телефон";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(13, 326);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 34;
            this.pictureLogo.TabStop = false;
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listView_Providers);
            this.Name = "ProvidersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Providers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}