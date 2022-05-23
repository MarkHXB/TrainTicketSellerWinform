namespace TicketSeller.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cashierInfo = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashboardLb = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.PictureBox();
            this.sellTicketPanel = new System.Windows.Forms.Panel();
            this.sellTicketLb = new System.Windows.Forms.Label();
            this.sellTicketBtn = new System.Windows.Forms.PictureBox();
            this.statisticsPanel = new System.Windows.Forms.Panel();
            this.todayFinanceLbl = new System.Windows.Forms.Label();
            this.todayFinanceBtn = new System.Windows.Forms.PictureBox();
            this.mangerPanel = new System.Windows.Forms.Panel();
            this.userManagerLb = new System.Windows.Forms.Label();
            this.userManagerBtn = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuPnl.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBtn)).BeginInit();
            this.sellTicketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellTicketBtn)).BeginInit();
            this.statisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayFinanceBtn)).BeginInit();
            this.mangerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 92);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cashierInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 92);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cashierInfo
            // 
            this.cashierInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cashierInfo.AutoSize = true;
            this.cashierInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierInfo.ForeColor = System.Drawing.Color.White;
            this.cashierInfo.Location = new System.Drawing.Point(1052, 36);
            this.cashierInfo.Margin = new System.Windows.Forms.Padding(20);
            this.cashierInfo.Name = "cashierInfo";
            this.cashierInfo.Size = new System.Drawing.Size(0, 20);
            this.cashierInfo.TabIndex = 1;
            // 
            // mainTitle
            // 
            this.mainTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(20, 30);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(20);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(0, 31);
            this.mainTitle.TabIndex = 0;
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuPnl.Controls.Add(this.dashboardPanel);
            this.menuPnl.Controls.Add(this.sellTicketPanel);
            this.menuPnl.Controls.Add(this.statisticsPanel);
            this.menuPnl.Controls.Add(this.mangerPanel);
            this.menuPnl.Controls.Add(this.menuBtn);
            this.menuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPnl.Location = new System.Drawing.Point(0, 92);
            this.menuPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPnl.MaximumSize = new System.Drawing.Size(250, 0);
            this.menuPnl.MinimumSize = new System.Drawing.Size(84, 0);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(250, 583);
            this.menuPnl.TabIndex = 1;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.dashboardLb);
            this.dashboardPanel.Controls.Add(this.dashboardBtn);
            this.dashboardPanel.Location = new System.Drawing.Point(0, 84);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(244, 94);
            this.dashboardPanel.TabIndex = 5;
            // 
            // dashboardLb
            // 
            this.dashboardLb.AutoSize = true;
            this.dashboardLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardLb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboardLb.ForeColor = System.Drawing.Color.White;
            this.dashboardLb.Location = new System.Drawing.Point(98, 30);
            this.dashboardLb.Name = "dashboardLb";
            this.dashboardLb.Size = new System.Drawing.Size(103, 30);
            this.dashboardLb.TabIndex = 2;
            this.dashboardLb.Text = "Kezdőlap";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.Image = global::TicketSeller.Properties.Resources.white_home;
            this.dashboardBtn.Location = new System.Drawing.Point(8, 24);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(60, 40);
            this.dashboardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.TabStop = false;
            // 
            // sellTicketPanel
            // 
            this.sellTicketPanel.Controls.Add(this.sellTicketLb);
            this.sellTicketPanel.Controls.Add(this.sellTicketBtn);
            this.sellTicketPanel.Location = new System.Drawing.Point(0, 182);
            this.sellTicketPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellTicketPanel.Name = "sellTicketPanel";
            this.sellTicketPanel.Size = new System.Drawing.Size(244, 94);
            this.sellTicketPanel.TabIndex = 4;
            // 
            // sellTicketLb
            // 
            this.sellTicketLb.AutoSize = true;
            this.sellTicketLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellTicketLb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellTicketLb.ForeColor = System.Drawing.Color.White;
            this.sellTicketLb.Location = new System.Drawing.Point(98, 30);
            this.sellTicketLb.Name = "sellTicketLb";
            this.sellTicketLb.Size = new System.Drawing.Size(124, 30);
            this.sellTicketLb.TabIndex = 2;
            this.sellTicketLb.Text = "Jegy eladás";
            // 
            // sellTicketBtn
            // 
            this.sellTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellTicketBtn.Image = global::TicketSeller.Properties.Resources.white_ticket;
            this.sellTicketBtn.Location = new System.Drawing.Point(8, 24);
            this.sellTicketBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellTicketBtn.Name = "sellTicketBtn";
            this.sellTicketBtn.Size = new System.Drawing.Size(60, 40);
            this.sellTicketBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellTicketBtn.TabIndex = 1;
            this.sellTicketBtn.TabStop = false;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsPanel.Controls.Add(this.todayFinanceLbl);
            this.statisticsPanel.Controls.Add(this.todayFinanceBtn);
            this.statisticsPanel.Location = new System.Drawing.Point(0, 378);
            this.statisticsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(244, 94);
            this.statisticsPanel.TabIndex = 3;
            // 
            // todayFinanceLbl
            // 
            this.todayFinanceLbl.AutoSize = true;
            this.todayFinanceLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todayFinanceLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todayFinanceLbl.ForeColor = System.Drawing.Color.White;
            this.todayFinanceLbl.Location = new System.Drawing.Point(98, 30);
            this.todayFinanceLbl.Name = "todayFinanceLbl";
            this.todayFinanceLbl.Size = new System.Drawing.Size(136, 30);
            this.todayFinanceLbl.TabIndex = 2;
            this.todayFinanceLbl.Text = "Napi bevétel";
            // 
            // todayFinanceBtn
            // 
            this.todayFinanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todayFinanceBtn.Image = global::TicketSeller.Properties.Resources.white_wallet;
            this.todayFinanceBtn.Location = new System.Drawing.Point(8, 24);
            this.todayFinanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todayFinanceBtn.Name = "todayFinanceBtn";
            this.todayFinanceBtn.Size = new System.Drawing.Size(60, 40);
            this.todayFinanceBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.todayFinanceBtn.TabIndex = 1;
            this.todayFinanceBtn.TabStop = false;
            // 
            // mangerPanel
            // 
            this.mangerPanel.Controls.Add(this.userManagerLb);
            this.mangerPanel.Controls.Add(this.userManagerBtn);
            this.mangerPanel.Location = new System.Drawing.Point(0, 280);
            this.mangerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mangerPanel.Name = "mangerPanel";
            this.mangerPanel.Size = new System.Drawing.Size(244, 94);
            this.mangerPanel.TabIndex = 2;
            // 
            // userManagerLb
            // 
            this.userManagerLb.AutoSize = true;
            this.userManagerLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagerLb.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userManagerLb.ForeColor = System.Drawing.Color.White;
            this.userManagerLb.Location = new System.Drawing.Point(82, 33);
            this.userManagerLb.Name = "userManagerLb";
            this.userManagerLb.Size = new System.Drawing.Size(157, 23);
            this.userManagerLb.TabIndex = 2;
            this.userManagerLb.Text = "Felhasználó kezelés";
            // 
            // userManagerBtn
            // 
            this.userManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagerBtn.Image = global::TicketSeller.Properties.Resources.white_edit1;
            this.userManagerBtn.Location = new System.Drawing.Point(8, 24);
            this.userManagerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userManagerBtn.Name = "userManagerBtn";
            this.userManagerBtn.Size = new System.Drawing.Size(60, 40);
            this.userManagerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userManagerBtn.TabIndex = 1;
            this.userManagerBtn.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = global::TicketSeller.Properties.Resources.white_menu;
            this.menuBtn.Location = new System.Drawing.Point(13, 1);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(55, 37);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 0;
            this.menuBtn.TabStop = false;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 675);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1088, 714);
            this.Name = "MainView";
            this.Text = "TicketSeller";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuPnl.ResumeLayout(false);
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBtn)).EndInit();
            this.sellTicketPanel.ResumeLayout(false);
            this.sellTicketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellTicketBtn)).EndInit();
            this.statisticsPanel.ResumeLayout(false);
            this.statisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayFinanceBtn)).EndInit();
            this.mangerPanel.ResumeLayout(false);
            this.mangerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label mainTitle;
        private Panel menuPnl;
        private Panel statisticsPanel;
        private Label todayFinanceLbl;
        private PictureBox todayFinanceBtn;
        private Panel mangerPanel;
        private Label userManagerLb;
        private PictureBox userManagerBtn;
        private PictureBox menuBtn;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel sellTicketPanel;
        private Label sellTicketLb;
        private PictureBox sellTicketBtn;
        private Panel dashboardPanel;
        private Label dashboardLb;
        private PictureBox dashboardBtn;
        private Label cashierInfo;
        private TableLayoutPanel tableLayoutPanel1;
    }
}