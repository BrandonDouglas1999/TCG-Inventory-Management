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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            sidebar = new FlowLayoutPanel();
            menu_button = new Button();
            separator = new Label();
            home_button = new Button();
            card_button = new Button();
            view_inventory_button = new Button();
            cart_button = new Button();
            sales_button = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            card_opt_tabs = new add_cards();
            home_page = new home_page();
            sales_uc = new sales_report();
            cart_uc = new shopping_cart_page();
            catalog_uc = new catalog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(47, 76, 100);
            sidebar.Controls.Add(menu_button);
            sidebar.Controls.Add(separator);
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
            // menu_button
            // 
            menu_button.FlatAppearance.BorderSize = 0;
            menu_button.FlatStyle = FlatStyle.Flat;
            menu_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menu_button.ForeColor = Color.White;
            menu_button.Image = Properties.Resources.menu;
            menu_button.ImageAlign = ContentAlignment.MiddleLeft;
            menu_button.Location = new Point(3, 25);
            menu_button.Margin = new Padding(3, 25, 3, 3);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(164, 46);
            menu_button.TabIndex = 7;
            menu_button.Text = "Menu";
            menu_button.TextAlign = ContentAlignment.MiddleRight;
            menu_button.UseVisualStyleBackColor = true;
            menu_button.Click += menuButton_Click;
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(10, 94);
            separator.Margin = new Padding(10, 20, 3, 0);
            separator.Name = "separator";
            separator.Size = new Size(150, 2);
            separator.TabIndex = 21;
            // 
            // home_button
            // 
            home_button.FlatAppearance.BorderSize = 0;
            home_button.FlatStyle = FlatStyle.Flat;
            home_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            home_button.ForeColor = Color.White;
            home_button.Image = (Image)resources.GetObject("home_button.Image");
            home_button.ImageAlign = ContentAlignment.MiddleLeft;
            home_button.Location = new Point(3, 116);
            home_button.Margin = new Padding(3, 20, 3, 3);
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
            card_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            card_button.ForeColor = Color.White;
            card_button.Image = (Image)resources.GetObject("card_button.Image");
            card_button.ImageAlign = ContentAlignment.MiddleLeft;
            card_button.Location = new Point(3, 185);
            card_button.Margin = new Padding(3, 20, 3, 3);
            card_button.Name = "card_button";
            card_button.Size = new Size(164, 46);
            card_button.TabIndex = 0;
            card_button.Text = "View Inventory";
            card_button.TextAlign = ContentAlignment.MiddleRight;
            card_button.UseVisualStyleBackColor = true;
            card_button.Click += catalog_Click;
            // 
            // view_inventory_button
            // 
            view_inventory_button.FlatAppearance.BorderSize = 0;
            view_inventory_button.FlatStyle = FlatStyle.Flat;
            view_inventory_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            view_inventory_button.ForeColor = Color.White;
            view_inventory_button.Image = (Image)resources.GetObject("view_inventory_button.Image");
            view_inventory_button.ImageAlign = ContentAlignment.MiddleLeft;
            view_inventory_button.Location = new Point(3, 254);
            view_inventory_button.Margin = new Padding(3, 20, 3, 3);
            view_inventory_button.Name = "view_inventory_button";
            view_inventory_button.Size = new Size(164, 46);
            view_inventory_button.TabIndex = 0;
            view_inventory_button.Text = "Add Cards";
            view_inventory_button.TextAlign = ContentAlignment.MiddleRight;
            view_inventory_button.UseVisualStyleBackColor = true;
            view_inventory_button.Click += card_button_Click;
            // 
            // cart_button
            // 
            cart_button.FlatAppearance.BorderSize = 0;
            cart_button.FlatStyle = FlatStyle.Flat;
            cart_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cart_button.ForeColor = Color.White;
            cart_button.Image = (Image)resources.GetObject("cart_button.Image");
            cart_button.ImageAlign = ContentAlignment.MiddleLeft;
            cart_button.Location = new Point(3, 323);
            cart_button.Margin = new Padding(3, 20, 3, 3);
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
            sales_button.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sales_button.ForeColor = Color.White;
            sales_button.Image = (Image)resources.GetObject("sales_button.Image");
            sales_button.ImageAlign = ContentAlignment.MiddleLeft;
            sales_button.Location = new Point(3, 392);
            sales_button.Margin = new Padding(3, 20, 3, 3);
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
            card_opt_tabs.AutoSize = true;
            card_opt_tabs.Location = new Point(125, 183);
            card_opt_tabs.Name = "card_opt_tabs";
            card_opt_tabs.Size = new Size(1273, 833);
            card_opt_tabs.TabIndex = 1;
            card_opt_tabs.Visible = false;
            // 
            // home_page
            // 
            home_page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            home_page.AutoSize = true;
            home_page.Location = new Point(76, 6);
            home_page.Name = "home_page";
            home_page.Size = new Size(1503, 1001);
            home_page.TabIndex = 2;
            // 
            // sales_uc
            // 
            sales_uc.Location = new Point(591, 94);
            sales_uc.Name = "sales_uc";
            sales_uc.Size = new Size(406, 224);
            sales_uc.TabIndex = 4;
            sales_uc.Visible = false;
            // 
            // cart_uc
            // 
            cart_uc.Location = new Point(478, 30);
            cart_uc.Name = "cart_uc";
            cart_uc.Size = new Size(718, 390);
            cart_uc.TabIndex = 5;
            cart_uc.Visible = false;
            // 
            // catalog_uc
            // 
            catalog_uc.Location = new Point(380, 2);
            catalog_uc.Name = "catalog_uc";
            catalog_uc.Size = new Size(737, 276);
            catalog_uc.TabIndex = 6;
            catalog_uc.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(50, 780);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 58);
            panel1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1484, 811);
            Controls.Add(panel1);
            Controls.Add(catalog_uc);
            Controls.Add(sales_uc);
            Controls.Add(sidebar);
            Controls.Add(home_page);
            Controls.Add(card_opt_tabs);
            Controls.Add(cart_uc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            Click += menuButton_Click;
            sidebar.ResumeLayout(false);
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
        private add_cards card_opt_tabs;
        private home_page home_page;
        private Button view_inventory_button;
        private sales_report sales_uc;
        private shopping_cart_page cart_uc;
        private catalog catalog_uc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button menu_button;
        private Label separator;
        private Panel panel1;
    }
}