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
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart_view)).BeginInit();
            this.SuspendLayout();
            // 
            // shopping_cart_view
            // 
            this.shopping_cart_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopping_cart_view.Location = new System.Drawing.Point(75, 116);
            this.shopping_cart_view.Name = "shopping_cart_view";
            this.shopping_cart_view.RowHeadersWidth = 51;
            this.shopping_cart_view.RowTemplate.Height = 25;
            this.shopping_cart_view.Size = new System.Drawing.Size(1120, 540);
            this.shopping_cart_view.TabIndex = 0;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(581, 42);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear Cart";
            this.clear_button.UseVisualStyleBackColor = true;
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
            // shopping_cart_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.shopping_cart_view);
            this.Name = "shopping_cart_page";
            this.Size = new System.Drawing.Size(1315, 771);
            ((System.ComponentModel.ISupportInitialize)(this.shopping_cart_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView shopping_cart_view;
        private Button clear_button;
        private Button check_out;
    }
}
