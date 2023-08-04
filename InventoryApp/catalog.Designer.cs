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
            next_catalog = new Button();
            prev_catalog = new Button();
            catalog_view = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            search_box = new TextBox();
            search_button = new Button();
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
            warning_label = new Label();
            card_copies = new TextBox();
            store_price = new TextBox();
            label12 = new Label();
            label11 = new Label();
            CardImage = new PictureBox();
            delete_card = new Button();
            label13 = new Label();
            update_card = new Button();
            cancel_bttn = new Button();
            tabPage3 = new TabPage();
            refresh_chart = new Button();
            label15 = new Label();
            label14 = new Label();
            EndRange = new DateTimePicker();
            StartRange = new DateTimePicker();
            button1 = new Button();
            GraphPic = new PictureBox();
            marketChart = new ScottPlot.FormsPlot();
            catalog_panel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)catalog_view).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            card_details_panel.SuspendLayout();
            inventory_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CardImage).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPic).BeginInit();
            SuspendLayout();
            // 
            // catalog_panel
            // 
            catalog_panel.Controls.Add(tabControl1);
            catalog_panel.Dock = DockStyle.Fill;
            catalog_panel.Location = new Point(0, 0);
            catalog_panel.Margin = new Padding(3, 4, 3, 4);
            catalog_panel.Name = "catalog_panel";
            catalog_panel.Size = new Size(1463, 960);
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1463, 960);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleRole = AccessibleRole.None;
            tabPage1.Controls.Add(next_catalog);
            tabPage1.Controls.Add(prev_catalog);
            tabPage1.Controls.Add(catalog_view);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 64);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1455, 892);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // next_catalog
            // 
            next_catalog.Location = new Point(681, 828);
            next_catalog.Margin = new Padding(3, 4, 3, 4);
            next_catalog.Name = "next_catalog";
            next_catalog.Size = new Size(113, 31);
            next_catalog.TabIndex = 9;
            next_catalog.Text = "Next Page";
            next_catalog.UseVisualStyleBackColor = true;
            next_catalog.Click += next_catalog_Click;
            // 
            // prev_catalog
            // 
            prev_catalog.Enabled = false;
            prev_catalog.Location = new Point(547, 828);
            prev_catalog.Margin = new Padding(3, 4, 3, 4);
            prev_catalog.Name = "prev_catalog";
            prev_catalog.Size = new Size(113, 31);
            prev_catalog.TabIndex = 8;
            prev_catalog.Text = "Previous Page";
            prev_catalog.UseVisualStyleBackColor = true;
            prev_catalog.Click += prev_catalog_Click;
            // 
            // catalog_view
            // 
            catalog_view.AllowUserToAddRows = false;
            catalog_view.AllowUserToDeleteRows = false;
            catalog_view.AllowUserToResizeColumns = false;
            catalog_view.AllowUserToResizeRows = false;
            catalog_view.BackgroundColor = Color.White;
            catalog_view.BorderStyle = BorderStyle.None;
            catalog_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            catalog_view.GridColor = SystemColors.Control;
            catalog_view.Location = new Point(7, 101);
            catalog_view.Margin = new Padding(3, 4, 3, 4);
            catalog_view.Name = "catalog_view";
            catalog_view.RowHeadersVisible = false;
            catalog_view.RowHeadersWidth = 51;
            catalog_view.RowTemplate.Height = 25;
            catalog_view.Size = new Size(1234, 704);
            catalog_view.TabIndex = 7;
            catalog_view.CellContentClick += catalog_view_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.84112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.158878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 245F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel1.Controls.Add(search_box, 0, 0);
            tableLayoutPanel1.Controls.Add(search_button, 2, 0);
            tableLayoutPanel1.Location = new Point(123, 8);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(947, 59);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // search_box
            // 
            search_box.Dock = DockStyle.Fill;
            search_box.Location = new Point(3, 4);
            search_box.Margin = new Padding(3, 4, 3, 4);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Card Name";
            search_box.Size = new Size(350, 27);
            search_box.TabIndex = 1;
            // 
            // search_button
            // 
            search_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_button.AutoSize = true;
            search_button.Location = new Point(394, 4);
            search_button.Margin = new Padding(3, 4, 3, 4);
            search_button.Name = "search_button";
            search_button.Size = new Size(239, 40);
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
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1455, 892);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(26, 28, 60);
            label3.Location = new Point(590, 472);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
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
            card_details_panel.Location = new Point(590, 72);
            card_details_panel.Margin = new Padding(3, 4, 3, 4);
            card_details_panel.Name = "card_details_panel";
            card_details_panel.Size = new Size(580, 378);
            card_details_panel.TabIndex = 22;
            // 
            // market_price
            // 
            market_price.Cursor = Cursors.No;
            market_price.Location = new Point(162, 311);
            market_price.Margin = new Padding(3, 4, 3, 4);
            market_price.Name = "market_price";
            market_price.ReadOnly = true;
            market_price.Size = new Size(114, 27);
            market_price.TabIndex = 19;
            // 
            // card_rarity
            // 
            card_rarity.Cursor = Cursors.No;
            card_rarity.Location = new Point(19, 311);
            card_rarity.Margin = new Padding(3, 4, 3, 4);
            card_rarity.Name = "card_rarity";
            card_rarity.ReadOnly = true;
            card_rarity.Size = new Size(114, 27);
            card_rarity.TabIndex = 18;
            // 
            // set_name
            // 
            set_name.Cursor = Cursors.No;
            set_name.Location = new Point(162, 224);
            set_name.Margin = new Padding(3, 4, 3, 4);
            set_name.Name = "set_name";
            set_name.ReadOnly = true;
            set_name.Size = new Size(342, 27);
            set_name.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(163, 279);
            label10.Name = "label10";
            label10.Size = new Size(126, 28);
            label10.TabIndex = 11;
            label10.Text = "Market Price";
            // 
            // set_code
            // 
            set_code.Cursor = Cursors.No;
            set_code.Location = new Point(19, 224);
            set_code.Margin = new Padding(3, 4, 3, 4);
            set_code.Name = "set_code";
            set_code.ReadOnly = true;
            set_code.Size = new Size(114, 27);
            set_code.TabIndex = 16;
            // 
            // card_race
            // 
            card_race.Cursor = Cursors.No;
            card_race.Location = new Point(19, 131);
            card_race.Margin = new Padding(3, 4, 3, 4);
            card_race.Name = "card_race";
            card_race.ReadOnly = true;
            card_race.Size = new Size(114, 27);
            card_race.TabIndex = 15;
            // 
            // card_type
            // 
            card_type.Cursor = Cursors.No;
            card_type.Location = new Point(162, 131);
            card_type.Margin = new Padding(3, 4, 3, 4);
            card_type.Name = "card_type";
            card_type.ReadOnly = true;
            card_type.Size = new Size(114, 27);
            card_type.TabIndex = 14;
            // 
            // card_name
            // 
            card_name.Cursor = Cursors.No;
            card_name.Location = new Point(162, 44);
            card_name.Margin = new Padding(3, 4, 3, 4);
            card_name.Name = "card_name";
            card_name.ReadOnly = true;
            card_name.Size = new Size(342, 27);
            card_name.TabIndex = 13;
            // 
            // card_id
            // 
            card_id.Cursor = Cursors.No;
            card_id.Location = new Point(19, 44);
            card_id.Margin = new Padding(3, 4, 3, 4);
            card_id.Name = "card_id";
            card_id.ReadOnly = true;
            card_id.Size = new Size(114, 27);
            card_id.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(19, 279);
            label9.Name = "label9";
            label9.Size = new Size(63, 28);
            label9.TabIndex = 11;
            label9.Text = "Rarity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(163, 192);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 10;
            label8.Text = "Set Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(18, 192);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 9;
            label7.Text = "Set Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(162, 99);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 8;
            label6.Text = "Card Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(17, 99);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 7;
            label5.Text = "Card Race";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(162, 12);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 6;
            label4.Text = "Card Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 5;
            label2.Text = "Card ID";
            // 
            // inventory_panel
            // 
            inventory_panel.BorderStyle = BorderStyle.FixedSingle;
            inventory_panel.Controls.Add(warning_label);
            inventory_panel.Controls.Add(card_copies);
            inventory_panel.Controls.Add(store_price);
            inventory_panel.Controls.Add(label12);
            inventory_panel.Controls.Add(label11);
            inventory_panel.Location = new Point(590, 507);
            inventory_panel.Margin = new Padding(3, 4, 3, 4);
            inventory_panel.Name = "inventory_panel";
            inventory_panel.Size = new Size(580, 131);
            inventory_panel.TabIndex = 21;
            // 
            // warning_label
            // 
            warning_label.AutoSize = true;
            warning_label.ForeColor = Color.Red;
            warning_label.Location = new Point(19, 85);
            warning_label.Name = "warning_label";
            warning_label.Size = new Size(50, 20);
            warning_label.TabIndex = 21;
            warning_label.Text = "label1";
            warning_label.Visible = false;
            // 
            // card_copies
            // 
            card_copies.Cursor = Cursors.IBeam;
            card_copies.Location = new Point(162, 51);
            card_copies.Margin = new Padding(3, 4, 3, 4);
            card_copies.Name = "card_copies";
            card_copies.Size = new Size(114, 27);
            card_copies.TabIndex = 20;
            // 
            // store_price
            // 
            store_price.Cursor = Cursors.IBeam;
            store_price.Location = new Point(19, 51);
            store_price.Margin = new Padding(3, 4, 3, 4);
            store_price.Name = "store_price";
            store_price.Size = new Size(114, 27);
            store_price.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(162, 19);
            label12.Name = "label12";
            label12.Size = new Size(73, 28);
            label12.TabIndex = 13;
            label12.Text = "Copies";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(19, 19);
            label11.Name = "label11";
            label11.Size = new Size(109, 28);
            label11.TabIndex = 12;
            label11.Text = "Store Price";
            // 
            // CardImage
            // 
            CardImage.BorderStyle = BorderStyle.FixedSingle;
            CardImage.Location = new Point(94, 37);
            CardImage.Margin = new Padding(3, 4, 3, 4);
            CardImage.Name = "CardImage";
            CardImage.Size = new Size(457, 727);
            CardImage.TabIndex = 16;
            CardImage.TabStop = false;
            // 
            // delete_card
            // 
            delete_card.BackColor = Color.FromArgb(26, 28, 60);
            delete_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_card.ForeColor = Color.White;
            delete_card.Location = new Point(571, 687);
            delete_card.Margin = new Padding(3, 4, 3, 4);
            delete_card.Name = "delete_card";
            delete_card.Size = new Size(183, 60);
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
            label13.Location = new Point(590, 37);
            label13.Name = "label13";
            label13.Size = new Size(145, 30);
            label13.TabIndex = 20;
            label13.Text = "Card Details:";
            // 
            // update_card
            // 
            update_card.BackColor = Color.FromArgb(26, 28, 60);
            update_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            update_card.ForeColor = Color.White;
            update_card.Location = new Point(790, 687);
            update_card.Margin = new Padding(3, 4, 3, 4);
            update_card.Name = "update_card";
            update_card.Size = new Size(183, 60);
            update_card.TabIndex = 18;
            update_card.Text = "Save Changes";
            update_card.UseVisualStyleBackColor = false;
            update_card.Click += update_card_Click;
            // 
            // cancel_bttn
            // 
            cancel_bttn.BackColor = SystemColors.Control;
            cancel_bttn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_bttn.ForeColor = Color.FromArgb(26, 28, 60);
            cancel_bttn.Location = new Point(1001, 687);
            cancel_bttn.Margin = new Padding(3, 4, 3, 4);
            cancel_bttn.Name = "cancel_bttn";
            cancel_bttn.Size = new Size(183, 60);
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
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1455, 892);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "graph";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // refresh_chart
            // 
            refresh_chart.Location = new Point(1209, 773);
            refresh_chart.Margin = new Padding(3, 4, 3, 4);
            refresh_chart.Name = "refresh_chart";
            refresh_chart.Size = new Size(121, 32);
            refresh_chart.TabIndex = 7;
            refresh_chart.Text = "Refresh";
            refresh_chart.UseVisualStyleBackColor = true;
            refresh_chart.Click += refresh_chart_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(928, 773);
            label15.Name = "label15";
            label15.Size = new Size(33, 25);
            label15.TabIndex = 6;
            label15.Text = "To";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(585, 773);
            label14.Name = "label14";
            label14.Size = new Size(59, 25);
            label14.TabIndex = 5;
            label14.Text = "From";
            // 
            // EndRange
            // 
            EndRange.CustomFormat = "yyyy-MM-dd";
            EndRange.Format = DateTimePickerFormat.Custom;
            EndRange.Location = new Point(965, 773);
            EndRange.Margin = new Padding(3, 4, 3, 4);
            EndRange.Name = "EndRange";
            EndRange.Size = new Size(228, 27);
            EndRange.TabIndex = 4;
            // 
            // StartRange
            // 
            StartRange.CustomFormat = "yyyy-MM-dd";
            StartRange.Format = DateTimePickerFormat.Custom;
            StartRange.Location = new Point(645, 773);
            StartRange.Margin = new Padding(3, 4, 3, 4);
            StartRange.Name = "StartRange";
            StartRange.Size = new Size(228, 27);
            StartRange.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(7, 801);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(183, 60);
            button1.TabIndex = 2;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GraphPic
            // 
            GraphPic.BorderStyle = BorderStyle.FixedSingle;
            GraphPic.Location = new Point(94, 37);
            GraphPic.Margin = new Padding(3, 4, 3, 4);
            GraphPic.Name = "GraphPic";
            GraphPic.Size = new Size(457, 727);
            GraphPic.TabIndex = 1;
            GraphPic.TabStop = false;
            // 
            // marketChart
            // 
            marketChart.Location = new Point(592, 25);
            marketChart.Margin = new Padding(5, 4, 5, 4);
            marketChart.Name = "marketChart";
            marketChart.Size = new Size(704, 740);
            marketChart.TabIndex = 0;
            // 
            // catalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(catalog_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "catalog";
            Size = new Size(1463, 960);
            catalog_panel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPic).EndInit();
            ResumeLayout(false);
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
