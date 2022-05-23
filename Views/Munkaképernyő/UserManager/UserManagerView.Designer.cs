namespace TicketSeller.Views
{
    partial class UserManagerView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userDtg = new System.Windows.Forms.DataGridView();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.addNewUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.userDetailsTabPage = new System.Windows.Forms.TabPage();
            this.modifyUserPn = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.changeAbleGb = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.birthDateGb = new System.Windows.Forms.GroupBox();
            this.yearLb = new System.Windows.Forms.Label();
            this.yearNud = new System.Windows.Forms.NumericUpDown();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.unChangeAbleGb = new System.Windows.Forms.GroupBox();
            this.discountIdVal = new System.Windows.Forms.Label();
            this.discountIdLb = new System.Windows.Forms.Label();
            this.boughtTicketVal = new System.Windows.Forms.Label();
            this.boughtTicketLb = new System.Windows.Forms.Label();
            this.ticketIdVal = new System.Windows.Forms.Label();
            this.ticketIdLb = new System.Windows.Forms.Label();
            this.idVal = new System.Windows.Forms.Label();
            this.idLb = new System.Windows.Forms.Label();
            this.identifierVal = new System.Windows.Forms.Label();
            this.identifierLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveChangeBtn = new System.Windows.Forms.Button();
            this.cancelChangesBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.usersTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDtg)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.userDetailsTabPage.SuspendLayout();
            this.modifyUserPn.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.changeAbleGb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.birthDateGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).BeginInit();
            this.unChangeAbleGb.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersTabPage);
            this.tabControl1.Controls.Add(this.userDetailsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.panel1);
            this.usersTabPage.Controls.Add(this.optionsPanel);
            this.usersTabPage.Location = new System.Drawing.Point(4, 24);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(862, 484);
            this.usersTabPage.TabIndex = 0;
            this.usersTabPage.Text = "Felhasználók";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userDtg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 388);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1251, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Choose that user you want to edit";
            // 
            // userDtg
            // 
            this.userDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDtg.Location = new System.Drawing.Point(0, 0);
            this.userDtg.Margin = new System.Windows.Forms.Padding(20);
            this.userDtg.Name = "userDtg";
            this.userDtg.RowTemplate.Height = 25;
            this.userDtg.Size = new System.Drawing.Size(856, 388);
            this.userDtg.TabIndex = 0;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.tableLayoutPanel1);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(856, 90);
            this.optionsPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.36794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48178F));
            this.tableLayoutPanel1.Controls.Add(this.deleteUserBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addNewUserBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editUserBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 90);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteUserBtn.FlatAppearance.BorderSize = 0;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteUserBtn.ForeColor = System.Drawing.Color.White;
            this.deleteUserBtn.Location = new System.Drawing.Point(626, 25);
            this.deleteUserBtn.Margin = new System.Windows.Forms.Padding(25);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(171, 40);
            this.deleteUserBtn.TabIndex = 2;
            this.deleteUserBtn.Text = "Törlés";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addNewUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addNewUserBtn.FlatAppearance.BorderSize = 0;
            this.addNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewUserBtn.ForeColor = System.Drawing.Color.White;
            this.addNewUserBtn.Location = new System.Drawing.Point(57, 25);
            this.addNewUserBtn.Margin = new System.Windows.Forms.Padding(25);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(171, 40);
            this.addNewUserBtn.TabIndex = 0;
            this.addNewUserBtn.Text = "Új hozzáadása";
            this.addNewUserBtn.UseVisualStyleBackColor = false;
            // 
            // editUserBtn
            // 
            this.editUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editUserBtn.BackColor = System.Drawing.Color.White;
            this.editUserBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.editUserBtn.FlatAppearance.BorderSize = 5;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserBtn.ForeColor = System.Drawing.Color.Black;
            this.editUserBtn.Location = new System.Drawing.Point(339, 25);
            this.editUserBtn.Margin = new System.Windows.Forms.Padding(25);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(174, 40);
            this.editUserBtn.TabIndex = 1;
            this.editUserBtn.Text = "Szerkesztés";
            this.editUserBtn.UseVisualStyleBackColor = false;
            // 
            // userDetailsTabPage
            // 
            this.userDetailsTabPage.Controls.Add(this.modifyUserPn);
            this.userDetailsTabPage.Location = new System.Drawing.Point(4, 24);
            this.userDetailsTabPage.Name = "userDetailsTabPage";
            this.userDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userDetailsTabPage.Size = new System.Drawing.Size(862, 484);
            this.userDetailsTabPage.TabIndex = 1;
            this.userDetailsTabPage.Text = "Felhasználó adatai";
            this.userDetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // modifyUserPn
            // 
            this.modifyUserPn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyUserPn.Controls.Add(this.tableLayoutPanel3);
            this.modifyUserPn.Controls.Add(this.tableLayoutPanel2);
            this.modifyUserPn.Location = new System.Drawing.Point(30, 30);
            this.modifyUserPn.Margin = new System.Windows.Forms.Padding(30);
            this.modifyUserPn.Name = "modifyUserPn";
            this.modifyUserPn.Size = new System.Drawing.Size(802, 424);
            this.modifyUserPn.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.changeAbleGb, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.unChangeAbleGb, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(802, 328);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // changeAbleGb
            // 
            this.changeAbleGb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.changeAbleGb.Controls.Add(this.groupBox1);
            this.changeAbleGb.Controls.Add(this.nameLb);
            this.changeAbleGb.Controls.Add(this.birthDateGb);
            this.changeAbleGb.Controls.Add(this.nameTb);
            this.changeAbleGb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeAbleGb.Location = new System.Drawing.Point(28, 15);
            this.changeAbleGb.Margin = new System.Windows.Forms.Padding(15);
            this.changeAbleGb.Name = "changeAbleGb";
            this.changeAbleGb.Size = new System.Drawing.Size(344, 298);
            this.changeAbleGb.TabIndex = 6;
            this.changeAbleGb.TabStop = false;
            this.changeAbleGb.Text = "Szerkeszthető adatok";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryCb);
            this.groupBox1.Location = new System.Drawing.Point(16, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategória";
            // 
            // categoryCb
            // 
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Items.AddRange(new object[] {
            "Felnőtt",
            "Diák",
            "26 éven aluli",
            "Nyugdíjas",
            "Hátrányos helyzetű",
            "Dolgozó"});
            this.categoryCb.Location = new System.Drawing.Point(6, 31);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(292, 29);
            this.categoryCb.TabIndex = 0;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(16, 25);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(38, 20);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "Név";
            // 
            // birthDateGb
            // 
            this.birthDateGb.Controls.Add(this.yearLb);
            this.birthDateGb.Controls.Add(this.yearNud);
            this.birthDateGb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthDateGb.Location = new System.Drawing.Point(16, 91);
            this.birthDateGb.Name = "birthDateGb";
            this.birthDateGb.Size = new System.Drawing.Size(291, 100);
            this.birthDateGb.TabIndex = 5;
            this.birthDateGb.TabStop = false;
            this.birthDateGb.Text = "Születési év";
            // 
            // yearLb
            // 
            this.yearLb.AutoSize = true;
            this.yearLb.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLb.Location = new System.Drawing.Point(110, 36);
            this.yearLb.Name = "yearLb";
            this.yearLb.Size = new System.Drawing.Size(25, 20);
            this.yearLb.TabIndex = 3;
            this.yearLb.Text = "Év";
            // 
            // yearNud
            // 
            this.yearNud.Location = new System.Drawing.Point(110, 59);
            this.yearNud.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.yearNud.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNud.Name = "yearNud";
            this.yearNud.Size = new System.Drawing.Size(81, 29);
            this.yearNud.TabIndex = 4;
            this.yearNud.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(16, 48);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(124, 29);
            this.nameTb.TabIndex = 0;
            // 
            // unChangeAbleGb
            // 
            this.unChangeAbleGb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.unChangeAbleGb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unChangeAbleGb.Controls.Add(this.discountIdVal);
            this.unChangeAbleGb.Controls.Add(this.discountIdLb);
            this.unChangeAbleGb.Controls.Add(this.boughtTicketVal);
            this.unChangeAbleGb.Controls.Add(this.boughtTicketLb);
            this.unChangeAbleGb.Controls.Add(this.ticketIdVal);
            this.unChangeAbleGb.Controls.Add(this.ticketIdLb);
            this.unChangeAbleGb.Controls.Add(this.idVal);
            this.unChangeAbleGb.Controls.Add(this.idLb);
            this.unChangeAbleGb.Controls.Add(this.identifierVal);
            this.unChangeAbleGb.Controls.Add(this.identifierLb);
            this.unChangeAbleGb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unChangeAbleGb.ForeColor = System.Drawing.Color.DimGray;
            this.unChangeAbleGb.Location = new System.Drawing.Point(437, 15);
            this.unChangeAbleGb.Margin = new System.Windows.Forms.Padding(15);
            this.unChangeAbleGb.Name = "unChangeAbleGb";
            this.unChangeAbleGb.Size = new System.Drawing.Size(328, 298);
            this.unChangeAbleGb.TabIndex = 7;
            this.unChangeAbleGb.TabStop = false;
            this.unChangeAbleGb.Text = "Nem szerkeszthető adatok";
            // 
            // discountIdVal
            // 
            this.discountIdVal.AutoSize = true;
            this.discountIdVal.Location = new System.Drawing.Point(155, 188);
            this.discountIdVal.Name = "discountIdVal";
            this.discountIdVal.Size = new System.Drawing.Size(19, 21);
            this.discountIdVal.TabIndex = 13;
            this.discountIdVal.Text = "0";
            // 
            // discountIdLb
            // 
            this.discountIdLb.AutoSize = true;
            this.discountIdLb.Location = new System.Drawing.Point(36, 187);
            this.discountIdLb.Name = "discountIdLb";
            this.discountIdLb.Size = new System.Drawing.Size(106, 21);
            this.discountIdLb.TabIndex = 12;
            this.discountIdLb.Text = "Discount Id :";
            // 
            // boughtTicketVal
            // 
            this.boughtTicketVal.AutoSize = true;
            this.boughtTicketVal.Location = new System.Drawing.Point(231, 153);
            this.boughtTicketVal.Name = "boughtTicketVal";
            this.boughtTicketVal.Size = new System.Drawing.Size(19, 21);
            this.boughtTicketVal.TabIndex = 11;
            this.boughtTicketVal.Text = "0";
            // 
            // boughtTicketLb
            // 
            this.boughtTicketLb.AutoSize = true;
            this.boughtTicketLb.Location = new System.Drawing.Point(36, 153);
            this.boughtTicketLb.Name = "boughtTicketLb";
            this.boughtTicketLb.Size = new System.Drawing.Size(196, 21);
            this.boughtTicketLb.TabIndex = 10;
            this.boughtTicketLb.Text = "Ingyen jegyig jegyszám :";
            // 
            // ticketIdVal
            // 
            this.ticketIdVal.AutoSize = true;
            this.ticketIdVal.Location = new System.Drawing.Point(130, 123);
            this.ticketIdVal.Name = "ticketIdVal";
            this.ticketIdVal.Size = new System.Drawing.Size(19, 21);
            this.ticketIdVal.TabIndex = 7;
            this.ticketIdVal.Text = "0";
            // 
            // ticketIdLb
            // 
            this.ticketIdLb.AutoSize = true;
            this.ticketIdLb.Location = new System.Drawing.Point(36, 123);
            this.ticketIdLb.Name = "ticketIdLb";
            this.ticketIdLb.Size = new System.Drawing.Size(84, 21);
            this.ticketIdLb.TabIndex = 6;
            this.ticketIdLb.Text = "Ticket Id :";
            // 
            // idVal
            // 
            this.idVal.AutoSize = true;
            this.idVal.Location = new System.Drawing.Point(130, 56);
            this.idVal.Name = "idVal";
            this.idVal.Size = new System.Drawing.Size(19, 21);
            this.idVal.TabIndex = 3;
            this.idVal.Text = "0";
            // 
            // idLb
            // 
            this.idLb.AutoSize = true;
            this.idLb.Location = new System.Drawing.Point(36, 56);
            this.idLb.Name = "idLb";
            this.idLb.Size = new System.Drawing.Size(36, 21);
            this.idLb.TabIndex = 2;
            this.idLb.Text = "ID :";
            // 
            // identifierVal
            // 
            this.identifierVal.AutoSize = true;
            this.identifierVal.Location = new System.Drawing.Point(130, 88);
            this.identifierVal.Name = "identifierVal";
            this.identifierVal.Size = new System.Drawing.Size(38, 21);
            this.identifierVal.TabIndex = 1;
            this.identifierVal.Text = "null";
            // 
            // identifierLb
            // 
            this.identifierLb.AutoSize = true;
            this.identifierLb.Location = new System.Drawing.Point(36, 88);
            this.identifierLb.Name = "identifierLb";
            this.identifierLb.Size = new System.Drawing.Size(95, 21);
            this.identifierLb.TabIndex = 0;
            this.identifierLb.Text = "Azonosító :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveChangeBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelChangesBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(802, 96);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // saveChangeBtn
            // 
            this.saveChangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveChangeBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveChangeBtn.FlatAppearance.BorderSize = 0;
            this.saveChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveChangeBtn.ForeColor = System.Drawing.Color.White;
            this.saveChangeBtn.Location = new System.Drawing.Point(115, 30);
            this.saveChangeBtn.Margin = new System.Windows.Forms.Padding(30);
            this.saveChangeBtn.Name = "saveChangeBtn";
            this.saveChangeBtn.Size = new System.Drawing.Size(171, 36);
            this.saveChangeBtn.TabIndex = 8;
            this.saveChangeBtn.Text = "Mentés";
            this.saveChangeBtn.UseVisualStyleBackColor = false;
            // 
            // cancelChangesBtn
            // 
            this.cancelChangesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cancelChangesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelChangesBtn.FlatAppearance.BorderSize = 0;
            this.cancelChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChangesBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelChangesBtn.ForeColor = System.Drawing.Color.White;
            this.cancelChangesBtn.Location = new System.Drawing.Point(516, 30);
            this.cancelChangesBtn.Margin = new System.Windows.Forms.Padding(30);
            this.cancelChangesBtn.Name = "cancelChangesBtn";
            this.cancelChangesBtn.Size = new System.Drawing.Size(171, 36);
            this.cancelChangesBtn.TabIndex = 9;
            this.cancelChangesBtn.Text = "Vissza";
            this.cancelChangesBtn.UseVisualStyleBackColor = false;
            // 
            // UserManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 512);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(886, 551);
            this.Name = "UserManagerView";
            this.Text = "Felhasználó kezelő";
            this.tabControl1.ResumeLayout(false);
            this.usersTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDtg)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.userDetailsTabPage.ResumeLayout(false);
            this.modifyUserPn.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.changeAbleGb.ResumeLayout(false);
            this.changeAbleGb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.birthDateGb.ResumeLayout(false);
            this.birthDateGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).EndInit();
            this.unChangeAbleGb.ResumeLayout(false);
            this.unChangeAbleGb.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage usersTabPage;
        private Panel panel1;
        private Label label1;
        private DataGridView userDtg;
        private Panel optionsPanel;
        private Button deleteUserBtn;
        private Button editUserBtn;
        private Button addNewUserBtn;
        private TabPage userDetailsTabPage;
        private Panel modifyUserPn;
        private GroupBox unChangeAbleGb;
        private Label boughtTicketVal;
        private Label boughtTicketLb;
        private Label ticketIdVal;
        private Label ticketIdLb;
        private Label idVal;
        private Label idLb;
        private Label identifierVal;
        private Label identifierLb;
        private GroupBox changeAbleGb;
        private Label nameLb;
        private GroupBox birthDateGb;
        private Label yearLb;
        private NumericUpDown yearNud;
        private TextBox nameTb;
        private Button saveChangeBtn;
        private Button cancelChangesBtn;
        private Label discountIdVal;
        private Label discountIdLb;
        private GroupBox groupBox1;
        private ComboBox categoryCb;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}