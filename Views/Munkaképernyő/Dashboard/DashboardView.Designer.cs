using System.Windows.Forms.DataVisualization.Charting;

namespace TicketSeller.Views.Munkaképernyő.Statistics
{
    partial class DashboardView
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updatedLb = new System.Windows.Forms.Label();
            this.notificationsLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diagrammTbp = new System.Windows.Forms.TableLayoutPanel();
            this.weeklyFinanceTbp = new System.Windows.Forms.TableLayoutPanel();
            this.updateBtn = new System.Windows.Forms.Button();

            //chart1
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            //chart2
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();

            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.diagrammTbp.SuspendLayout();
            this.weeklyFinanceTbp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.updatedLb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.notificationsLb, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 46);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // updatedLb
            // 
            this.updatedLb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updatedLb.AutoSize = true;
            this.updatedLb.ForeColor = System.Drawing.Color.White;
            this.updatedLb.Location = new System.Drawing.Point(743, 15);
            this.updatedLb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.updatedLb.Name = "updatedLb";
            this.updatedLb.Size = new System.Drawing.Size(52, 15);
            this.updatedLb.TabIndex = 0;
            this.updatedLb.Text = "Frissítve:";
            // 
            // notificationsLb
            // 
            this.notificationsLb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notificationsLb.AutoSize = true;
            this.notificationsLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificationsLb.ForeColor = System.Drawing.Color.White;
            this.notificationsLb.Location = new System.Drawing.Point(3, 12);
            this.notificationsLb.Name = "notificationsLb";
            this.notificationsLb.Size = new System.Drawing.Size(32, 21);
            this.notificationsLb.TabIndex = 1;
            this.notificationsLb.Text = "✔";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diagrammTbp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 404);
            this.panel1.TabIndex = 2;
            // 
            // diagrammTbp
            // 
            this.diagrammTbp.BackColor = System.Drawing.Color.White;
            this.diagrammTbp.ColumnCount = 2;
            this.diagrammTbp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.diagrammTbp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.diagrammTbp.Controls.Add(this.weeklyFinanceTbp, 1, 0);
            this.diagrammTbp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagrammTbp.Location = new System.Drawing.Point(0, 0);
            this.diagrammTbp.Name = "diagrammTbp";
            this.diagrammTbp.RowCount = 1;
            this.diagrammTbp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.diagrammTbp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.diagrammTbp.Size = new System.Drawing.Size(800, 404);
            this.diagrammTbp.TabIndex = 1;
            // 
            // weeklyFinanceTbp
            // 
            this.weeklyFinanceTbp.ColumnCount = 1;
            this.weeklyFinanceTbp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weeklyFinanceTbp.Controls.Add(this.updateBtn, 0, 0);
            this.weeklyFinanceTbp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeklyFinanceTbp.Location = new System.Drawing.Point(403, 3);
            this.weeklyFinanceTbp.Name = "weeklyFinanceTbp";
            this.weeklyFinanceTbp.RowCount = 2;
            this.weeklyFinanceTbp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.weeklyFinanceTbp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.weeklyFinanceTbp.Size = new System.Drawing.Size(394, 398);
            this.weeklyFinanceTbp.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateBtn.Location = new System.Drawing.Point(316, 8);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Frissítés";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Margin = new Padding(10);
            this.chart1.Name = "Today ticket sell statistics";
            this.chart1.Size = new System.Drawing.Size(711, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Today ticket sell statistics";
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            // 
            // chart2
            //
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Margin = new Padding(10);
            this.chart2.Location = new System.Drawing.Point(205, 122);
            this.chart2.Name = "Weekly ticket sell statistics";
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "Weekly ticket sell statistics";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.diagrammTbp.Controls.Add(this.chart1);
            this.weeklyFinanceTbp.Controls.Add(this.chart2);
            this.chart1.Dock = DockStyle.Fill;
            this.chart2.Dock = DockStyle.Fill;
            this.Name = "DashboardView";
            this.Text = "Kezdőlap";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.diagrammTbp.ResumeLayout(false);
            this.weeklyFinanceTbp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label updatedLb;
        private Panel panel1;
        private Button refreshStatisticsBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label notificationsLb;
        private TableLayoutPanel diagrammTbp;
        private TableLayoutPanel weeklyFinanceTbp;
        private Button updateBtn;
    }
}