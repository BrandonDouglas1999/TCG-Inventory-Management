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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.next_catalog = new System.Windows.Forms.Button();
            this.prev_catalog = new System.Windows.Forms.Button();
            this.catalog_view = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.card_details_panel = new System.Windows.Forms.Panel();
            this.market_price = new System.Windows.Forms.TextBox();
            this.card_rarity = new System.Windows.Forms.TextBox();
            this.set_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.set_code = new System.Windows.Forms.TextBox();
            this.card_race = new System.Windows.Forms.TextBox();
            this.card_type = new System.Windows.Forms.TextBox();
            this.card_name = new System.Windows.Forms.TextBox();
            this.card_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.card_copies = new System.Windows.Forms.TextBox();
            this.store_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.delete_card = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.update_card = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.refresh_chart = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EndRange = new System.Windows.Forms.DateTimePicker();
            this.StartRange = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.GraphPic = new System.Windows.Forms.PictureBox();
            this.marketChart = new ScottPlot.FormsPlot();
            this.warning_label = new System.Windows.Forms.Label();
            this.catalog_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.card_details_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPic)).BeginInit();
            this.SuspendLayout();
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
            tabControl1.Controls.Add(tabPage3);
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
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.Controls.Add(this.next_catalog);
            this.tabPage1.Controls.Add(this.prev_catalog);
            this.tabPage1.Controls.Add(this.catalog_view);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // next_catalog
            // 
            this.next_catalog.Location = new System.Drawing.Point(596, 621);
            this.next_catalog.Name = "next_catalog";
            this.next_catalog.Size = new System.Drawing.Size(99, 23);
            this.next_catalog.TabIndex = 9;
            this.next_catalog.Text = "Next Page";
            this.next_catalog.UseVisualStyleBackColor = true;
            this.next_catalog.Click += new System.EventHandler(this.next_catalog_Click);
            // 
            // prev_catalog
            // 
            this.prev_catalog.Enabled = false;
            this.prev_catalog.Location = new System.Drawing.Point(479, 621);
            this.prev_catalog.Name = "prev_catalog";
            this.prev_catalog.Size = new System.Drawing.Size(99, 23);
            this.prev_catalog.TabIndex = 8;
            this.prev_catalog.Text = "Previous Page";
            this.prev_catalog.UseVisualStyleBackColor = true;
            this.prev_catalog.Click += new System.EventHandler(this.prev_catalog_Click);
            // 
            // catalog_view
            // 
            this.catalog_view.AllowUserToAddRows = false;
            this.catalog_view.AllowUserToDeleteRows = false;
            this.catalog_view.AllowUserToResizeColumns = false;
            this.catalog_view.AllowUserToResizeRows = false;
            this.catalog_view.BackgroundColor = System.Drawing.Color.White;
            this.catalog_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog_view.GridColor = System.Drawing.SystemColors.Control;
            this.catalog_view.Location = new System.Drawing.Point(6, 76);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowHeadersVisible = false;
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(1080, 528);
            this.catalog_view.TabIndex = 7;
            this.catalog_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_view_CellContentClick);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(108, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 44);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // search_box
            // 
            search_box.Dock = DockStyle.Fill;
            search_box.Location = new Point(3, 3);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Card Name";
            search_box.Size = new Size(307, 23);
            search_box.TabIndex = 1;
            // 
            // search_button
            // 
            search_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_button.AutoSize = true;
            search_button.Location = new Point(347, 3);
            search_button.Name = "search_button";
            search_button.Size = new Size(208, 25);
            search_button.TabIndex = 2;
            search_button.Text = "Search";
            search_button.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(card_details_panel);
            tabPage2.Controls.Add(inventory_panel);
            tabPage2.Controls.Add(CardImage);
            tabPage2.Controls.Add(delete_card);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(update_card);
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
            this.inventory_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory_panel.Controls.Add(this.warning_label);
            this.inventory_panel.Controls.Add(this.card_copies);
            this.inventory_panel.Controls.Add(this.store_price);
            this.inventory_panel.Controls.Add(this.label12);
            this.inventory_panel.Controls.Add(this.label11);
            this.inventory_panel.Location = new System.Drawing.Point(516, 380);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(508, 99);
            this.inventory_panel.TabIndex = 21;
            // 
            // card_copies
            // 
            card_copies.Cursor = Cursors.IBeam;
            card_copies.Location = new Point(142, 38);
            card_copies.Name = "card_copies";
            card_copies.Size = new Size(100, 23);
            card_copies.TabIndex = 20;
            // 
            // store_price
            // 
            store_price.Cursor = Cursors.IBeam;
            store_price.Location = new Point(17, 38);
            store_price.Name = "store_price";
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
            CardImage.Location = new Point(82, 28);
            CardImage.Name = "CardImage";
            CardImage.Size = new Size(400, 546);
            CardImage.TabIndex = 16;
            CardImage.TabStop = false;
            // 
            // delete_card
            // 
            delete_card.BackColor = Color.FromArgb(26, 28, 60);
            delete_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_card.ForeColor = Color.White;
            delete_card.Location = new Point(500, 515);
            delete_card.Name = "delete_card";
            delete_card.Size = new Size(160, 45);
            delete_card.TabIndex = 17;
            delete_card.Text = "Delete From Inventory";
            delete_card.UseVisualStyleBackColor = false;
            delete_card.Click += delete_card_Click;
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
            // update_card
            // 
            this.update_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.update_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_card.ForeColor = System.Drawing.Color.White;
            this.update_card.Location = new System.Drawing.Point(691, 515);
            this.update_card.Name = "update_card";
            this.update_card.Size = new System.Drawing.Size(160, 45);
            this.update_card.TabIndex = 18;
            this.update_card.Text = "Save Changes";
            this.update_card.UseVisualStyleBackColor = false;
            this.update_card.Click += new System.EventHandler(this.update_card_Click);
            // 
            // cancel_bttn
            // 
            cancel_bttn.BackColor = SystemColors.Control;
            cancel_bttn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_bttn.ForeColor = Color.FromArgb(26, 28, 60);
            cancel_bttn.Location = new Point(876, 515);
            cancel_bttn.Name = "cancel_bttn";
            cancel_bttn.Size = new Size(160, 45);
            cancel_bttn.TabIndex = 19;
            cancel_bttn.Text = "Cancel";
            cancel_bttn.UseVisualStyleBackColor = false;
            cancel_bttn.Click += cancel_bttn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(refresh_chart);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(EndRange);
            tabPage3.Controls.Add(StartRange);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(GraphPic);
            tabPage3.Controls.Add(marketChart);
            tabPage3.Location = new Point(4, 64);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1272, 652);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "graph";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // refresh_chart
            // 
            refresh_chart.Location = new Point(1058, 580);
            refresh_chart.Name = "refresh_chart";
            refresh_chart.Size = new Size(106, 24);
            refresh_chart.TabIndex = 7;
            refresh_chart.Text = "Refresh";
            refresh_chart.UseVisualStyleBackColor = true;
            refresh_chart.Click += refresh_chart_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(812, 580);
            label15.Name = "label15";
            label15.Size = new Size(26, 20);
            label15.TabIndex = 6;
            label15.Text = "To";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(512, 580);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 5;
            label14.Text = "From";
            // 
            // EndRange
            // 
            EndRange.CustomFormat = "yyyy-MM-dd";
            EndRange.Format = DateTimePickerFormat.Custom;
            EndRange.Location = new Point(844, 580);
            EndRange.Name = "EndRange";
            EndRange.Size = new Size(200, 23);
            EndRange.TabIndex = 4;
            // 
            // StartRange
            // 
            StartRange.CustomFormat = "yyyy-MM-dd";
            StartRange.Format = DateTimePickerFormat.Custom;
            StartRange.Location = new Point(564, 580);
            StartRange.Name = "StartRange";
            StartRange.Size = new Size(200, 23);
            StartRange.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(6, 601);
            button1.Name = "button1";
            button1.Size = new Size(160, 45);
            button1.TabIndex = 2;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GraphPic
            // 
            GraphPic.BorderStyle = BorderStyle.FixedSingle;
            GraphPic.Location = new Point(82, 28);
            GraphPic.Name = "GraphPic";
            GraphPic.Size = new Size(400, 546);
            GraphPic.TabIndex = 1;
            GraphPic.TabStop = false;
            // 
            // marketChart
            // 
            marketChart.Location = new Point(518, 19);
            marketChart.Margin = new Padding(4, 3, 4, 3);
            marketChart.Name = "marketChart";
            marketChart.Size = new Size(616, 555);
            marketChart.TabIndex = 0;
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(17, 64);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(38, 15);
            this.warning_label.TabIndex = 21;
            this.warning_label.Text = "label1";
            this.warning_label.Visible = false;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.catalog_panel);
            this.Name = "catalog";
            this.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.card_details_panel.ResumeLayout(false);
            this.card_details_panel.PerformLayout();
            this.inventory_panel.ResumeLayout(false);
            this.inventory_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPic)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel catalog_panel;
        private TextBox search_box;
        private Button search_button;
        private TableLayoutPanel tableLayoutPanel1;
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
        private Button update_card;
        private Button cancel_bttn;
        private TabPage tabPage3;
        private PictureBox GraphPic;
        private ScottPlot.FormsPlot marketChart;
        private Button button1;
        private DateTimePicker EndRange;
        private DateTimePicker StartRange;
        private Button refresh_chart;
        private Label label15;
        private Label label14;
        private Button next_catalog;
        private Button prev_catalog;
        private DataGridView catalog_view;
        private Label warning_label;
    }
}
