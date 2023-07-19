namespace InventoryApp
{
    partial class catalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            catalog_panel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            search_box = new TextBox();
            search_button = new Button();
            splitContainer1 = new SplitContainer();
            catalog_view = new DataGridView();
            label1 = new Label();
            filter_label = new Label();
            catalog_panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)catalog_view).BeginInit();
            SuspendLayout();
            // 
            // catalog_panel
            // 
            catalog_panel.Controls.Add(tableLayoutPanel1);
            catalog_panel.Controls.Add(splitContainer1);
            catalog_panel.Dock = DockStyle.Fill;
            catalog_panel.Location = new Point(0, 0);
            catalog_panel.Name = "catalog_panel";
            catalog_panel.Size = new Size(1280, 720);
            catalog_panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.84112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.158878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.Controls.Add(search_box, 0, 0);
            tableLayoutPanel1.Controls.Add(search_button, 2, 0);
            tableLayoutPanel1.Location = new Point(112, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1000, 44);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // search_box
            // 
            search_box.Dock = DockStyle.Fill;
            search_box.Location = new Point(3, 3);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Card Name";
            search_box.Size = new Size(462, 23);
            search_box.TabIndex = 1;
            // 
            // search_button
            // 
            search_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_button.AutoSize = true;
            search_button.Location = new Point(518, 3);
            search_button.Name = "search_button";
            search_button.Size = new Size(208, 25);
            search_button.TabIndex = 2;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(47, 181);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(catalog_view);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(filter_label);
            splitContainer1.Size = new Size(1175, 348);
            splitContainer1.SplitterDistance = 818;
            splitContainer1.TabIndex = 5;
            // 
            // catalog_view
            // 
            catalog_view.AllowUserToAddRows = false;
            catalog_view.AllowUserToDeleteRows = false;
            catalog_view.AllowUserToResizeColumns = false;
            catalog_view.AllowUserToResizeRows = false;
            catalog_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            catalog_view.Dock = DockStyle.Fill;
            catalog_view.Location = new Point(0, 0);
            catalog_view.Name = "catalog_view";
            catalog_view.RowTemplate.Height = 25;
            catalog_view.Size = new Size(818, 348);
            catalog_view.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 98);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // filter_label
            // 
            filter_label.Anchor = AnchorStyles.None;
            filter_label.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            filter_label.Location = new Point(2, 0);
            filter_label.Name = "filter_label";
            filter_label.Size = new Size(351, 63);
            filter_label.TabIndex = 3;
            filter_label.Text = "Filters";
            filter_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(catalog_panel);
            Name = "catalog";
            Size = new Size(1280, 720);
            catalog_panel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)catalog_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel catalog_panel;
        private DataGridView catalog_view;
        private TextBox search_box;
        private Button search_button;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label filter_label;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
