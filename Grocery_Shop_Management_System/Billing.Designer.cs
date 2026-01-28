namespace GroceryShop
{
    partial class Billing
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnAddBill = new System.Windows.Forms.Button();
            this.txtITCname = new System.Windows.Forms.TextBox();
            this.txtITPrice = new System.Windows.Forms.TextBox();
            this.txtITquantity = new System.Windows.Forms.TextBox();
            this.txtITName = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblItemList = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBilling = new System.Windows.Forms.TextBox();
            this.lblBilling = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(41, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 668);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1237, 572);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnPrint);
            this.panel3.Controls.Add(this.lblBill);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.BtnReset);
            this.panel3.Controls.Add(this.BtnAddBill);
            this.panel3.Controls.Add(this.txtITCname);
            this.panel3.Controls.Add(this.txtITPrice);
            this.panel3.Controls.Add(this.txtITquantity);
            this.panel3.Controls.Add(this.txtITName);
            this.panel3.Controls.Add(this.lblClient);
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblItName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 566);
            this.panel3.TabIndex = 0;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.White;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Green;
            this.lblBill.Location = new System.Drawing.Point(225, 272);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(99, 29);
            this.lblBill.TabIndex = 11;
            this.lblBill.Text = "Bill List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 177);
            this.dataGridView1.TabIndex = 10;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Green;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(305, 202);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(167, 46);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnAddBill
            // 
            this.BtnAddBill.BackColor = System.Drawing.Color.Green;
            this.BtnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBill.ForeColor = System.Drawing.Color.White;
            this.BtnAddBill.Location = new System.Drawing.Point(73, 202);
            this.BtnAddBill.Name = "BtnAddBill";
            this.BtnAddBill.Size = new System.Drawing.Size(167, 46);
            this.BtnAddBill.TabIndex = 8;
            this.BtnAddBill.Text = "Add to Bill";
            this.BtnAddBill.UseVisualStyleBackColor = false;
            this.BtnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // txtITCname
            // 
            this.txtITCname.Location = new System.Drawing.Point(307, 147);
            this.txtITCname.Name = "txtITCname";
            this.txtITCname.Size = new System.Drawing.Size(167, 22);
            this.txtITCname.TabIndex = 7;
            // 
            // txtITPrice
            // 
            this.txtITPrice.Location = new System.Drawing.Point(73, 147);
            this.txtITPrice.Name = "txtITPrice";
            this.txtITPrice.Size = new System.Drawing.Size(167, 22);
            this.txtITPrice.TabIndex = 6;
            // 
            // txtITquantity
            // 
            this.txtITquantity.Location = new System.Drawing.Point(307, 55);
            this.txtITquantity.Name = "txtITquantity";
            this.txtITquantity.Size = new System.Drawing.Size(165, 22);
            this.txtITquantity.TabIndex = 5;
            // 
            // txtITName
            // 
            this.txtITName.Location = new System.Drawing.Point(76, 55);
            this.txtITName.Name = "txtITName";
            this.txtITName.Size = new System.Drawing.Size(164, 22);
            this.txtITName.TabIndex = 3;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.White;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.Green;
            this.lblClient.Location = new System.Drawing.Point(302, 115);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(164, 29);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Client_Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Green;
            this.lblQuantity.Location = new System.Drawing.Point(302, 23);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(154, 29);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity(kg)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(71, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price(kg)";
            // 
            // lblItName
            // 
            this.lblItName.AutoSize = true;
            this.lblItName.BackColor = System.Drawing.Color.White;
            this.lblItName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItName.ForeColor = System.Drawing.Color.Green;
            this.lblItName.Location = new System.Drawing.Point(71, 23);
            this.lblItName.Name = "lblItName";
            this.lblItName.Size = new System.Drawing.Size(110, 29);
            this.lblItName.TabIndex = 1;
            this.lblItName.Text = "It_Name";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblItemList);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(621, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 566);
            this.panel4.TabIndex = 1;
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.BackColor = System.Drawing.Color.White;
            this.lblItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemList.ForeColor = System.Drawing.Color.Green;
            this.lblItemList.Location = new System.Drawing.Point(251, 23);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(111, 29);
            this.lblItemList.TabIndex = 12;
            this.lblItemList.Text = "Item List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(591, 445);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtBilling);
            this.panel2.Controls.Add(this.lblBilling);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 92);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GroceryShop.Properties.Resources.icons8_employee_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(348, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBilling
            // 
            this.txtBilling.Location = new System.Drawing.Point(511, 21);
            this.txtBilling.Name = "txtBilling";
            this.txtBilling.Size = new System.Drawing.Size(167, 22);
            this.txtBilling.TabIndex = 1;
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.BackColor = System.Drawing.Color.White;
            this.lblBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.ForeColor = System.Drawing.Color.Green;
            this.lblBilling.Location = new System.Drawing.Point(413, 14);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(87, 29);
            this.lblBilling.TabIndex = 0;
            this.lblBilling.Text = "Billing";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = global::GroceryShop.Properties.Resources.back_Symbol;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(41, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 34);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Green;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(462, 504);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(136, 46);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1324, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblItName;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBilling;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAddBill;
        private System.Windows.Forms.TextBox txtITCname;
        private System.Windows.Forms.TextBox txtITPrice;
        private System.Windows.Forms.TextBox txtITquantity;
        private System.Windows.Forms.TextBox txtITName;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPrint;
    }
}