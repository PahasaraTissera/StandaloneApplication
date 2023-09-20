
namespace InventoryManagementSystem
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prodQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.productsGV = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.prodCatSearch = new System.Windows.Forms.ComboBox();
            this.prodCat = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 34);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 100);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(377, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // prodPrice
            // 
            this.prodPrice.Location = new System.Drawing.Point(41, 345);
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.Size = new System.Drawing.Size(307, 23);
            this.prodPrice.TabIndex = 23;
            this.prodPrice.TextChanged += new System.EventHandler(this.prodPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(41, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Product Price";
            // 
            // prodQty
            // 
            this.prodQty.Location = new System.Drawing.Point(41, 280);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(307, 23);
            this.prodQty.TabIndex = 21;
            this.prodQty.TextChanged += new System.EventHandler(this.prodQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product Quantity";
            // 
            // prodName
            // 
            this.prodName.Location = new System.Drawing.Point(41, 217);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(307, 23);
            this.prodName.TabIndex = 19;
            this.prodName.TextChanged += new System.EventHandler(this.prodName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Product Name";
            // 
            // prodId
            // 
            this.prodId.Location = new System.Drawing.Point(41, 155);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(307, 23);
            this.prodId.TabIndex = 17;
            this.prodId.TextChanged += new System.EventHandler(this.prodId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID";
            // 
            // prodDesc
            // 
            this.prodDesc.Location = new System.Drawing.Point(41, 410);
            this.prodDesc.Name = "prodDesc";
            this.prodDesc.Size = new System.Drawing.Size(307, 23);
            this.prodDesc.TabIndex = 25;
            this.prodDesc.TextChanged += new System.EventHandler(this.prodDesc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Description";
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home.Location = new System.Drawing.Point(155, 586);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(82, 34);
            this.home.TabIndex = 29;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(266, 521);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 34);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit.Location = new System.Drawing.Point(155, 521);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(82, 34);
            this.edit.TabIndex = 27;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(41, 521);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(82, 34);
            this.add.TabIndex = 26;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(559, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 37);
            this.label9.TabIndex = 31;
            this.label9.Text = "PRODUCTS LIST";
            // 
            // productsGV
            // 
            this.productsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGV.Location = new System.Drawing.Point(399, 251);
            this.productsGV.Name = "productsGV";
            this.productsGV.RowTemplate.Height = 25;
            this.productsGV.Size = new System.Drawing.Size(532, 364);
            this.productsGV.TabIndex = 30;
            this.productsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGV_CellContentClick);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh.Location = new System.Drawing.Point(823, 186);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(102, 34);
            this.refresh.TabIndex = 33;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(707, 186);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 34);
            this.search.TabIndex = 32;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // prodCatSearch
            // 
            this.prodCatSearch.FormattingEnabled = true;
            this.prodCatSearch.Location = new System.Drawing.Point(475, 191);
            this.prodCatSearch.Name = "prodCatSearch";
            this.prodCatSearch.Size = new System.Drawing.Size(212, 23);
            this.prodCatSearch.TabIndex = 34;
            this.prodCatSearch.Text = "Product Category";
            this.prodCatSearch.SelectedIndexChanged += new System.EventHandler(this.prodCatSearch_SelectedIndexChanged);
            // 
            // prodCat
            // 
            this.prodCat.FormattingEnabled = true;
            this.prodCat.Location = new System.Drawing.Point(41, 455);
            this.prodCat.Name = "prodCat";
            this.prodCat.Size = new System.Drawing.Size(212, 23);
            this.prodCat.TabIndex = 35;
            this.prodCat.Text = "Product Category";
            this.prodCat.SelectedIndexChanged += new System.EventHandler(this.prodCat_SelectedIndexChanged);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(879, 32);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 8;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(26, 32);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(37, 36);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 7;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 660);
            this.Controls.Add(this.prodCat);
            this.Controls.Add(this.prodCatSearch);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.productsGV);
            this.Controls.Add(this.home);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.prodDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prodPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prodQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prodQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prodId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prodDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView productsGV;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox prodCatSearch;
        private System.Windows.Forms.ComboBox prodCat;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox back;
    }
}