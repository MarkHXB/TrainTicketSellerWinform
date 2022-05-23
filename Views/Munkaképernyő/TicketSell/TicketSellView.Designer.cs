namespace TicketSeller.Views.Munkaképernyő
{
    partial class TicketSellView
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
            this.ticketSellerTbc = new System.Windows.Forms.TabControl();
            this.ticketSellerSearch = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.userDetailsGb = new System.Windows.Forms.GroupBox();
            this.userBTicketsVal = new System.Windows.Forms.Label();
            this.userBTicketsLb = new System.Windows.Forms.Label();
            this.userTypeVal = new System.Windows.Forms.Label();
            this.userTypeLb = new System.Windows.Forms.Label();
            this.userAgeVal = new System.Windows.Forms.Label();
            this.userAgeLb = new System.Windows.Forms.Label();
            this.userNameVal = new System.Windows.Forms.Label();
            this.userNameLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchUserBtn = new System.Windows.Forms.Button();
            this.searchUserBar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchForCb = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseUserBtn = new System.Windows.Forms.Button();
            this.notRegisteredBtn = new System.Windows.Forms.Button();
            this.ticketSellerDataEntry = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseTicketGb = new System.Windows.Forms.GroupBox();
            this.preTicketTicketOrSubCb = new System.Windows.Forms.ComboBox();
            this.ticketOrSubscriptionLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preTicketDestinationsCb = new System.Windows.Forms.ComboBox();
            this.destinationLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.preTicketBackBtn = new System.Windows.Forms.Button();
            this.preTicketNextBtn = new System.Windows.Forms.Button();
            this.ticketSellerConfirmTicket = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.payWithCashBtn = new System.Windows.Forms.Button();
            this.payWithCreditCardBtn = new System.Windows.Forms.Button();
            this.confirmTicketScreen = new System.Windows.Forms.TableLayoutPanel();
            this.confirmTicketPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmTicketBackBtn = new System.Windows.Forms.Button();
            this.confirmTicketBuyBtn = new System.Windows.Forms.Button();
            this.ticketSellerTbc.SuspendLayout();
            this.ticketSellerSearch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.userDetailsGb.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ticketSellerDataEntry.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.chooseTicketGb.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.ticketSellerConfirmTicket.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.confirmTicketScreen.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketSellerTbc
            // 
            this.ticketSellerTbc.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ticketSellerTbc.Controls.Add(this.ticketSellerSearch);
            this.ticketSellerTbc.Controls.Add(this.ticketSellerDataEntry);
            this.ticketSellerTbc.Controls.Add(this.ticketSellerConfirmTicket);
            this.ticketSellerTbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketSellerTbc.ItemSize = new System.Drawing.Size(0, 1);
            this.ticketSellerTbc.Location = new System.Drawing.Point(0, 0);
            this.ticketSellerTbc.Name = "ticketSellerTbc";
            this.ticketSellerTbc.SelectedIndex = 0;
            this.ticketSellerTbc.Size = new System.Drawing.Size(1072, 675);
            this.ticketSellerTbc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ticketSellerTbc.TabIndex = 1;
            // 
            // ticketSellerSearch
            // 
            this.ticketSellerSearch.Controls.Add(this.tableLayoutPanel3);
            this.ticketSellerSearch.Controls.Add(this.tableLayoutPanel2);
            this.ticketSellerSearch.Controls.Add(this.tableLayoutPanel1);
            this.ticketSellerSearch.Location = new System.Drawing.Point(4, 5);
            this.ticketSellerSearch.Name = "ticketSellerSearch";
            this.ticketSellerSearch.Padding = new System.Windows.Forms.Padding(3);
            this.ticketSellerSearch.Size = new System.Drawing.Size(1064, 666);
            this.ticketSellerSearch.TabIndex = 0;
            this.ticketSellerSearch.Text = "Felhasználó kiválasztása";
            this.ticketSellerSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.userDetailsGb, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1058, 486);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // userDetailsGb
            // 
            this.userDetailsGb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userDetailsGb.Controls.Add(this.userBTicketsVal);
            this.userDetailsGb.Controls.Add(this.userBTicketsLb);
            this.userDetailsGb.Controls.Add(this.userTypeVal);
            this.userDetailsGb.Controls.Add(this.userTypeLb);
            this.userDetailsGb.Controls.Add(this.userAgeVal);
            this.userDetailsGb.Controls.Add(this.userAgeLb);
            this.userDetailsGb.Controls.Add(this.userNameVal);
            this.userDetailsGb.Controls.Add(this.userNameLb);
            this.userDetailsGb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userDetailsGb.Location = new System.Drawing.Point(271, 10);
            this.userDetailsGb.Margin = new System.Windows.Forms.Padding(10);
            this.userDetailsGb.Name = "userDetailsGb";
            this.userDetailsGb.Size = new System.Drawing.Size(516, 466);
            this.userDetailsGb.TabIndex = 9;
            this.userDetailsGb.TabStop = false;
            this.userDetailsGb.Text = "Felhasználó adatai";
            // 
            // userBTicketsVal
            // 
            this.userBTicketsVal.AutoSize = true;
            this.userBTicketsVal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userBTicketsVal.Location = new System.Drawing.Point(383, 282);
            this.userBTicketsVal.Name = "userBTicketsVal";
            this.userBTicketsVal.Size = new System.Drawing.Size(0, 25);
            this.userBTicketsVal.TabIndex = 7;
            // 
            // userBTicketsLb
            // 
            this.userBTicketsLb.AutoSize = true;
            this.userBTicketsLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userBTicketsLb.Location = new System.Drawing.Point(49, 282);
            this.userBTicketsLb.Name = "userBTicketsLb";
            this.userBTicketsLb.Size = new System.Drawing.Size(310, 25);
            this.userBTicketsLb.TabIndex = 6;
            this.userBTicketsLb.Text = "Hány jegyet kell még vásárolnia:";
            // 
            // userTypeVal
            // 
            this.userTypeVal.AutoSize = true;
            this.userTypeVal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTypeVal.Location = new System.Drawing.Point(163, 228);
            this.userTypeVal.Name = "userTypeVal";
            this.userTypeVal.Size = new System.Drawing.Size(0, 25);
            this.userTypeVal.TabIndex = 5;
            // 
            // userTypeLb
            // 
            this.userTypeLb.AutoSize = true;
            this.userTypeLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTypeLb.Location = new System.Drawing.Point(49, 228);
            this.userTypeLb.Name = "userTypeLb";
            this.userTypeLb.Size = new System.Drawing.Size(105, 25);
            this.userTypeLb.TabIndex = 4;
            this.userTypeLb.Text = "Kategória:";
            // 
            // userAgeVal
            // 
            this.userAgeVal.AutoSize = true;
            this.userAgeVal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userAgeVal.Location = new System.Drawing.Point(179, 174);
            this.userAgeVal.Name = "userAgeVal";
            this.userAgeVal.Size = new System.Drawing.Size(0, 25);
            this.userAgeVal.TabIndex = 3;
            // 
            // userAgeLb
            // 
            this.userAgeLb.AutoSize = true;
            this.userAgeLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userAgeLb.Location = new System.Drawing.Point(49, 174);
            this.userAgeLb.Name = "userAgeLb";
            this.userAgeLb.Size = new System.Drawing.Size(124, 25);
            this.userAgeLb.TabIndex = 2;
            this.userAgeLb.Text = "Születési év:";
            // 
            // userNameVal
            // 
            this.userNameVal.AutoSize = true;
            this.userNameVal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameVal.Location = new System.Drawing.Point(132, 125);
            this.userNameVal.Name = "userNameVal";
            this.userNameVal.Size = new System.Drawing.Size(0, 25);
            this.userNameVal.TabIndex = 1;
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLb.Location = new System.Drawing.Point(49, 125);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(53, 25);
            this.userNameLb.TabIndex = 0;
            this.userNameLb.Text = "Név:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.searchUserBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchUserBar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1058, 74);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // searchUserBtn
            // 
            this.searchUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchUserBtn.FlatAppearance.BorderSize = 0;
            this.searchUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchUserBtn.ForeColor = System.Drawing.Color.White;
            this.searchUserBtn.Location = new System.Drawing.Point(826, 15);
            this.searchUserBtn.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.searchUserBtn.Name = "searchUserBtn";
            this.searchUserBtn.Size = new System.Drawing.Size(146, 44);
            this.searchUserBtn.TabIndex = 7;
            this.searchUserBtn.Text = "Keresés";
            this.searchUserBtn.UseVisualStyleBackColor = false;
            // 
            // searchUserBar
            // 
            this.searchUserBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchUserBar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchUserBar.FormattingEnabled = true;
            this.searchUserBar.Location = new System.Drawing.Point(91, 20);
            this.searchUserBar.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.searchUserBar.Name = "searchUserBar";
            this.searchUserBar.Size = new System.Drawing.Size(346, 31);
            this.searchUserBar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchForCb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(532, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 68);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mi alapján?";
            // 
            // searchForCb
            // 
            this.searchForCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchForCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchForCb.FormattingEnabled = true;
            this.searchForCb.Items.AddRange(new object[] {
            "Azonosító"});
            this.searchForCb.Location = new System.Drawing.Point(42, 26);
            this.searchForCb.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.searchForCb.Name = "searchForCb";
            this.searchForCb.Size = new System.Drawing.Size(129, 23);
            this.searchForCb.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chooseUserBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.notRegisteredBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 563);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 100);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // chooseUserBtn
            // 
            this.chooseUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chooseUserBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.chooseUserBtn.FlatAppearance.BorderSize = 0;
            this.chooseUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseUserBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseUserBtn.ForeColor = System.Drawing.Color.White;
            this.chooseUserBtn.Location = new System.Drawing.Point(720, 30);
            this.chooseUserBtn.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.chooseUserBtn.Name = "chooseUserBtn";
            this.chooseUserBtn.Size = new System.Drawing.Size(146, 40);
            this.chooseUserBtn.TabIndex = 8;
            this.chooseUserBtn.Text = "Kiválaszt";
            this.chooseUserBtn.UseVisualStyleBackColor = false;
            // 
            // notRegisteredBtn
            // 
            this.notRegisteredBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.notRegisteredBtn.BackColor = System.Drawing.Color.White;
            this.notRegisteredBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.notRegisteredBtn.FlatAppearance.BorderSize = 3;
            this.notRegisteredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notRegisteredBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notRegisteredBtn.ForeColor = System.Drawing.Color.Black;
            this.notRegisteredBtn.Location = new System.Drawing.Point(113, 30);
            this.notRegisteredBtn.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.notRegisteredBtn.Name = "notRegisteredBtn";
            this.notRegisteredBtn.Size = new System.Drawing.Size(303, 40);
            this.notRegisteredBtn.TabIndex = 13;
            this.notRegisteredBtn.Text = "Nem regisztrált felhasználó";
            this.notRegisteredBtn.UseVisualStyleBackColor = false;
            // 
            // ticketSellerDataEntry
            // 
            this.ticketSellerDataEntry.Controls.Add(this.tableLayoutPanel6);
            this.ticketSellerDataEntry.Controls.Add(this.tableLayoutPanel4);
            this.ticketSellerDataEntry.Location = new System.Drawing.Point(4, 5);
            this.ticketSellerDataEntry.Name = "ticketSellerDataEntry";
            this.ticketSellerDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.ticketSellerDataEntry.Size = new System.Drawing.Size(1064, 666);
            this.ticketSellerDataEntry.TabIndex = 1;
            this.ticketSellerDataEntry.Text = "Jegy kiválasztása";
            this.ticketSellerDataEntry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.chooseTicketGb, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1058, 560);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // chooseTicketGb
            // 
            this.chooseTicketGb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseTicketGb.Controls.Add(this.preTicketTicketOrSubCb);
            this.chooseTicketGb.Controls.Add(this.ticketOrSubscriptionLb);
            this.chooseTicketGb.Controls.Add(this.label2);
            this.chooseTicketGb.Controls.Add(this.preTicketDestinationsCb);
            this.chooseTicketGb.Controls.Add(this.destinationLb);
            this.chooseTicketGb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseTicketGb.Location = new System.Drawing.Point(184, 83);
            this.chooseTicketGb.Margin = new System.Windows.Forms.Padding(50);
            this.chooseTicketGb.Name = "chooseTicketGb";
            this.chooseTicketGb.Size = new System.Drawing.Size(690, 394);
            this.chooseTicketGb.TabIndex = 0;
            this.chooseTicketGb.TabStop = false;
            this.chooseTicketGb.Text = "Jegy kiválasztása";
            // 
            // preTicketTicketOrSubCb
            // 
            this.preTicketTicketOrSubCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preTicketTicketOrSubCb.FormattingEnabled = true;
            this.preTicketTicketOrSubCb.Location = new System.Drawing.Point(255, 196);
            this.preTicketTicketOrSubCb.Name = "preTicketTicketOrSubCb";
            this.preTicketTicketOrSubCb.Size = new System.Drawing.Size(285, 29);
            this.preTicketTicketOrSubCb.TabIndex = 7;
            // 
            // ticketOrSubscriptionLb
            // 
            this.ticketOrSubscriptionLb.AutoSize = true;
            this.ticketOrSubscriptionLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketOrSubscriptionLb.Location = new System.Drawing.Point(23, 196);
            this.ticketOrSubscriptionLb.Name = "ticketOrSubscriptionLb";
            this.ticketOrSubscriptionLb.Size = new System.Drawing.Size(126, 25);
            this.ticketOrSubscriptionLb.TabIndex = 6;
            this.ticketOrSubscriptionLb.Text = "Jegy / bérlet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 3;
            // 
            // preTicketDestinationsCb
            // 
            this.preTicketDestinationsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preTicketDestinationsCb.FormattingEnabled = true;
            this.preTicketDestinationsCb.Location = new System.Drawing.Point(179, 108);
            this.preTicketDestinationsCb.Name = "preTicketDestinationsCb";
            this.preTicketDestinationsCb.Size = new System.Drawing.Size(258, 29);
            this.preTicketDestinationsCb.TabIndex = 2;
            // 
            // destinationLb
            // 
            this.destinationLb.AutoSize = true;
            this.destinationLb.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinationLb.Location = new System.Drawing.Point(23, 108);
            this.destinationLb.Name = "destinationLb";
            this.destinationLb.Size = new System.Drawing.Size(46, 25);
            this.destinationLb.TabIndex = 1;
            this.destinationLb.Text = "Cél:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.preTicketBackBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.preTicketNextBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 563);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1058, 100);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // preTicketBackBtn
            // 
            this.preTicketBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.preTicketBackBtn.BackColor = System.Drawing.Color.White;
            this.preTicketBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.preTicketBackBtn.FlatAppearance.BorderSize = 3;
            this.preTicketBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preTicketBackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preTicketBackBtn.ForeColor = System.Drawing.Color.Black;
            this.preTicketBackBtn.Location = new System.Drawing.Point(191, 25);
            this.preTicketBackBtn.Margin = new System.Windows.Forms.Padding(5, 25, 5, 25);
            this.preTicketBackBtn.Name = "preTicketBackBtn";
            this.preTicketBackBtn.Size = new System.Drawing.Size(146, 50);
            this.preTicketBackBtn.TabIndex = 10;
            this.preTicketBackBtn.Text = "Vissza";
            this.preTicketBackBtn.UseVisualStyleBackColor = false;
            // 
            // preTicketNextBtn
            // 
            this.preTicketNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.preTicketNextBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.preTicketNextBtn.FlatAppearance.BorderSize = 0;
            this.preTicketNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preTicketNextBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preTicketNextBtn.ForeColor = System.Drawing.Color.White;
            this.preTicketNextBtn.Location = new System.Drawing.Point(720, 25);
            this.preTicketNextBtn.Margin = new System.Windows.Forms.Padding(5, 25, 5, 25);
            this.preTicketNextBtn.Name = "preTicketNextBtn";
            this.preTicketNextBtn.Size = new System.Drawing.Size(146, 50);
            this.preTicketNextBtn.TabIndex = 9;
            this.preTicketNextBtn.Text = "Tovább";
            this.preTicketNextBtn.UseVisualStyleBackColor = false;
            // 
            // ticketSellerConfirmTicket
            // 
            this.ticketSellerConfirmTicket.Controls.Add(this.tableLayoutPanel7);
            this.ticketSellerConfirmTicket.Controls.Add(this.confirmTicketScreen);
            this.ticketSellerConfirmTicket.Controls.Add(this.tableLayoutPanel5);
            this.ticketSellerConfirmTicket.Location = new System.Drawing.Point(4, 5);
            this.ticketSellerConfirmTicket.Name = "ticketSellerConfirmTicket";
            this.ticketSellerConfirmTicket.Size = new System.Drawing.Size(1064, 666);
            this.ticketSellerConfirmTicket.TabIndex = 2;
            this.ticketSellerConfirmTicket.Text = "Jegy megvásárlása";
            this.ticketSellerConfirmTicket.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.payWithCashBtn, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.payWithCreditCardBtn, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 524);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1064, 42);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // payWithCashBtn
            // 
            this.payWithCashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.payWithCashBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.payWithCashBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.payWithCashBtn.FlatAppearance.BorderSize = 0;
            this.payWithCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payWithCashBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payWithCashBtn.ForeColor = System.Drawing.Color.White;
            this.payWithCashBtn.Location = new System.Drawing.Point(153, 0);
            this.payWithCashBtn.Margin = new System.Windows.Forms.Padding(0);
            this.payWithCashBtn.Name = "payWithCashBtn";
            this.payWithCashBtn.Size = new System.Drawing.Size(226, 42);
            this.payWithCashBtn.TabIndex = 13;
            this.payWithCashBtn.Text = "Készpénz";
            this.payWithCashBtn.UseVisualStyleBackColor = false;
            // 
            // payWithCreditCardBtn
            // 
            this.payWithCreditCardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.payWithCreditCardBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.payWithCreditCardBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.payWithCreditCardBtn.FlatAppearance.BorderSize = 0;
            this.payWithCreditCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payWithCreditCardBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payWithCreditCardBtn.ForeColor = System.Drawing.Color.White;
            this.payWithCreditCardBtn.Location = new System.Drawing.Point(685, 0);
            this.payWithCreditCardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.payWithCreditCardBtn.Name = "payWithCreditCardBtn";
            this.payWithCreditCardBtn.Size = new System.Drawing.Size(226, 42);
            this.payWithCreditCardBtn.TabIndex = 14;
            this.payWithCreditCardBtn.Text = "Bankkártya";
            this.payWithCreditCardBtn.UseVisualStyleBackColor = false;
            // 
            // confirmTicketScreen
            // 
            this.confirmTicketScreen.BackColor = System.Drawing.Color.Transparent;
            this.confirmTicketScreen.ColumnCount = 1;
            this.confirmTicketScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.confirmTicketScreen.Controls.Add(this.confirmTicketPanel, 0, 0);
            this.confirmTicketScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmTicketScreen.Location = new System.Drawing.Point(0, 0);
            this.confirmTicketScreen.Name = "confirmTicketScreen";
            this.confirmTicketScreen.RowCount = 1;
            this.confirmTicketScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.confirmTicketScreen.Size = new System.Drawing.Size(1064, 566);
            this.confirmTicketScreen.TabIndex = 15;
            // 
            // confirmTicketPanel
            // 
            this.confirmTicketPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmTicketPanel.Location = new System.Drawing.Point(295, 135);
            this.confirmTicketPanel.Margin = new System.Windows.Forms.Padding(50);
            this.confirmTicketPanel.Name = "confirmTicketPanel";
            this.confirmTicketPanel.Size = new System.Drawing.Size(474, 296);
            this.confirmTicketPanel.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.confirmTicketBackBtn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.confirmTicketBuyBtn, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 566);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1064, 100);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // confirmTicketBackBtn
            // 
            this.confirmTicketBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.confirmTicketBackBtn.BackColor = System.Drawing.Color.White;
            this.confirmTicketBackBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.confirmTicketBackBtn.FlatAppearance.BorderSize = 3;
            this.confirmTicketBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmTicketBackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmTicketBackBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmTicketBackBtn.Location = new System.Drawing.Point(193, 25);
            this.confirmTicketBackBtn.Margin = new System.Windows.Forms.Padding(5, 25, 5, 25);
            this.confirmTicketBackBtn.Name = "confirmTicketBackBtn";
            this.confirmTicketBackBtn.Size = new System.Drawing.Size(146, 50);
            this.confirmTicketBackBtn.TabIndex = 12;
            this.confirmTicketBackBtn.Text = "Vissza";
            this.confirmTicketBackBtn.UseVisualStyleBackColor = false;
            // 
            // confirmTicketBuyBtn
            // 
            this.confirmTicketBuyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.confirmTicketBuyBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.confirmTicketBuyBtn.FlatAppearance.BorderSize = 0;
            this.confirmTicketBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmTicketBuyBtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmTicketBuyBtn.ForeColor = System.Drawing.Color.White;
            this.confirmTicketBuyBtn.Location = new System.Drawing.Point(725, 25);
            this.confirmTicketBuyBtn.Margin = new System.Windows.Forms.Padding(5, 25, 5, 25);
            this.confirmTicketBuyBtn.Name = "confirmTicketBuyBtn";
            this.confirmTicketBuyBtn.Size = new System.Drawing.Size(146, 50);
            this.confirmTicketBuyBtn.TabIndex = 11;
            this.confirmTicketBuyBtn.Text = "Vásárlás";
            this.confirmTicketBuyBtn.UseVisualStyleBackColor = false;
            // 
            // TicketSellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 675);
            this.Controls.Add(this.ticketSellerTbc);
            this.Name = "TicketSellView";
            this.Text = "Jegy eladás";
            this.ticketSellerTbc.ResumeLayout(false);
            this.ticketSellerSearch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.userDetailsGb.ResumeLayout(false);
            this.userDetailsGb.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ticketSellerDataEntry.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.chooseTicketGb.ResumeLayout(false);
            this.chooseTicketGb.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ticketSellerConfirmTicket.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.confirmTicketScreen.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl ticketSellerTbc;
        private TabPage ticketSellerSearch;
        private GroupBox userDetailsGb;
        private Label userBTicketsVal;
        private Label userBTicketsLb;
        private Label userTypeVal;
        private Label userTypeLb;
        private Label userAgeVal;
        private Label userAgeLb;
        private Label userNameVal;
        private Label userNameLb;
        private Button chooseUserBtn;
        private Button searchUserBtn;
        private TabPage ticketSellerDataEntry;
        private GroupBox chooseTicketGb;
        private ComboBox searchUserBar;
        private Button preTicketBackBtn;
        private Button preTicketNextBtn;
        private ComboBox preTicketTicketOrSubCb;
        private Label ticketOrSubscriptionLb;
        private Label label2;
        private ComboBox preTicketDestinationsCb;
        private Label destinationLb;
        private Button notRegisteredBtn;
        private TabPage ticketSellerConfirmTicket;
        private Button confirmTicketBackBtn;
        private Button confirmTicketBuyBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel confirmTicketScreen;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Button payWithCashBtn;
        private Button payWithCreditCardBtn;
        private Panel confirmTicketPanel;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel1;
        private Label label1;
        private ComboBox searchForCb;
    }
}