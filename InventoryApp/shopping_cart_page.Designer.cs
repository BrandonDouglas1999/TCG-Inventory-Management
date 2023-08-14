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
            sub_total = new Label();
            label4 = new Label();
            label2 = new Label();
            taxes = new Label();
            shopping_cart_view = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).BeginInit();
            SuspendLayout();
            // 
            // clear_button
            // 
            clear_button.Location = new Point(664, 56);
            clear_button.Margin = new Padding(3, 4, 3, 4);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(86, 31);
            clear_button.TabIndex = 1;
            clear_button.Text = "Clear Cart";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // check_out
            // 
            check_out.Location = new Point(818, 56);
            check_out.Margin = new Padding(3, 4, 3, 4);
            check_out.Name = "check_out";
            check_out.Size = new Size(86, 31);
            check_out.TabIndex = 2;
            check_out.Text = "Checkout";
            check_out.UseVisualStyleBackColor = true;
            check_out.Click += check_out_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "Subtotal: ";
            // 
            // total_price
            // 
            total_price.AutoSize = true;
            total_price.Location = new Point(288, 89);
            total_price.Name = "total_price";
            total_price.Size = new Size(50, 20);
            total_price.TabIndex = 4;
            total_price.Text = "label2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(sub_total);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(taxes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(total_price);
            panel1.Location = new Point(1021, 155);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 130);
            panel1.TabIndex = 5;
            // 
            // sub_total
            // 
            sub_total.AutoSize = true;
            sub_total.Location = new Point(288, 7);
            sub_total.Name = "sub_total";
            sub_total.Size = new Size(50, 20);
            sub_total.TabIndex = 8;
            sub_total.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 83);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 7;
            label4.Text = "Subtotal: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 5;
            label2.Text = "Estimated taxes:";
            // 
            // taxes
            // 
            taxes.AutoSize = true;
            taxes.Location = new Point(288, 48);
            taxes.Name = "taxes";
            taxes.Size = new Size(50, 20);
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
            shopping_cart_view.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            shopping_cart_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shopping_cart_view.Location = new Point(86, 155);
            shopping_cart_view.Margin = new Padding(3, 4, 3, 4);
            shopping_cart_view.Name = "shopping_cart_view";
            shopping_cart_view.RowHeadersWidth = 51;
            shopping_cart_view.RowTemplate.Height = 25;
            shopping_cart_view.Size = new Size(898, 828);
            shopping_cart_view.TabIndex = 0;
            shopping_cart_view.CellContentClick += shopping_cart_view_CellContentClick;
            // 
            // shopping_cart_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(check_out);
            Controls.Add(clear_button);
            Controls.Add(shopping_cart_view);
            Margin = new Padding(3, 4, 3, 4);
            Name = "shopping_cart_page";
            Size = new Size(1503, 1028);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).EndInit();
            ResumeLayout(false);
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
    }
}
