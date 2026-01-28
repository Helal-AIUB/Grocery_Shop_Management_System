namespace GroceryShop
{
    partial class UserDashBoard
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
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.ItID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.BtnPclear = new System.Windows.Forms.Button();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtPquantity = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.ItID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.dgvItem);
            this.panel1.Controls.Add(this.CBcategory);
            this.panel1.Controls.Add(this.BtnPclear);
            this.panel1.Controls.Add(this.txtPprice);
            this.panel1.Controls.Add(this.txtPquantity);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.lblquantity);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(40, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 673);
            this.panel1.TabIndex = 0;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(127, 174);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(118, 22);
            this.txtItemID.TabIndex = 41;
            // 
            // ItID
            // 
            this.ItID.AutoSize = true;
            this.ItID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItID.ForeColor = System.Drawing.Color.Green;
            this.ItID.Location = new System.Drawing.Point(131, 145);
            this.ItID.Name = "ItID";
            this.ItID.Size = new System.Drawing.Size(33, 25);
            this.ItID.TabIndex = 40;
            this.ItID.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "Go for Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.Color.Green;
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.ForeColor = System.Drawing.Color.White;
            this.BtnLoad.Location = new System.Drawing.Point(665, 345);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(105, 48);
            this.BtnLoad.TabIndex = 38;
            this.BtnLoad.Text = "Refresh";
            this.BtnLoad.UseVisualStyleBackColor = false;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(93, 419);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(836, 211);
            this.dgvItem.TabIndex = 37;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // CBcategory
            // 
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Items.AddRange(new object[] {
            "Fresh Produce",
            "Meat and Fish"});
            this.CBcategory.Location = new System.Drawing.Point(816, 171);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(121, 24);
            this.CBcategory.TabIndex = 36;
            // 
            // BtnPclear
            // 
            this.BtnPclear.BackColor = System.Drawing.Color.Green;
            this.BtnPclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPclear.ForeColor = System.Drawing.Color.White;
            this.BtnPclear.Location = new System.Drawing.Point(817, 345);
            this.BtnPclear.Name = "BtnPclear";
            this.BtnPclear.Size = new System.Drawing.Size(112, 48);
            this.BtnPclear.TabIndex = 35;
            this.BtnPclear.Text = "Clear";
            this.BtnPclear.UseVisualStyleBackColor = false;
            this.BtnPclear.Click += new System.EventHandler(this.BtnPclear_Click);
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(638, 173);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.ReadOnly = true;
            this.txtPprice.Size = new System.Drawing.Size(113, 22);
            this.txtPprice.TabIndex = 31;
            // 
            // txtPquantity
            // 
            this.txtPquantity.Location = new System.Drawing.Point(460, 174);
            this.txtPquantity.Name = "txtPquantity";
            this.txtPquantity.ReadOnly = true;
            this.txtPquantity.Size = new System.Drawing.Size(118, 22);
            this.txtPquantity.TabIndex = 30;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(285, 174);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(118, 22);
            this.txtPName.TabIndex = 29;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(422, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(126, 22);
            this.txtUser.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GroceryShop.Properties.Resources.item_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(565, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GroceryShop.Properties.Resources.icons8_employee_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(291, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Green;
            this.lblItem.Location = new System.Drawing.Point(635, 46);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 25;
            this.lblItem.Text = "Items";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Green;
            this.lblUser.Location = new System.Drawing.Point(359, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 25);
            this.lblUser.TabIndex = 24;
            this.lblUser.Text = "User";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Green;
            this.lblCategory.Location = new System.Drawing.Point(811, 145);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "Category";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Green;
            this.lblprice.Location = new System.Drawing.Point(633, 145);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(111, 25);
            this.lblprice.TabIndex = 22;
            this.lblprice.Text = "Unit_Price";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Green;
            this.lblquantity.Location = new System.Drawing.Point(455, 145);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(93, 25);
            this.lblquantity.TabIndex = 21;
            this.lblquantity.Text = "Quantity";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Green;
            this.lblname.Location = new System.Drawing.Point(280, 145);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(92, 25);
            this.lblname.TabIndex = 20;
            this.lblname.Text = "It_Name";
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = global::GroceryShop.Properties.Resources.back_Symbol;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Location = new System.Drawing.Point(43, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(64, 42);
            this.BtnBack.TabIndex = 44;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1110, 755);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Name = "UserDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashBoard";
            this.Load += new System.EventHandler(this.UserDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.Button BtnPclear;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtPquantity;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label ItID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBack;
    }
}