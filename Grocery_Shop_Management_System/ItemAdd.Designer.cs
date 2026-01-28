namespace GroceryShop
{
    partial class ItemAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.BtnPclear = new System.Windows.Forms.Button();
            this.BtnPdelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnPadd = new System.Windows.Forms.Button();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtPquantity = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPprice = new System.Windows.Forms.Label();
            this.lblPquantity = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.dgvItem);
            this.panel1.Controls.Add(this.CBcategory);
            this.panel1.Controls.Add(this.BtnPclear);
            this.panel1.Controls.Add(this.BtnPdelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnPadd);
            this.panel1.Controls.Add(this.txtPprice);
            this.panel1.Controls.Add(this.txtPquantity);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.lblEmp);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblPprice);
            this.panel1.Controls.Add(this.lblPquantity);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(50, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 633);
            this.panel1.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.Color.Green;
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.ForeColor = System.Drawing.Color.White;
            this.BtnLoad.Location = new System.Drawing.Point(46, 355);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(105, 48);
            this.BtnLoad.TabIndex = 19;
            this.BtnLoad.Text = "Refresh";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(46, 418);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(744, 150);
            this.dgvItem.TabIndex = 18;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // CBcategory
            // 
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Items.AddRange(new object[] {
            "Fresh Produce",
            "Meat and Fish"});
            this.CBcategory.Location = new System.Drawing.Point(631, 172);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(121, 24);
            this.CBcategory.TabIndex = 17;
            // 
            // BtnPclear
            // 
            this.BtnPclear.BackColor = System.Drawing.Color.Green;
            this.BtnPclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPclear.ForeColor = System.Drawing.Color.White;
            this.BtnPclear.Location = new System.Drawing.Point(631, 238);
            this.BtnPclear.Name = "BtnPclear";
            this.BtnPclear.Size = new System.Drawing.Size(112, 48);
            this.BtnPclear.TabIndex = 16;
            this.BtnPclear.Text = "Clear";
            this.BtnPclear.UseVisualStyleBackColor = false;
            this.BtnPclear.Click += new System.EventHandler(this.BtnPclear_Click);
            // 
            // BtnPdelete
            // 
            this.BtnPdelete.BackColor = System.Drawing.Color.Green;
            this.BtnPdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPdelete.ForeColor = System.Drawing.Color.White;
            this.BtnPdelete.Location = new System.Drawing.Point(447, 238);
            this.BtnPdelete.Name = "BtnPdelete";
            this.BtnPdelete.Size = new System.Drawing.Size(112, 48);
            this.BtnPdelete.TabIndex = 15;
            this.BtnPdelete.Text = "Delete";
            this.BtnPdelete.UseVisualStyleBackColor = false;
            this.BtnPdelete.Click += new System.EventHandler(this.BtnPdelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Green;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(275, 238);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 48);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnPadd
            // 
            this.BtnPadd.BackColor = System.Drawing.Color.Green;
            this.BtnPadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPadd.ForeColor = System.Drawing.Color.White;
            this.BtnPadd.Location = new System.Drawing.Point(89, 238);
            this.BtnPadd.Name = "BtnPadd";
            this.BtnPadd.Size = new System.Drawing.Size(112, 48);
            this.BtnPadd.TabIndex = 13;
            this.BtnPadd.Text = "Add";
            this.BtnPadd.UseVisualStyleBackColor = false;
            this.BtnPadd.Click += new System.EventHandler(this.BtnPadd_Click);
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(453, 174);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(113, 22);
            this.txtPprice.TabIndex = 11;
            // 
            // txtPquantity
            // 
            this.txtPquantity.Location = new System.Drawing.Point(275, 175);
            this.txtPquantity.Name = "txtPquantity";
            this.txtPquantity.Size = new System.Drawing.Size(118, 22);
            this.txtPquantity.TabIndex = 10;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(100, 175);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(118, 22);
            this.txtPName.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GroceryShop.Properties.Resources.item_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(483, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GroceryShop.Properties.Resources.icons8_employee_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(265, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Green;
            this.lblItem.Location = new System.Drawing.Point(540, 41);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Items";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Green;
            this.lblEmp.Location = new System.Drawing.Point(333, 41);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(118, 25);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Employees";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Green;
            this.lblCategory.Location = new System.Drawing.Point(626, 146);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // lblPprice
            // 
            this.lblPprice.AutoSize = true;
            this.lblPprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPprice.ForeColor = System.Drawing.Color.Green;
            this.lblPprice.Location = new System.Drawing.Point(448, 146);
            this.lblPprice.Name = "lblPprice";
            this.lblPprice.Size = new System.Drawing.Size(111, 25);
            this.lblPprice.TabIndex = 2;
            this.lblPprice.Text = "Unit_Price";
            // 
            // lblPquantity
            // 
            this.lblPquantity.AutoSize = true;
            this.lblPquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPquantity.ForeColor = System.Drawing.Color.Green;
            this.lblPquantity.Location = new System.Drawing.Point(270, 146);
            this.lblPquantity.Name = "lblPquantity";
            this.lblPquantity.Size = new System.Drawing.Size(93, 25);
            this.lblPquantity.TabIndex = 1;
            this.lblPquantity.Text = "Quantity";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Green;
            this.lblname.Location = new System.Drawing.Point(95, 146);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(92, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "It_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GROCERY SHOP";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Green;
            this.BtnBack.BackgroundImage = global::GroceryShop.Properties.Resources.back_Symbol;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(53, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(49, 44);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(959, 722);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemAdd";
            this.Load += new System.EventHandler(this.ItemAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPprice;
        private System.Windows.Forms.Label lblPquantity;
        private System.Windows.Forms.Button BtnPadd;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtPquantity;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.Button BtnPclear;
        private System.Windows.Forms.Button BtnPdelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}