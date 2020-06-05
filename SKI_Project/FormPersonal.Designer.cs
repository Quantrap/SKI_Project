namespace SKI_Project
{
    partial class FormPersonal
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelMagazine = new System.Windows.Forms.Label();
            this.listView_Personal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxMagazine = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 46);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 89);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(132, 20);
            this.textBoxMiddleName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 129);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 169);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(132, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(12, 246);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(132, 20);
            this.textBoxPost.TabIndex = 4;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(12, 285);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(132, 20);
            this.textBoxSalary.TabIndex = 5;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(13, 73);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 8;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(13, 113);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(13, 153);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(131, 13);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Телефон (если имеется)";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(13, 230);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(65, 13);
            this.labelPost.TabIndex = 11;
            this.labelPost.Text = "Должность";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(13, 269);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 12;
            this.labelSalary.Text = "Зарплата";
            // 
            // labelMagazine
            // 
            this.labelMagazine.AutoSize = true;
            this.labelMagazine.Location = new System.Drawing.Point(12, 308);
            this.labelMagazine.Name = "labelMagazine";
            this.labelMagazine.Size = new System.Drawing.Size(51, 13);
            this.labelMagazine.TabIndex = 13;
            this.labelMagazine.Text = "Магазин";
            // 
            // listView_Personal
            // 
            this.listView_Personal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_Personal.FullRowSelect = true;
            this.listView_Personal.GridLines = true;
            this.listView_Personal.Location = new System.Drawing.Point(177, 46);
            this.listView_Personal.MultiSelect = false;
            this.listView_Personal.Name = "listView_Personal";
            this.listView_Personal.Size = new System.Drawing.Size(589, 281);
            this.listView_Personal.TabIndex = 14;
            this.listView_Personal.UseCompatibleStateImageBehavior = false;
            this.listView_Personal.View = System.Windows.Forms.View.Details;
            this.listView_Personal.SelectedIndexChanged += new System.EventHandler(this.listView_Personal_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Фамилия";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статус";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Должность";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Зарплата";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Магазин";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(520, 365);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(601, 365);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(691, 365);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(12, 207);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(132, 20);
            this.textBoxStatus.TabIndex = 18;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(13, 192);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Статус";
            // 
            // textBoxMagazine
            // 
            this.textBoxMagazine.Location = new System.Drawing.Point(12, 324);
            this.textBoxMagazine.Name = "textBoxMagazine";
            this.textBoxMagazine.Size = new System.Drawing.Size(132, 20);
            this.textBoxMagazine.TabIndex = 20;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(150, 333);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 32;
            this.pictureLogo.TabStop = false;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.textBoxMagazine);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView_Personal);
            this.Controls.Add(this.labelMagazine);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelMagazine;
        private System.Windows.Forms.ListView listView_Personal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxMagazine;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}