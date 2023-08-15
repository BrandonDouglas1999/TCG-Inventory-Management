namespace InventoryApp
{
    partial class shopping_cart_page
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
            clear_button = new Button();
            check_out = new Button();
            label1 = new Label();
            total_price = new Label();
            panel1 = new Panel();
            label21 = new Label();
            sub_total = new Label();
            label4 = new Label();
            label2 = new Label();
            taxes = new Label();
            shopping_cart_view = new DataGridView();
            user_label = new Label();
            top_back_panel = new Panel();
            cart_qnty_label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).BeginInit();
            top_back_panel.SuspendLayout();
            SuspendLayout();
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.White;
            clear_button.FlatStyle = FlatStyle.Popup;
            clear_button.ForeColor = Color.FromArgb(50, 55, 143);
            clear_button.Location = new Point(85, 136);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(101, 23);
            clear_button.TabIndex = 1;
            clear_button.Text = "Clear Cart";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // check_out
            // 
            check_out.BackColor = Color.FromArgb(86, 95, 240);
            check_out.FlatStyle = FlatStyle.Popup;
            check_out.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            check_out.ForeColor = Color.White;
            check_out.Location = new Point(913, 349);
            check_out.Name = "check_out";
            check_out.Size = new Size(305, 51);
            check_out.TabIndex = 2;
            check_out.Text = "Checkout";
            check_out.UseVisualStyleBackColor = false;
            check_out.Click += check_out_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 3;
            label1.Text = "Subtotal: ";
            // 
            // total_price
            // 
            total_price.AutoSize = true;
            total_price.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total_price.Location = new Point(233, 97);
            total_price.Name = "total_price";
            total_price.Size = new Size(57, 21);
            total_price.TabIndex = 4;
            total_price.Text = "label2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label21);
            panel1.Controls.Add(sub_total);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(taxes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(total_price);
            panel1.Location = new Point(913, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 138);
            panel1.TabIndex = 5;
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Location = new Point(40, 79);
            label21.Name = "label21";
            label21.Size = new Size(250, 2);
            label21.TabIndex = 31;
            // 
            // sub_total
            // 
            sub_total.AutoSize = true;
            sub_total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sub_total.Location = new Point(233, 9);
            sub_total.Name = "sub_total";
            sub_total.Size = new Size(52, 21);
            sub_total.TabIndex = 8;
            sub_total.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 7;
            label4.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 5;
            label2.Text = "Estimated taxes:";
            // 
            // taxes
            // 
            taxes.AutoSize = true;
            taxes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taxes.Location = new Point(233, 40);
            taxes.Name = "taxes";
            taxes.Size = new Size(52, 21);
            taxes.TabIndex = 6;
            taxes.Text = "label2";
            // 
            // shopping_cart_view
            // 
            shopping_cart_view.AllowUserToAddRows = false;
            shopping_cart_view.AllowUserToDeleteRows = false;
            shopping_cart_view.AllowUserToResizeColumns = false;
            shopping_cart_view.AllowUserToResizeRows = false;
            shopping_cart_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shopping_cart_view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            shopping_cart_view.BorderStyle = BorderStyle.Fixed3D;
            shopping_cart_view.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            shopping_cart_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shopping_cart_view.Location = new Point(85, 175);
            shopping_cart_view.Name = "shopping_cart_view";
            shopping_cart_view.RowHeadersWidth = 51;
            shopping_cart_view.RowTemplate.Height = 25;
            shopping_cart_view.Size = new Size(786, 479);
            shopping_cart_view.TabIndex = 0;
            shopping_cart_view.CellContentClick += shopping_cart_view_CellContentClick;
            // 
            // user_label
            // 
            user_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_label.AutoSize = true;
            user_label.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_label.ForeColor = Color.White;
            user_label.Location = new Point(19, 20);
            user_label.Name = "user_label";
            user_label.Size = new Size(139, 25);
            user_label.TabIndex = 22;
            user_label.Text = "Shopping Cart";
            // 
            // top_back_panel
            // 
            top_back_panel.BackColor = Color.FromArgb(50, 55, 143);
            top_back_panel.Controls.Add(user_label);
            top_back_panel.Location = new Point(0, 0);
            top_back_panel.Name = "top_back_panel";
            top_back_panel.Size = new Size(1497, 63);
            top_back_panel.TabIndex = 23;
            // 
            // cart_qnty_label
            // 
            cart_qnty_label.AutoSize = true;
            cart_qnty_label.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            cart_qnty_label.Location = new Point(231, 112);
            cart_qnty_label.Name = "cart_qnty_label";
            cart_qnty_label.Size = new Size(476, 47);
            cart_qnty_label.TabIndex = 24;
            cart_qnty_label.Text = "Your Shopping Cart is empty";
            // 
            // shopping_cart_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cart_qnty_label);
            Controls.Add(top_back_panel);
            Controls.Add(panel1);
            Controls.Add(check_out);
            Controls.Add(clear_button);
            Controls.Add(shopping_cart_view);
            Name = "shopping_cart_page";
            Size = new Size(1313, 769);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).EndInit();
            top_back_panel.ResumeLayout(false);
            top_back_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button clear_button;
        private Button check_out;
        private Label label1;
        private Label total_price;
        private Panel panel1;
        private Label sub_total;
        private Label label4;
        private Label label2;
        private Label taxes;
        private DataGridView shopping_cart_view;
        private Label user_label;
        private Panel top_back_panel;
        private Label cart_qnty_label;
        private Label label21;
    }
}
