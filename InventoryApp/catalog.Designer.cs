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
            this.catalog_panel = new System.Windows.Forms.Panel();
            this.game_combobox = new System.Windows.Forms.ComboBox();
            this.next_catalog = new System.Windows.Forms.Button();
            this.prev_catalog = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.catalog_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_label = new System.Windows.Forms.Label();
            this.catalog_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog_panel
            // 
            this.catalog_panel.Controls.Add(this.game_combobox);
            this.catalog_panel.Controls.Add(this.next_catalog);
            this.catalog_panel.Controls.Add(this.prev_catalog);
            this.catalog_panel.Controls.Add(this.tableLayoutPanel1);
            this.catalog_panel.Controls.Add(this.splitContainer1);
            this.catalog_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalog_panel.Location = new System.Drawing.Point(0, 0);
            this.catalog_panel.Name = "catalog_panel";
            this.catalog_panel.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.TabIndex = 0;
            // 
            // game_combobox
            // 
            this.game_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.game_combobox.FormattingEnabled = true;
            this.game_combobox.Items.AddRange(new object[] {
            "Yu-Gi-Oh",
            "Magic The Gathering",
            "Pokemon"});
            this.game_combobox.Location = new System.Drawing.Point(53, 64);
            this.game_combobox.Name = "game_combobox";
            this.game_combobox.Size = new System.Drawing.Size(121, 23);
            this.game_combobox.TabIndex = 9;
            this.game_combobox.SelectedIndexChanged += new System.EventHandler(this.game_SelectedIndexChanged);
            // 
            // next_catalog
            // 
            this.next_catalog.Location = new System.Drawing.Point(766, 671);
            this.next_catalog.Name = "next_catalog";
            this.next_catalog.Size = new System.Drawing.Size(99, 23);
            this.next_catalog.TabIndex = 8;
            this.next_catalog.Text = "Next Page";
            this.next_catalog.UseVisualStyleBackColor = true;
            this.next_catalog.Click += new System.EventHandler(this.next_catalog_Click);
            // 
            // prev_catalog
            // 
            this.prev_catalog.Location = new System.Drawing.Point(649, 671);
            this.prev_catalog.Name = "prev_catalog";
            this.prev_catalog.Size = new System.Drawing.Size(99, 23);
            this.prev_catalog.TabIndex = 7;
            this.prev_catalog.Text = "Previous Page";
            this.prev_catalog.UseVisualStyleBackColor = true;
            this.prev_catalog.Click += new System.EventHandler(this.prev_catalog_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.84112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.158878F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.search_box, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_button, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(177, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 44);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // search_box
            // 
            this.search_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_box.Location = new System.Drawing.Point(3, 3);
            this.search_box.Name = "search_box";
            this.search_box.PlaceholderText = "Card Name";
            this.search_box.Size = new System.Drawing.Size(462, 23);
            this.search_box.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.AutoSize = true;
            this.search_button.Location = new System.Drawing.Point(518, 3);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(208, 25);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(47, 181);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.catalog_view);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.filter_label);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 348);
            this.splitContainer1.SplitterDistance = 818;
            this.splitContainer1.TabIndex = 5;
            // 
            // catalog_view
            // 
            this.catalog_view.AllowUserToAddRows = false;
            this.catalog_view.AllowUserToDeleteRows = false;
            this.catalog_view.AllowUserToResizeColumns = false;
            this.catalog_view.AllowUserToResizeRows = false;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.catalog_view.Location = new System.Drawing.Point(-3, 0);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(818, 348);
            this.catalog_view.TabIndex = 0;
            this.catalog_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_view_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // filter_label
            // 
            this.filter_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter_label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter_label.Location = new System.Drawing.Point(2, 0);
            this.filter_label.Name = "filter_label";
            this.filter_label.Size = new System.Drawing.Size(351, 63);
            this.filter_label.TabIndex = 3;
            this.filter_label.Text = "Filters";
            this.filter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.catalog_panel);
            this.Name = "catalog";
            this.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.ResumeLayout(false);

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
        private Button next_catalog;
        private Button prev_catalog;
        private ComboBox game_combobox;
    }
}
