namespace GroceryShop
{
    partial class DeliveryWork
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.CBstatas = new System.Windows.Forms.ComboBox();
            this.BtnPclear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtUemail = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblPstatas = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUaddress = new System.Windows.Forms.TextBox();
            this.lblUserAddress = new System.Windows.Forms.Label();
            this.txtUphn = new System.Windows.Forms.TextBox();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtUphn);
            this.panel1.Controls.Add(this.lblUserPhone);
            this.panel1.Controls.Add(this.txtUaddress);
            this.panel1.Controls.Add(this.lblUserAddress);
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.dgvOrder);
            this.panel1.Controls.Add(this.CBstatas);
            this.panel1.Controls.Add(this.BtnPclear);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.txtUemail);
            this.panel1.Controls.Add(this.txtUname);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.lblEmp);
            this.panel1.Controls.Add(this.lblPstatas);
            this.panel1.Controls.Add(this.lblUserEmail);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblPid);
            this.panel1.Location = new System.Drawing.Point(39, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 615);
            this.panel1.TabIndex = 0;
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.Color.Green;
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.ForeColor = System.Drawing.Color.White;
            this.BtnLoad.Location = new System.Drawing.Point(745, 360);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(105, 48);
            this.BtnLoad.TabIndex = 38;
            this.BtnLoad.Text = "Refresh";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(106, 430);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(744, 150);
            this.dgvOrder.TabIndex = 37;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // CBstatas
            // 
            this.CBstatas.FormattingEnabled = true;
            this.CBstatas.Items.AddRange(new object[] {
            "Pending",
            "Done"});
            this.CBstatas.Location = new System.Drawing.Point(645, 178);
            this.CBstatas.Name = "CBstatas";
            this.CBstatas.Size = new System.Drawing.Size(121, 24);
            this.CBstatas.TabIndex = 36;
            // 
            // BtnPclear
            // 
            this.BtnPclear.BackColor = System.Drawing.Color.Green;
            this.BtnPclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPclear.ForeColor = System.Drawing.Color.White;
            this.BtnPclear.Location = new System.Drawing.Point(796, 230);
            this.BtnPclear.Name = "BtnPclear";
            this.BtnPclear.Size = new System.Drawing.Size(112, 48);
            this.BtnPclear.TabIndex = 35;
            this.BtnPclear.Text = "Clear";
            this.BtnPclear.UseVisualStyleBackColor = false;
            this.BtnPclear.Click += new System.EventHandler(this.BtnPclear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Green;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(106, 360);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 48);
            this.BtnUpdate.TabIndex = 33;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtUemail
            // 
            this.txtUemail.Location = new System.Drawing.Point(352, 180);
            this.txtUemail.Name = "txtUemail";
            this.txtUemail.ReadOnly = true;
            this.txtUemail.Size = new System.Drawing.Size(113, 22);
            this.txtUemail.TabIndex = 31;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(213, 181);
            this.txtUname.Name = "txtUname";
            this.txtUname.ReadOnly = true;
            this.txtUname.Size = new System.Drawing.Size(118, 22);
            this.txtUname.TabIndex = 30;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(70, 181);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(118, 22);
            this.txtPID.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 28;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Green;
            this.lblItem.Location = new System.Drawing.Point(501, 47);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 25;
            this.lblItem.Text = "Items";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Green;
            this.lblEmp.Location = new System.Drawing.Point(294, 47);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(118, 25);
            this.lblEmp.TabIndex = 24;
            this.lblEmp.Text = "Employees";
            // 
            // lblPstatas
            // 
            this.lblPstatas.AutoSize = true;
            this.lblPstatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPstatas.ForeColor = System.Drawing.Color.Green;
            this.lblPstatas.Location = new System.Drawing.Point(640, 152);
            this.lblPstatas.Name = "lblPstatas";
            this.lblPstatas.Size = new System.Drawing.Size(100, 25);
            this.lblPstatas.TabIndex = 23;
            this.lblPstatas.Text = "P_Statas";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.Color.Green;
            this.lblUserEmail.Location = new System.Drawing.Point(347, 152);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(116, 25);
            this.lblUserEmail.TabIndex = 22;
            this.lblUserEmail.Text = "User Email";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Green;
            this.lblUserName.Location = new System.Drawing.Point(208, 152);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(119, 25);
            this.lblUserName.TabIndex = 21;
            this.lblUserName.Text = "User Name";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPid.ForeColor = System.Drawing.Color.Green;
            this.lblPid.Location = new System.Drawing.Point(65, 152);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(59, 25);
            this.lblPid.TabIndex = 20;
            this.lblPid.Text = "P_ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GroceryShop.Properties.Resources.item_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(444, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GroceryShop.Properties.Resources.icons8_employee_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(226, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtUaddress
            // 
            this.txtUaddress.Location = new System.Drawing.Point(496, 180);
            this.txtUaddress.Name = "txtUaddress";
            this.txtUaddress.ReadOnly = true;
            this.txtUaddress.Size = new System.Drawing.Size(113, 22);
            this.txtUaddress.TabIndex = 40;
            // 
            // lblUserAddress
            // 
            this.lblUserAddress.AutoSize = true;
            this.lblUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAddress.ForeColor = System.Drawing.Color.Green;
            this.lblUserAddress.Location = new System.Drawing.Point(491, 152);
            this.lblUserAddress.Name = "lblUserAddress";
            this.lblUserAddress.Size = new System.Drawing.Size(143, 25);
            this.lblUserAddress.TabIndex = 39;
            this.lblUserAddress.Text = "User Address";
            // 
            // txtUphn
            // 
            this.txtUphn.Location = new System.Drawing.Point(795, 180);
            this.txtUphn.Name = "txtUphn";
            this.txtUphn.ReadOnly = true;
            this.txtUphn.Size = new System.Drawing.Size(113, 22);
            this.txtUphn.TabIndex = 42;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPhone.ForeColor = System.Drawing.Color.Green;
            this.lblUserPhone.Location = new System.Drawing.Point(790, 152);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(107, 25);
            this.lblUserPhone.TabIndex = 41;
            this.lblUserPhone.Text = "Phone No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "GROCERY SHOP";
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = global::GroceryShop.Properties.Resources.back_Symbol;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.Location = new System.Drawing.Point(39, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(57, 29);
            this.BtnBack.TabIndex = 44;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DeliveryWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1033, 690);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DeliveryWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryWork";
            this.Load += new System.EventHandler(this.DeliveryWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox CBstatas;
        private System.Windows.Forms.Button BtnPclear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox txtUemail;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblPstatas;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.TextBox txtUaddress;
        private System.Windows.Forms.Label lblUserAddress;
        private System.Windows.Forms.TextBox txtUphn;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
    }
}