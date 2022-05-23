namespace TicketSeller.Views.Kezdőképernyő
{
    partial class CashSelectionView
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
            this.servicesLb = new System.Windows.Forms.ListBox();
            this.selectedLb = new System.Windows.Forms.ListBox();
            this.confirmViewBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityLb = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesLb
            // 
            this.servicesLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesLb.FormattingEnabled = true;
            this.servicesLb.ItemHeight = 15;
            this.servicesLb.Location = new System.Drawing.Point(12, 9);
            this.servicesLb.Name = "servicesLb";
            this.servicesLb.Size = new System.Drawing.Size(776, 109);
            this.servicesLb.TabIndex = 1;
            // 
            // selectedLb
            // 
            this.selectedLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedLb.FormattingEnabled = true;
            this.selectedLb.ItemHeight = 15;
            this.selectedLb.Location = new System.Drawing.Point(12, 11);
            this.selectedLb.Name = "selectedLb";
            this.selectedLb.Size = new System.Drawing.Size(776, 109);
            this.selectedLb.TabIndex = 2;
            // 
            // confirmViewBtn
            // 
            this.confirmViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmViewBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.confirmViewBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmViewBtn.FlatAppearance.BorderSize = 0;
            this.confirmViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmViewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmViewBtn.ForeColor = System.Drawing.Color.White;
            this.confirmViewBtn.Location = new System.Drawing.Point(357, 13);
            this.confirmViewBtn.Name = "confirmViewBtn";
            this.confirmViewBtn.Size = new System.Drawing.Size(99, 39);
            this.confirmViewBtn.TabIndex = 3;
            this.confirmViewBtn.Text = "Kiválaszt";
            this.confirmViewBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmViewBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 4;
            // 
            // cityLb
            // 
            this.cityLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityLb.FormattingEnabled = true;
            this.cityLb.ItemHeight = 15;
            this.cityLb.Location = new System.Drawing.Point(12, 9);
            this.cityLb.Name = "cityLb";
            this.cityLb.Size = new System.Drawing.Size(776, 139);
            this.cityLb.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cityLb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 166);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.servicesLb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 128);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.selectedLb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 133);
            this.panel4.TabIndex = 7;
            // 
            // CashSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashSelectionView";
            this.Text = "Kassza választás";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox servicesLb;
        private ListBox selectedLb;
        private Button confirmViewBtn;
        private Panel panel1;
        private ListBox cityLb;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}