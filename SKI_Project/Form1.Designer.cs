namespace SKI_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.buttonMagazine = new System.Windows.Forms.Button();
            this.buttonBakery = new System.Windows.Forms.Button();
            this.buttonProviders = new System.Windows.Forms.Button();
            this.buttonSupply = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Location = new System.Drawing.Point(12, 226);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(265, 48);
            this.buttonPersonal.TabIndex = 1;
            this.buttonPersonal.Text = "Персонал";
            this.buttonPersonal.UseVisualStyleBackColor = true;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // buttonMagazine
            // 
            this.buttonMagazine.Location = new System.Drawing.Point(12, 280);
            this.buttonMagazine.Name = "buttonMagazine";
            this.buttonMagazine.Size = new System.Drawing.Size(265, 48);
            this.buttonMagazine.TabIndex = 2;
            this.buttonMagazine.Text = "Магазины";
            this.buttonMagazine.UseVisualStyleBackColor = true;
            this.buttonMagazine.Click += new System.EventHandler(this.buttonMagazine_Click);
            // 
            // buttonBakery
            // 
            this.buttonBakery.Location = new System.Drawing.Point(12, 334);
            this.buttonBakery.Name = "buttonBakery";
            this.buttonBakery.Size = new System.Drawing.Size(265, 48);
            this.buttonBakery.TabIndex = 3;
            this.buttonBakery.Text = "Выпечка";
            this.buttonBakery.UseVisualStyleBackColor = true;
            this.buttonBakery.Click += new System.EventHandler(this.buttonBakery_Click);
            // 
            // buttonProviders
            // 
            this.buttonProviders.Location = new System.Drawing.Point(12, 388);
            this.buttonProviders.Name = "buttonProviders";
            this.buttonProviders.Size = new System.Drawing.Size(265, 48);
            this.buttonProviders.TabIndex = 4;
            this.buttonProviders.Text = "Поставщики";
            this.buttonProviders.UseVisualStyleBackColor = true;
            this.buttonProviders.Click += new System.EventHandler(this.buttonProviders_Click);
            // 
            // buttonSupply
            // 
            this.buttonSupply.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSupply.Location = new System.Drawing.Point(12, 442);
            this.buttonSupply.Name = "buttonSupply";
            this.buttonSupply.Size = new System.Drawing.Size(265, 48);
            this.buttonSupply.TabIndex = 5;
            this.buttonSupply.Text = "Поставки";
            this.buttonSupply.UseVisualStyleBackColor = true;
            this.buttonSupply.Click += new System.EventHandler(this.buttonSupply_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(12, 496);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(265, 48);
            this.buttonSales.TabIndex = 6;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::SKI_Project.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(39, 70);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(206, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(12, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(101, 13);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Приветствую вас, ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 556);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonSupply);
            this.Controls.Add(this.buttonProviders);
            this.Controls.Add(this.buttonBakery);
            this.Controls.Add(this.buttonMagazine);
            this.Controls.Add(this.buttonPersonal);
            this.Controls.Add(this.pictureLogo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Button buttonMagazine;
        private System.Windows.Forms.Button buttonBakery;
        private System.Windows.Forms.Button buttonProviders;
        private System.Windows.Forms.Button buttonSupply;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Label labelHello;
    }
}

