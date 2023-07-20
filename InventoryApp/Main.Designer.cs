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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.Button();
            this.card_button = new System.Windows.Forms.Button();
            this.view_inventory_button = new System.Windows.Forms.Button();
            this.edit_inven_button = new System.Windows.Forms.Button();
            this.cart_button = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.card_opt_tabs = new InventoryApp.add_cards();
            this.home_page = new InventoryApp.home_page();
            this.catalog_uc = new InventoryApp.catalog();
            this.sidebar.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(100)))));
            this.sidebar.Controls.Add(this.table);
            this.sidebar.Controls.Add(this.home_button);
            this.sidebar.Controls.Add(this.card_button);
            this.sidebar.Controls.Add(this.view_inventory_button);
            this.sidebar.Controls.Add(this.edit_inven_button);
            this.sidebar.Controls.Add(this.cart_button);
            this.sidebar.Controls.Add(this.sales_button);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 500);
            this.sidebar.MinimumSize = new System.Drawing.Size(50, 556);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(50, 556);
            this.sidebar.TabIndex = 0;
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.table.Controls.Add(this.label1, 1, 1);
            this.table.Controls.Add(this.menuButton, 0, 1);
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.table.Size = new System.Drawing.Size(167, 95);
            this.table.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::InventoryApp.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(3, 58);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(31, 34);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_button.Image = global::InventoryApp.Properties.Resources.home;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.Location = new System.Drawing.Point(3, 104);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(164, 46);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.UseVisualStyleBackColor = true;
            // 
            // card_button
            // 
            this.card_button.FlatAppearance.BorderSize = 0;
            this.card_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.card_button.Image = global::InventoryApp.Properties.Resources.trading_card;
            this.card_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.card_button.Location = new System.Drawing.Point(3, 156);
            this.card_button.Name = "card_button";
            this.card_button.Size = new System.Drawing.Size(164, 46);
            this.card_button.TabIndex = 0;
            this.card_button.Text = "Cards";
            this.card_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.card_button.UseVisualStyleBackColor = true;
            // 
            // view_inventory_button
            // 
            this.view_inventory_button.FlatAppearance.BorderSize = 0;
            this.view_inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_inventory_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_inventory_button.Image = global::InventoryApp.Properties.Resources.inventory;
            this.view_inventory_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_inventory_button.Location = new System.Drawing.Point(3, 208);
            this.view_inventory_button.Name = "view_inventory_button";
            this.view_inventory_button.Size = new System.Drawing.Size(164, 46);
            this.view_inventory_button.TabIndex = 0;
            this.view_inventory_button.Text = "View Inventory";
            this.view_inventory_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.view_inventory_button.UseVisualStyleBackColor = true;
            // 
            // edit_inven_button
            // 
            this.edit_inven_button.FlatAppearance.BorderSize = 0;
            this.edit_inven_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_inven_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit_inven_button.Image = global::InventoryApp.Properties.Resources.edit;
            this.edit_inven_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_inven_button.Location = new System.Drawing.Point(3, 260);
            this.edit_inven_button.Name = "edit_inven_button";
            this.edit_inven_button.Size = new System.Drawing.Size(164, 46);
            this.edit_inven_button.TabIndex = 7;
            this.edit_inven_button.Text = "Edit Inventory";
            this.edit_inven_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_inven_button.UseVisualStyleBackColor = true;
            // 
            // cart_button
            // 
            this.cart_button.FlatAppearance.BorderSize = 0;
            this.cart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cart_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cart_button.Image = global::InventoryApp.Properties.Resources.shopping_cart1;
            this.cart_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cart_button.Location = new System.Drawing.Point(3, 312);
            this.cart_button.Name = "cart_button";
            this.cart_button.Size = new System.Drawing.Size(164, 46);
            this.cart_button.TabIndex = 0;
            this.cart_button.Text = "Cart";
            this.cart_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cart_button.UseVisualStyleBackColor = true;
            // 
            // sales_button
            // 
            this.sales_button.FlatAppearance.BorderSize = 0;
            this.sales_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sales_button.Image = global::InventoryApp.Properties.Resources.line_chart;
            this.sales_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_button.Location = new System.Drawing.Point(3, 364);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(164, 46);
            this.sales_button.TabIndex = 0;
            this.sales_button.Text = "Sales";
            this.sales_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sales_button.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // card_opt_tabs
            // 
            this.card_opt_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card_opt_tabs.AutoSize = true;
            this.card_opt_tabs.Location = new System.Drawing.Point(236, 0);
            this.card_opt_tabs.Name = "card_opt_tabs";
            this.card_opt_tabs.Size = new System.Drawing.Size(934, 829);
            this.card_opt_tabs.TabIndex = 1;
            this.card_opt_tabs.Visible = false;
            // 
            // home_page
            // 
            this.home_page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_page.AutoSize = true;
            this.home_page.Location = new System.Drawing.Point(263, 0);
            this.home_page.Name = "home_page";
            this.home_page.Size = new System.Drawing.Size(731, 433);
            this.home_page.TabIndex = 2;
            // 
            // catalog_uc
            // 
            this.catalog_uc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catalog_uc.AutoSize = true;
            this.catalog_uc.Location = new System.Drawing.Point(293, 108);
            this.catalog_uc.Name = "catalog_uc";
            this.catalog_uc.Size = new System.Drawing.Size(350, 438);
            this.catalog_uc.TabIndex = 3;
            this.catalog_uc.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 798);
            this.Controls.Add(this.catalog_uc);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.home_page);
            this.Controls.Add(this.card_opt_tabs);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.menuButton_Click);
            this.sidebar.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Button home_button;
        private Button card_button;
        private Button view_inventory_button;
        private Button cart_button;
        private Button sales_button;
        private System.Windows.Forms.Timer sidebarTimer;
        private TableLayoutPanel table;
        private PictureBox menuButton;
        private Label label1;
        private add_cards card_opt_tabs;
        private home_page home_page;
        private catalog catalog_uc;
        private shopping_cart_page cart_tab;
        private sales_report sales_uc;
        private Button edit_inven_button;
        private edit_inventory edit_inven_uc;
    }
}