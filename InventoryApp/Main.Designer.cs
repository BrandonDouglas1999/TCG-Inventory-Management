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
            menuButton = new PictureBox();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            home_button = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            card_button = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            edit_inventory = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button4 = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button5 = new Button();
            flowLayoutPanel9 = new FlowLayoutPanel();
            cart_button = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            sales_button = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            card_opt_tabs = new add_cards();
            home_page = new home_page();
            catalog_uc = new catalog();
            cart_tab = new shopping_cart_page();
            sales_uc = new sales_report();
            sidebar.SuspendLayout();
            table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(47, 76, 100);
            sidebar.Controls.Add(table);
            sidebar.Controls.Add(flowLayoutPanel3);
            sidebar.Controls.Add(flowLayoutPanel4);
            sidebar.Controls.Add(flowLayoutPanel5);
            sidebar.Controls.Add(flowLayoutPanel9);
            sidebar.Controls.Add(flowLayoutPanel8);
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
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            table.Controls.Add(menuButton, 0, 1);
            table.Controls.Add(label1, 1, 1);
            table.Location = new Point(3, 3);
            table.Name = "table";
            table.RowCount = 2;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.Size = new Size(179, 96);
            table.TabIndex = 4;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.menu;
            menuButton.Location = new Point(3, 51);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(31, 34);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(home_button);
            flowLayoutPanel3.Location = new Point(3, 105);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(173, 46);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // home_button
            // 
            home_button.FlatAppearance.BorderSize = 0;
            home_button.FlatStyle = FlatStyle.Flat;
            home_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            home_button.Image = Properties.Resources.home;
            home_button.ImageAlign = ContentAlignment.MiddleLeft;
            home_button.Location = new Point(3, 3);
            home_button.Name = "home_button";
            home_button.Size = new Size(164, 46);
            home_button.TabIndex = 0;
            home_button.Text = "Home";
            home_button.UseVisualStyleBackColor = true;
            home_button.Click += home_button_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(card_button);
            flowLayoutPanel4.Location = new Point(3, 157);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(173, 46);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // card_button
            // 
            card_button.FlatAppearance.BorderSize = 0;
            card_button.FlatStyle = FlatStyle.Flat;
            card_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            card_button.Image = Properties.Resources.trading_card;
            card_button.ImageAlign = ContentAlignment.MiddleLeft;
            card_button.Location = new Point(3, 3);
            card_button.Name = "card_button";
            card_button.Size = new Size(164, 46);
            card_button.TabIndex = 0;
            card_button.Text = "Cards";
            card_button.UseVisualStyleBackColor = true;
            card_button.Click += card_button_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(edit_inventory);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Location = new Point(3, 209);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(173, 46);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // edit_inventory
            // 
            edit_inventory.FlatAppearance.BorderSize = 0;
            edit_inventory.FlatStyle = FlatStyle.Flat;
            edit_inventory.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            edit_inventory.Image = Properties.Resources.inventory;
            edit_inventory.ImageAlign = ContentAlignment.MiddleLeft;
            edit_inventory.Location = new Point(3, 3);
            edit_inventory.Name = "edit_inventory";
            edit_inventory.Size = new Size(164, 46);
            edit_inventory.TabIndex = 0;
            edit_inventory.Text = "Inventory";
            edit_inventory.UseVisualStyleBackColor = true;
            edit_inventory.Click += edit_inventory_Click;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(button4);
            flowLayoutPanel6.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel6.Location = new Point(3, 55);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(173, 46);
            flowLayoutPanel6.TabIndex = 2;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.home;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(164, 46);
            button4.TabIndex = 0;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(button5);
            flowLayoutPanel7.Location = new Point(3, 55);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(173, 46);
            flowLayoutPanel7.TabIndex = 2;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.home;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 3);
            button5.Name = "button5";
            button5.Size = new Size(164, 46);
            button5.TabIndex = 0;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(cart_button);
            flowLayoutPanel9.Location = new Point(3, 261);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(173, 46);
            flowLayoutPanel9.TabIndex = 2;
            // 
            // cart_button
            // 
            cart_button.FlatAppearance.BorderSize = 0;
            cart_button.FlatStyle = FlatStyle.Flat;
            cart_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cart_button.Image = Properties.Resources.shopping_cart1;
            cart_button.ImageAlign = ContentAlignment.MiddleLeft;
            cart_button.Location = new Point(3, 3);
            cart_button.Name = "cart_button";
            cart_button.Size = new Size(164, 46);
            cart_button.TabIndex = 0;
            cart_button.Text = "Cart";
            cart_button.UseVisualStyleBackColor = true;
            cart_button.Click += cart_button_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(sales_button);
            flowLayoutPanel8.Location = new Point(3, 313);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(173, 46);
            flowLayoutPanel8.TabIndex = 2;
            // 
            // sales_button
            // 
            sales_button.FlatAppearance.BorderSize = 0;
            sales_button.FlatStyle = FlatStyle.Flat;
            sales_button.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sales_button.Image = Properties.Resources.line_chart;
            sales_button.ImageAlign = ContentAlignment.MiddleLeft;
            sales_button.Location = new Point(3, 3);
            sales_button.Name = "sales_button";
            sales_button.Size = new Size(164, 46);
            sales_button.TabIndex = 0;
            sales_button.Text = "Sales";
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
            card_opt_tabs.Location = new Point(176, 0);
            card_opt_tabs.Name = "card_opt_tabs";
            card_opt_tabs.Size = new Size(837, 575);
            card_opt_tabs.TabIndex = 1;
            // 
            // home_page
            // 
            home_page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            home_page.AutoSize = true;
            home_page.Location = new Point(263, 0);
            home_page.Name = "home_page";
            home_page.Size = new Size(731, 330);
            home_page.TabIndex = 2;
            // 
            // catalog_uc
            // 
            catalog_uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            catalog_uc.AutoSize = true;
            catalog_uc.Location = new Point(108, 164);
            catalog_uc.Name = "catalog_uc";
            catalog_uc.Size = new Size(350, 341);
            catalog_uc.TabIndex = 3;
            catalog_uc.Visible = false;
            // 
            // cart_tab
            // 
            cart_tab.Location = new Point(329, 35);
            cart_tab.Name = "cart_tab";
            cart_tab.Size = new Size(636, 384);
            cart_tab.TabIndex = 4;
            cart_tab.Visible = false;
            // 
            // sales_uc
            // 
            sales_uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sales_uc.AutoSize = true;
            sales_uc.Location = new Point(826, 285);
            sales_uc.Name = "sales_uc";
            sales_uc.Size = new Size(248, 220);
            sales_uc.TabIndex = 5;
            sales_uc.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 701);
            Controls.Add(sales_uc);
            Controls.Add(cart_tab);
            Controls.Add(catalog_uc);
            Controls.Add(sidebar);
            Controls.Add(home_page);
            Controls.Add(card_opt_tabs);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            Resize += Main_Resize;
            sidebar.ResumeLayout(false);
            table.ResumeLayout(false);
            table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button home_button;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button card_button;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button edit_inventory;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button cart_button;
        private FlowLayoutPanel flowLayoutPanel8;
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
    }
}