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
            this.shopping_cart_view = new System.Windows.Forms.DataGridView();
            this.clear_button = new System.Windows.Forms.Button();
            this.check_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopping_cart_view
            // 
            this.shopping_cart_view.AllowUserToAddRows = false;
            this.shopping_cart_view.AllowUserToDeleteRows = false;
            this.shopping_cart_view.AllowUserToResizeColumns = false;
            this.shopping_cart_view.AllowUserToResizeRows = false;
            this.shopping_cart_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shopping_cart_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.shopping_cart_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.shopping_cart_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopping_cart_view.Location = new System.Drawing.Point(75, 116);
            this.shopping_cart_view.Name = "shopping_cart_view";
            this.shopping_cart_view.ReadOnly = true;
            this.shopping_cart_view.RowHeadersWidth = 51;
            this.shopping_cart_view.RowTemplate.Height = 25;
            this.shopping_cart_view.Size = new System.Drawing.Size(786, 621);
            this.shopping_cart_view.TabIndex = 0;
            this.shopping_cart_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shopping_cart_view_CellContentClick);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(581, 42);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear Cart";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // check_out
            // 
            this.check_out.Location = new System.Drawing.Point(716, 42);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(75, 23);
            this.check_out.TabIndex = 2;
            this.check_out.Text = "Checkout";
            this.check_out.UseVisualStyleBackColor = true;
            this.check_out.Click += new System.EventHandler(this.check_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal: ";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Location = new System.Drawing.Point(252, 67);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(38, 15);
            this.total_price.TabIndex = 4;
            this.total_price.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sub_total);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taxes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.total_price);
            this.panel1.Location = new System.Drawing.Point(893, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 98);
            this.panel1.TabIndex = 5;
            // 
            // sub_total
            // 
            this.sub_total.AutoSize = true;
            this.sub_total.Location = new System.Drawing.Point(252, 5);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(38, 15);
            this.sub_total.TabIndex = 8;
            this.sub_total.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estimated taxes:";
            // 
            // taxes
            // 
            this.taxes.AutoSize = true;
            this.taxes.Location = new System.Drawing.Point(252, 36);
            this.taxes.Name = "taxes";
            this.taxes.Size = new System.Drawing.Size(38, 15);
            this.taxes.TabIndex = 6;
            this.taxes.Text = "label2";
            // 
            // shopping_cart_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.shopping_cart_view);
            this.Name = "shopping_cart_page";
            this.Size = new System.Drawing.Size(1315, 771);
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView shopping_cart_view;
        private Button clear_button;
        private Button check_out;
        private Label label1;
        private Label total_price;
        private Panel panel1;
        private Label sub_total;
        private Label label4;
        private Label label2;
        private Label taxes;
    }
}
