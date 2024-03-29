﻿namespace StokTakipOtomasyon
{
    partial class ListOfProducts
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
            this.ListOfProducts_buttonExit = new System.Windows.Forms.PictureBox();
            this.ListOfProducts_buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListOfProducts_textboxPurchasePrice = new System.Windows.Forms.TextBox();
            this.ListOfProducts_textboxSalePrice = new System.Windows.Forms.TextBox();
            this.ListOfProducts_textboxStock = new System.Windows.Forms.TextBox();
            this.ListOfProducts_textboxStockName = new System.Windows.Forms.TextBox();
            this.ListOfProducts_textboxStockCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListOfProducts_buttonUpdate = new System.Windows.Forms.Button();
            this.ListOfProducts_buttonUpdateCatAndBra = new System.Windows.Forms.Button();
            this.ListOfProducts_buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListOfProducts_comboboxCategory = new System.Windows.Forms.ComboBox();
            this.ListOfProducts_comboboxBrand = new System.Windows.Forms.ComboBox();
            this.ListOfProducts_textboxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ListOfProducts_labelWelcomeUserType = new System.Windows.Forms.Label();
            this.ListOfProducts_labelWelcomeName = new System.Windows.Forms.Label();
            this.ListOfProducts_labelWelcomeEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfProducts_buttonExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfProducts_buttonExit
            // 
            this.ListOfProducts_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.ListOfProducts_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListOfProducts_buttonExit.Location = new System.Drawing.Point(1158, 9);
            this.ListOfProducts_buttonExit.Name = "ListOfProducts_buttonExit";
            this.ListOfProducts_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.ListOfProducts_buttonExit.TabIndex = 16;
            this.ListOfProducts_buttonExit.TabStop = false;
            this.ListOfProducts_buttonExit.Click += new System.EventHandler(this.homePage_buttonExit_Click);
            // 
            // ListOfProducts_buttonBack
            // 
            this.ListOfProducts_buttonBack.Location = new System.Drawing.Point(12, 12);
            this.ListOfProducts_buttonBack.Name = "ListOfProducts_buttonBack";
            this.ListOfProducts_buttonBack.Size = new System.Drawing.Size(75, 23);
            this.ListOfProducts_buttonBack.TabIndex = 22;
            this.ListOfProducts_buttonBack.Text = "Back";
            this.ListOfProducts_buttonBack.UseVisualStyleBackColor = true;
            this.ListOfProducts_buttonBack.Click += new System.EventHandler(this.ListOfProducts_buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ListOfProducts_textboxPurchasePrice);
            this.panel1.Controls.Add(this.ListOfProducts_textboxSalePrice);
            this.panel1.Controls.Add(this.ListOfProducts_textboxStock);
            this.panel1.Controls.Add(this.ListOfProducts_textboxStockName);
            this.panel1.Controls.Add(this.ListOfProducts_textboxStockCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 288);
            this.panel1.TabIndex = 23;
            // 
            // ListOfProducts_textboxPurchasePrice
            // 
            this.ListOfProducts_textboxPurchasePrice.Location = new System.Drawing.Point(99, 252);
            this.ListOfProducts_textboxPurchasePrice.Name = "ListOfProducts_textboxPurchasePrice";
            this.ListOfProducts_textboxPurchasePrice.Size = new System.Drawing.Size(150, 20);
            this.ListOfProducts_textboxPurchasePrice.TabIndex = 11;
            // 
            // ListOfProducts_textboxSalePrice
            // 
            this.ListOfProducts_textboxSalePrice.Location = new System.Drawing.Point(99, 197);
            this.ListOfProducts_textboxSalePrice.Name = "ListOfProducts_textboxSalePrice";
            this.ListOfProducts_textboxSalePrice.Size = new System.Drawing.Size(150, 20);
            this.ListOfProducts_textboxSalePrice.TabIndex = 10;
            // 
            // ListOfProducts_textboxStock
            // 
            this.ListOfProducts_textboxStock.Location = new System.Drawing.Point(99, 143);
            this.ListOfProducts_textboxStock.Name = "ListOfProducts_textboxStock";
            this.ListOfProducts_textboxStock.Size = new System.Drawing.Size(150, 20);
            this.ListOfProducts_textboxStock.TabIndex = 9;
            this.ListOfProducts_textboxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListOfProducts_textboxStock_KeyPress);
            // 
            // ListOfProducts_textboxStockName
            // 
            this.ListOfProducts_textboxStockName.Location = new System.Drawing.Point(99, 89);
            this.ListOfProducts_textboxStockName.Name = "ListOfProducts_textboxStockName";
            this.ListOfProducts_textboxStockName.Size = new System.Drawing.Size(150, 20);
            this.ListOfProducts_textboxStockName.TabIndex = 8;
            // 
            // ListOfProducts_textboxStockCode
            // 
            this.ListOfProducts_textboxStockCode.BackColor = System.Drawing.SystemColors.Window;
            this.ListOfProducts_textboxStockCode.Location = new System.Drawing.Point(99, 35);
            this.ListOfProducts_textboxStockCode.Name = "ListOfProducts_textboxStockCode";
            this.ListOfProducts_textboxStockCode.ReadOnly = true;
            this.ListOfProducts_textboxStockCode.Size = new System.Drawing.Size(150, 20);
            this.ListOfProducts_textboxStockCode.TabIndex = 7;
            this.ListOfProducts_textboxStockCode.TextChanged += new System.EventHandler(this.ListOfProducts_textboxStockCode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(0, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Purchase Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sale Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFO :";
            // 
            // ListOfProducts_buttonUpdate
            // 
            this.ListOfProducts_buttonUpdate.Location = new System.Drawing.Point(168, 335);
            this.ListOfProducts_buttonUpdate.Name = "ListOfProducts_buttonUpdate";
            this.ListOfProducts_buttonUpdate.Size = new System.Drawing.Size(85, 31);
            this.ListOfProducts_buttonUpdate.TabIndex = 24;
            this.ListOfProducts_buttonUpdate.Text = "Update";
            this.ListOfProducts_buttonUpdate.UseVisualStyleBackColor = true;
            this.ListOfProducts_buttonUpdate.Click += new System.EventHandler(this.ListOfProducts_buttonUpdate_Click);
            // 
            // ListOfProducts_buttonUpdateCatAndBra
            // 
            this.ListOfProducts_buttonUpdateCatAndBra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfProducts_buttonUpdateCatAndBra.Location = new System.Drawing.Point(100, 468);
            this.ListOfProducts_buttonUpdateCatAndBra.Name = "ListOfProducts_buttonUpdateCatAndBra";
            this.ListOfProducts_buttonUpdateCatAndBra.Size = new System.Drawing.Size(153, 31);
            this.ListOfProducts_buttonUpdateCatAndBra.TabIndex = 26;
            this.ListOfProducts_buttonUpdateCatAndBra.Text = "Update Category Brand";
            this.ListOfProducts_buttonUpdateCatAndBra.UseVisualStyleBackColor = true;
            this.ListOfProducts_buttonUpdateCatAndBra.Click += new System.EventHandler(this.ListOfProducts_buttonUpdateCatAndBra_Click);
            // 
            // ListOfProducts_buttonDelete
            // 
            this.ListOfProducts_buttonDelete.Location = new System.Drawing.Point(87, 335);
            this.ListOfProducts_buttonDelete.Name = "ListOfProducts_buttonDelete";
            this.ListOfProducts_buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.ListOfProducts_buttonDelete.TabIndex = 27;
            this.ListOfProducts_buttonDelete.Text = "Delete";
            this.ListOfProducts_buttonDelete.UseVisualStyleBackColor = true;
            this.ListOfProducts_buttonDelete.Click += new System.EventHandler(this.ListOfProducts_buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(24, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Brand:";
            // 
            // ListOfProducts_comboboxCategory
            // 
            this.ListOfProducts_comboboxCategory.FormattingEnabled = true;
            this.ListOfProducts_comboboxCategory.Location = new System.Drawing.Point(73, 372);
            this.ListOfProducts_comboboxCategory.Name = "ListOfProducts_comboboxCategory";
            this.ListOfProducts_comboboxCategory.Size = new System.Drawing.Size(101, 21);
            this.ListOfProducts_comboboxCategory.TabIndex = 30;
            this.ListOfProducts_comboboxCategory.SelectedIndexChanged += new System.EventHandler(this.ListOfProducts_comboboxCategory_SelectedIndexChanged);
            // 
            // ListOfProducts_comboboxBrand
            // 
            this.ListOfProducts_comboboxBrand.FormattingEnabled = true;
            this.ListOfProducts_comboboxBrand.Location = new System.Drawing.Point(73, 412);
            this.ListOfProducts_comboboxBrand.Name = "ListOfProducts_comboboxBrand";
            this.ListOfProducts_comboboxBrand.Size = new System.Drawing.Size(101, 21);
            this.ListOfProducts_comboboxBrand.TabIndex = 31;
            // 
            // ListOfProducts_textboxSearch
            // 
            this.ListOfProducts_textboxSearch.Location = new System.Drawing.Point(760, 22);
            this.ListOfProducts_textboxSearch.Name = "ListOfProducts_textboxSearch";
            this.ListOfProducts_textboxSearch.Size = new System.Drawing.Size(139, 20);
            this.ListOfProducts_textboxSearch.TabIndex = 32;
            this.ListOfProducts_textboxSearch.TextChanged += new System.EventHandler(this.ListOfProducts_textboxSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(624, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Search By Stock Code:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(259, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(843, 437);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // ListOfProducts_labelWelcomeUserType
            // 
            this.ListOfProducts_labelWelcomeUserType.AutoSize = true;
            this.ListOfProducts_labelWelcomeUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfProducts_labelWelcomeUserType.Location = new System.Drawing.Point(381, 22);
            this.ListOfProducts_labelWelcomeUserType.Name = "ListOfProducts_labelWelcomeUserType";
            this.ListOfProducts_labelWelcomeUserType.Size = new System.Drawing.Size(67, 15);
            this.ListOfProducts_labelWelcomeUserType.TabIndex = 36;
            this.ListOfProducts_labelWelcomeUserType.Text = "UserType";
            this.ListOfProducts_labelWelcomeUserType.Visible = false;
            // 
            // ListOfProducts_labelWelcomeName
            // 
            this.ListOfProducts_labelWelcomeName.AutoSize = true;
            this.ListOfProducts_labelWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfProducts_labelWelcomeName.Location = new System.Drawing.Point(454, 22);
            this.ListOfProducts_labelWelcomeName.Name = "ListOfProducts_labelWelcomeName";
            this.ListOfProducts_labelWelcomeName.Size = new System.Drawing.Size(45, 15);
            this.ListOfProducts_labelWelcomeName.TabIndex = 37;
            this.ListOfProducts_labelWelcomeName.Text = "Name";
            this.ListOfProducts_labelWelcomeName.Visible = false;
            // 
            // ListOfProducts_labelWelcomeEmail
            // 
            this.ListOfProducts_labelWelcomeEmail.AutoSize = true;
            this.ListOfProducts_labelWelcomeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfProducts_labelWelcomeEmail.Location = new System.Drawing.Point(331, 22);
            this.ListOfProducts_labelWelcomeEmail.Name = "ListOfProducts_labelWelcomeEmail";
            this.ListOfProducts_labelWelcomeEmail.Size = new System.Drawing.Size(44, 15);
            this.ListOfProducts_labelWelcomeEmail.TabIndex = 38;
            this.ListOfProducts_labelWelcomeEmail.Text = "Email";
            this.ListOfProducts_labelWelcomeEmail.Visible = false;
            // 
            // ListOfProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.ListOfProducts_labelWelcomeEmail);
            this.Controls.Add(this.ListOfProducts_labelWelcomeName);
            this.Controls.Add(this.ListOfProducts_labelWelcomeUserType);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListOfProducts_textboxSearch);
            this.Controls.Add(this.ListOfProducts_comboboxBrand);
            this.Controls.Add(this.ListOfProducts_comboboxCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListOfProducts_buttonDelete);
            this.Controls.Add(this.ListOfProducts_buttonUpdateCatAndBra);
            this.Controls.Add(this.ListOfProducts_buttonUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListOfProducts_buttonBack);
            this.Controls.Add(this.ListOfProducts_buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfProducts";
            this.Load += new System.EventHandler(this.ListOfProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfProducts_buttonExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ListOfProducts_buttonExit;
        private System.Windows.Forms.Button ListOfProducts_buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ListOfProducts_textboxPurchasePrice;
        private System.Windows.Forms.TextBox ListOfProducts_textboxSalePrice;
        private System.Windows.Forms.TextBox ListOfProducts_textboxStock;
        private System.Windows.Forms.TextBox ListOfProducts_textboxStockName;
        private System.Windows.Forms.TextBox ListOfProducts_textboxStockCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListOfProducts_buttonUpdate;
        private System.Windows.Forms.Button ListOfProducts_buttonUpdateCatAndBra;
        private System.Windows.Forms.Button ListOfProducts_buttonDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ListOfProducts_comboboxCategory;
        private System.Windows.Forms.ComboBox ListOfProducts_comboboxBrand;
        private System.Windows.Forms.TextBox ListOfProducts_textboxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label ListOfProducts_labelWelcomeUserType;
        private System.Windows.Forms.Label ListOfProducts_labelWelcomeName;
        private System.Windows.Forms.Label ListOfProducts_labelWelcomeEmail;
    }
}