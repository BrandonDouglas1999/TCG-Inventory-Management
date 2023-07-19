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
            button3 = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button4 = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button5 = new Button();
            flowLayoutPanel9 = new FlowLayoutPanel();
            button7 = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            button6 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            card_opt_tabs = new add_cards();
            home_page = new home_page();
            UCTransitionTimer = new System.Windows.Forms.Timer(components);
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
            flowLayoutPanel5.Controls.Add(button3);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Location = new Point(3, 209);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(173, 46);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.line_chart;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(164, 46);
            button3.TabIndex = 0;
            button3.Text = "Graphs";
            button3.UseVisualStyleBackColor = true;
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
            flowLayoutPanel9.Controls.Add(button7);
            flowLayoutPanel9.Location = new Point(3, 261);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(173, 46);
            flowLayoutPanel9.TabIndex = 2;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = Properties.Resources.settings;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(164, 46);
            button7.TabIndex = 0;
            button7.Text = "Settings";
            button7.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(button6);
            flowLayoutPanel8.Location = new Point(3, 313);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(173, 46);
            flowLayoutPanel8.TabIndex = 2;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.question_mark;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(164, 46);
            button6.TabIndex = 0;
            button6.Text = "About";
            button6.UseVisualStyleBackColor = true;
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
            card_opt_tabs.Location = new Point(157, 0);
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
            // UCTransitionTimer
            // 
            UCTransitionTimer.Interval = 50;
            UCTransitionTimer.Tick += UCTransitionTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 701);
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
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel9;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button button6;
        private System.Windows.Forms.Timer sidebarTimer;
        private TableLayoutPanel table;
        private PictureBox menuButton;
        private Label label1;
        private add_cards card_opt_tabs;
        private home_page home_page;
        private System.Windows.Forms.Timer UCTransitionTimer;
    }
}