namespace InventoryApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            table = new TableLayoutPanel();
            label1 = new Label();
            menuButton = new PictureBox();
            home_button = new Button();
            card_button = new Button();
            view_inventory_button = new Button();
            cart_button = new Button();
            sales_button = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            card_opt_tabs = new add_cards();
            home_page = new home_page();
            catalog_uc = new catalog();
            sales_uc = new sales_report();
            cart_uc = new shopping_cart_page();
            sidebar.SuspendLayout();
            table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(47, 76, 100);
            sidebar.Controls.Add(table);
            sidebar.Controls.Add(home_button);
            sidebar.Controls.Add(card_button);
            sidebar.Controls.Add(view_inventory_button);
            sidebar.Controls.Add(cart_button);
            sidebar.Controls.Add(sales_button);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(200, 500);
            sidebar.MinimumSize = new Size(50, 556);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(50, 556);
            sidebar.TabIndex = 0;
            // 
            // table
            // 
            table.ColumnCount = 2;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            table.Controls.Add(label1, 1, 1);
            table.Controls.Add(menuButton, 0, 1);
            table.Location = new Point(3, 3);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 57.89474F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 42.10526F));
            table.Size = new Size(167, 95);
            table.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.menu;
            menuButton.Location = new Point(3, 58);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(31, 34);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // home_button
            // 
            home_button.FlatAppearance.BorderSize = 0;
            home_button.FlatStyle = FlatStyle.Flat;
            home_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            home_button.Image = Properties.Resources.home;
            home_button.ImageAlign = ContentAlignment.MiddleLeft;
            home_button.Location = new Point(3, 104);
            home_button.Name = "home_button";
            home_button.Size = new Size(164, 46);
            home_button.TabIndex = 0;
            home_button.Text = "Home";
            home_button.TextAlign = ContentAlignment.MiddleRight;
            home_button.UseVisualStyleBackColor = true;
            home_button.Click += home_button_Click;
            // 
            // card_button
            // 
            card_button.FlatAppearance.BorderSize = 0;
            card_button.FlatStyle = FlatStyle.Flat;
            card_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            card_button.Image = Properties.Resources.trading_card;
            card_button.ImageAlign = ContentAlignment.MiddleLeft;
            card_button.Location = new Point(3, 156);
            card_button.Name = "card_button";
            card_button.Size = new Size(164, 46);
            card_button.TabIndex = 0;
            card_button.Text = "Cards";
            card_button.TextAlign = ContentAlignment.MiddleRight;
            card_button.UseVisualStyleBackColor = true;
            card_button.Click += catalog_Click;
            // 
            // view_inventory_button
            // 
            view_inventory_button.FlatAppearance.BorderSize = 0;
            view_inventory_button.FlatStyle = FlatStyle.Flat;
            view_inventory_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            view_inventory_button.Image = Properties.Resources.inventory;
            view_inventory_button.ImageAlign = ContentAlignment.MiddleLeft;
            view_inventory_button.Location = new Point(3, 208);
            view_inventory_button.Name = "view_inventory_button";
            view_inventory_button.Size = new Size(164, 46);
            view_inventory_button.TabIndex = 0;
            view_inventory_button.Text = "View Inventory";
            view_inventory_button.TextAlign = ContentAlignment.MiddleRight;
            view_inventory_button.UseVisualStyleBackColor = true;
            view_inventory_button.Click += card_button_Click;
            // 
            // cart_button
            // 
            cart_button.FlatAppearance.BorderSize = 0;
            cart_button.FlatStyle = FlatStyle.Flat;
            cart_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cart_button.Image = Properties.Resources.shopping_cart1;
            cart_button.ImageAlign = ContentAlignment.MiddleLeft;
            cart_button.Location = new Point(3, 260);
            cart_button.Name = "cart_button";
            cart_button.Size = new Size(164, 46);
            cart_button.TabIndex = 0;
            cart_button.Text = "Cart";
            cart_button.TextAlign = ContentAlignment.MiddleRight;
            cart_button.UseVisualStyleBackColor = true;
            cart_button.Click += cart_button_Click;
            // 
            // sales_button
            // 
            sales_button.FlatAppearance.BorderSize = 0;
            sales_button.FlatStyle = FlatStyle.Flat;
            sales_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sales_button.Image = Properties.Resources.line_chart;
            sales_button.ImageAlign = ContentAlignment.MiddleLeft;
            sales_button.Location = new Point(3, 312);
            sales_button.Name = "sales_button";
            sales_button.Size = new Size(164, 46);
            sales_button.TabIndex = 0;
            sales_button.Text = "Sales";
            sales_button.TextAlign = ContentAlignment.MiddleRight;
            sales_button.UseVisualStyleBackColor = true;
            sales_button.Click += sales_button_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // card_opt_tabs
            // 
            card_opt_tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            card_opt_tabs.AutoSize = true;
            card_opt_tabs.Location = new Point(348, 12);
            card_opt_tabs.Name = "card_opt_tabs";
            card_opt_tabs.Size = new Size(1273, 833);
            card_opt_tabs.TabIndex = 1;
            card_opt_tabs.Visible = false;
            // 
            // home_page
            // 
            home_page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            home_page.AutoSize = true;
            home_page.Location = new Point(143, -34);
            home_page.Name = "home_page";
            home_page.Size = new Size(959, 491);
            home_page.TabIndex = 2;
            // 
            // catalog_uc
            // 
            catalog_uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            catalog_uc.AutoSize = true;
            catalog_uc.Location = new Point(114, 40);
            catalog_uc.Name = "catalog_uc";
            catalog_uc.Size = new Size(578, 491);
            catalog_uc.TabIndex = 3;
            catalog_uc.Visible = false;
            // 
            // sales_uc
            // 
            sales_uc.Location = new Point(606, 143);
            sales_uc.Name = "sales_uc";
            sales_uc.Size = new Size(836, 560);
            sales_uc.TabIndex = 4;
            sales_uc.Visible = false;
            // 
            // cart_uc
            // 
            cart_uc.Location = new Point(80, 104);
            cart_uc.Name = "cart_uc";
            cart_uc.Size = new Size(884, 510);
            cart_uc.TabIndex = 5;
            cart_uc.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 851);
            Controls.Add(cart_uc);
            Controls.Add(sales_uc);
            Controls.Add(catalog_uc);
            Controls.Add(sidebar);
            Controls.Add(home_page);
            Controls.Add(card_opt_tabs);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            Click += menuButton_Click;
            sidebar.ResumeLayout(false);
            table.ResumeLayout(false);
            table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Button home_button;
        private Button card_button;
        private Button cart_button;
        private Button sales_button;
        private System.Windows.Forms.Timer sidebarTimer;
        private TableLayoutPanel table;
        private PictureBox menuButton;
        private Label label1;
        private add_cards card_opt_tabs;
        private home_page home_page;
        private catalog catalog_uc;
        private Button view_inventory_button;
        private sales_report sales_uc;
        private shopping_cart_page cart_uc;
    }
}