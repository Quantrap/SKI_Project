namespace SKI_Project
{
    partial class BakeryForm
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
            this.listView_Bakery = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxProfit = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProfit = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Bakery
            // 
            this.listView_Bakery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Bakery.FullRowSelect = true;
            this.listView_Bakery.GridLines = true;
            this.listView_Bakery.Location = new System.Drawing.Point(199, 12);
            this.listView_Bakery.MultiSelect = false;
            this.listView_Bakery.Name = "listView_Bakery";
            this.listView_Bakery.Size = new System.Drawing.Size(589, 308);
            this.listView_Bakery.TabIndex = 16;
            this.listView_Bakery.UseCompatibleStateImageBehavior = false;
            this.listView_Bakery.View = System.Windows.Forms.View.Details;
            this.listView_Bakery.SelectedIndexChanged += new System.EventHandler(this.listView_Bakery_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Прибыль";
            this.columnHeader3.Width = 90;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(713, 351);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 40);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(542, 352);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 40);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(623, 351);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 41);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 27;
            // 
            // textBoxProfit
            // 
            this.textBoxProfit.Location = new System.Drawing.Point(12, 150);
            this.textBoxProfit.Name = "textBoxProfit";
            this.textBoxProfit.Size = new System.Drawing.Size(156, 20);
            this.textBoxProfit.TabIndex = 28;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Название";
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Location = new System.Drawing.Point(9, 134);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(159, 13);
            this.labelProfit.TabIndex = 30;
            this.labelProfit.Text = "Прибыль (за 1 штуку или 1 кг)";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(12, 326);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(224, 89);
            this.pictureLogo.TabIndex = 31;
            this.pictureLogo.TabStop = false;
            // 
            // BakeryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxProfit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listView_Bakery);
            this.Name = "BakeryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изделия";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Bakery;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxProfit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}