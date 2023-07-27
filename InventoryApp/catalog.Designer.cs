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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            catalog_view = new DataGridView();
            label1 = new Label();
            filter_label = new Label();
            next_catalog = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            search_box = new TextBox();
            search_button = new Button();
            prev_catalog = new Button();
            tabPage2 = new TabPage();
            label3 = new Label();
            card_details_panel = new Panel();
            market_price = new TextBox();
            card_rarity = new TextBox();
            set_name = new TextBox();
            label10 = new Label();
            set_code = new TextBox();
            card_race = new TextBox();
            card_type = new TextBox();
            card_name = new TextBox();
            card_id = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            inventory_panel = new Panel();
            card_copies = new TextBox();
            store_price = new TextBox();
            label12 = new Label();
            label11 = new Label();
            CardImage = new PictureBox();
            delete_card = new Button();
            label13 = new Label();
            upate_card = new Button();
            cancel_bttn = new Button();
            catalog_panel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)catalog_view).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            card_details_panel.SuspendLayout();
            inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CardImage).BeginInit();
            SuspendLayout();
            // 
            // catalog_panel
            // 
            catalog_panel.Controls.Add(tabControl1);
            catalog_panel.Dock = DockStyle.Fill;
            catalog_panel.Location = new Point(0, 0);
            catalog_panel.Name = "catalog_panel";
            catalog_panel.Size = new Size(1280, 720);
            catalog_panel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(60, 60);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1280, 720);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleRole = AccessibleRole.None;
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Controls.Add(next_catalog);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(prev_catalog);
            tabPage1.Location = new Point(4, 64);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1272, 652);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(108, 162);
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
            splitContainer1.Size = new Size(1035, 336);
            splitContainer1.SplitterDistance = 718;
            splitContainer1.TabIndex = 5;
            // 
            // catalog_view
            // 
            catalog_view.AllowUserToAddRows = false;
            catalog_view.AllowUserToDeleteRows = false;
            catalog_view.AllowUserToResizeColumns = false;
            catalog_view.AllowUserToResizeRows = false;
            catalog_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            filter_label.Location = new Point(-18, -6);
            filter_label.Name = "filter_label";
            filter_label.Size = new Size(351, 63);
            filter_label.TabIndex = 3;
            filter_label.Text = "Filters";
            filter_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // next_catalog
            // 
            next_catalog.Location = new Point(475, 533);
            next_catalog.Name = "next_catalog";
            next_catalog.Size = new Size(99, 23);
            next_catalog.TabIndex = 8;
            next_catalog.Text = "Next Page";
            next_catalog.UseVisualStyleBackColor = true;
            next_catalog.Click += next_catalog_Click;
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
            tableLayoutPanel1.Location = new Point(123, -63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(549, 44);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // search_box
            // 
            search_box.Dock = DockStyle.Fill;
            search_box.Location = new Point(3, 3);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Card Name";
            search_box.Size = new Size(53, 23);
            search_box.TabIndex = 1;
            // 
            // search_button
            // 
            search_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_button.AutoSize = true;
            search_button.Location = new Point(67, 3);
            search_button.Name = "search_button";
            search_button.Size = new Size(208, 25);
            search_button.TabIndex = 2;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            // 
            // prev_catalog
            // 
            prev_catalog.Location = new Point(358, 533);
            prev_catalog.Name = "prev_catalog";
            prev_catalog.Size = new Size(99, 23);
            prev_catalog.TabIndex = 7;
            prev_catalog.Text = "Previous Page";
            prev_catalog.UseVisualStyleBackColor = true;
            prev_catalog.Click += prev_catalog_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(card_details_panel);
            tabPage2.Controls.Add(inventory_panel);
            tabPage2.Controls.Add(CardImage);
            tabPage2.Controls.Add(delete_card);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(upate_card);
            tabPage2.Controls.Add(cancel_bttn);
            tabPage2.Location = new Point(4, 64);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1272, 652);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(26, 28, 60);
            label3.Location = new Point(516, 354);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 23;
            label3.Text = "Inventory:";
            // 
            // card_details_panel
            // 
            card_details_panel.BorderStyle = BorderStyle.FixedSingle;
            card_details_panel.Controls.Add(market_price);
            card_details_panel.Controls.Add(card_rarity);
            card_details_panel.Controls.Add(set_name);
            card_details_panel.Controls.Add(label10);
            card_details_panel.Controls.Add(set_code);
            card_details_panel.Controls.Add(card_race);
            card_details_panel.Controls.Add(card_type);
            card_details_panel.Controls.Add(card_name);
            card_details_panel.Controls.Add(card_id);
            card_details_panel.Controls.Add(label9);
            card_details_panel.Controls.Add(label8);
            card_details_panel.Controls.Add(label7);
            card_details_panel.Controls.Add(label6);
            card_details_panel.Controls.Add(label5);
            card_details_panel.Controls.Add(label4);
            card_details_panel.Controls.Add(label2);
            card_details_panel.Location = new Point(516, 54);
            card_details_panel.Name = "card_details_panel";
            card_details_panel.Size = new Size(508, 284);
            card_details_panel.TabIndex = 22;
            // 
            // market_price
            // 
            market_price.Cursor = Cursors.No;
            market_price.Location = new Point(142, 233);
            market_price.Name = "market_price";
            market_price.ReadOnly = true;
            market_price.Size = new Size(100, 23);
            market_price.TabIndex = 19;
            // 
            // card_rarity
            // 
            card_rarity.Cursor = Cursors.No;
            card_rarity.Location = new Point(17, 233);
            card_rarity.Name = "card_rarity";
            card_rarity.ReadOnly = true;
            card_rarity.Size = new Size(100, 23);
            card_rarity.TabIndex = 18;
            // 
            // set_name
            // 
            set_name.Cursor = Cursors.No;
            set_name.Location = new Point(142, 168);
            set_name.Name = "set_name";
            set_name.ReadOnly = true;
            set_name.Size = new Size(300, 23);
            set_name.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(143, 209);
            label10.Name = "label10";
            label10.Size = new Size(102, 21);
            label10.TabIndex = 11;
            label10.Text = "Market Price";
            // 
            // set_code
            // 
            set_code.Cursor = Cursors.No;
            set_code.Location = new Point(17, 168);
            set_code.Name = "set_code";
            set_code.ReadOnly = true;
            set_code.Size = new Size(100, 23);
            set_code.TabIndex = 16;
            // 
            // card_race
            // 
            card_race.Cursor = Cursors.No;
            card_race.Location = new Point(17, 98);
            card_race.Name = "card_race";
            card_race.ReadOnly = true;
            card_race.Size = new Size(100, 23);
            card_race.TabIndex = 15;
            // 
            // card_type
            // 
            card_type.Cursor = Cursors.No;
            card_type.Location = new Point(142, 98);
            card_type.Name = "card_type";
            card_type.ReadOnly = true;
            card_type.Size = new Size(100, 23);
            card_type.TabIndex = 14;
            // 
            // card_name
            // 
            card_name.Cursor = Cursors.No;
            card_name.Location = new Point(142, 33);
            card_name.Name = "card_name";
            card_name.ReadOnly = true;
            card_name.Size = new Size(300, 23);
            card_name.TabIndex = 13;
            // 
            // card_id
            // 
            card_id.Cursor = Cursors.No;
            card_id.Location = new Point(17, 33);
            card_id.Name = "card_id";
            card_id.ReadOnly = true;
            card_id.Size = new Size(100, 23);
            card_id.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(17, 209);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 11;
            label9.Text = "Rarity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(143, 144);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 10;
            label8.Text = "Set Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(16, 144);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 9;
            label7.Text = "Set Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(142, 74);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 8;
            label6.Text = "Card Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 7;
            label5.Text = "Card Race";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(142, 9);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Card Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 5;
            label2.Text = "Card ID";
            // 
            // inventory_panel
            // 
            inventory_panel.BorderStyle = BorderStyle.FixedSingle;
            inventory_panel.Controls.Add(card_copies);
            inventory_panel.Controls.Add(store_price);
            inventory_panel.Controls.Add(label12);
            inventory_panel.Controls.Add(label11);
            inventory_panel.Location = new Point(516, 380);
            inventory_panel.Name = "inventory_panel";
            inventory_panel.Size = new Size(508, 99);
            inventory_panel.TabIndex = 21;
            // 
            // card_copies
            // 
            card_copies.Cursor = Cursors.No;
            card_copies.Location = new Point(142, 38);
            card_copies.Name = "card_copies";
            card_copies.ReadOnly = true;
            card_copies.Size = new Size(100, 23);
            card_copies.TabIndex = 20;
            // 
            // store_price
            // 
            store_price.Cursor = Cursors.No;
            store_price.Location = new Point(17, 38);
            store_price.Name = "store_price";
            store_price.ReadOnly = true;
            store_price.Size = new Size(100, 23);
            store_price.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(142, 14);
            label12.Name = "label12";
            label12.Size = new Size(60, 21);
            label12.TabIndex = 13;
            label12.Text = "Copies";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(17, 14);
            label11.Name = "label11";
            label11.Size = new Size(90, 21);
            label11.TabIndex = 12;
            label11.Text = "Store Price";
            // 
            // CardImage
            // 
            CardImage.BorderStyle = BorderStyle.FixedSingle;
            CardImage.Location = new Point(186, 80);
            CardImage.Name = "CardImage";
            CardImage.Size = new Size(297, 378);
            CardImage.TabIndex = 16;
            CardImage.TabStop = false;
            // 
            // delete_card
            // 
            delete_card.BackColor = Color.FromArgb(26, 28, 60);
            delete_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_card.ForeColor = Color.White;
            delete_card.Location = new Point(273, 544);
            delete_card.Name = "delete_card";
            delete_card.Size = new Size(160, 45);
            delete_card.TabIndex = 17;
            delete_card.Text = "Delete From Inventory";
            delete_card.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(26, 28, 60);
            label13.Location = new Point(516, 28);
            label13.Name = "label13";
            label13.Size = new Size(113, 23);
            label13.TabIndex = 20;
            label13.Text = "Card Details:";
            // 
            // upate_card
            // 
            upate_card.BackColor = Color.FromArgb(26, 28, 60);
            upate_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            upate_card.ForeColor = Color.White;
            upate_card.Location = new Point(516, 544);
            upate_card.Name = "upate_card";
            upate_card.Size = new Size(160, 45);
            upate_card.TabIndex = 18;
            upate_card.Text = "Save Changes";
            upate_card.UseVisualStyleBackColor = false;
            // 
            // cancel_bttn
            // 
            cancel_bttn.BackColor = SystemColors.Control;
            cancel_bttn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_bttn.ForeColor = Color.FromArgb(26, 28, 60);
            cancel_bttn.Location = new Point(760, 544);
            cancel_bttn.Name = "cancel_bttn";
            cancel_bttn.Size = new Size(160, 45);
            cancel_bttn.TabIndex = 19;
            cancel_bttn.Text = "Cancel";
            cancel_bttn.UseVisualStyleBackColor = false;
            // 
            // catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(catalog_panel);
            Name = "catalog";
            Size = new Size(1280, 720);
            catalog_panel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)catalog_view).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            card_details_panel.ResumeLayout(false);
            card_details_panel.PerformLayout();
            inventory_panel.ResumeLayout(false);
            inventory_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CardImage).EndInit();
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
        private Button next_catalog;
        private Button prev_catalog;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Panel card_details_panel;
        private TextBox market_price;
        private TextBox card_rarity;
        private TextBox set_name;
        private Label label10;
        private TextBox set_code;
        private TextBox card_race;
        private TextBox card_type;
        private TextBox card_name;
        private TextBox card_id;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Panel inventory_panel;
        private TextBox card_copies;
        private TextBox store_price;
        private Label label12;
        private Label label11;
        private PictureBox CardImage;
        private Button delete_card;
        private Label label13;
        private Button upate_card;
        private Button cancel_bttn;
    }
}
